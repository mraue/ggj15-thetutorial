using System.Diagnostics;
using System;
using System.Text;
using UnityEngine;

namespace GGJ15.TheTutorial
{
	public delegate void LogHandler(string message);

	public static class Log
	{

		public const string SEVERITY_FATAL = "fatal";
		public const string SEVERITY_ERROR = "error";
		public const string SEVERITY_WARNING = "warning";
		public const string SEVERITY_INFO = "info";

		public static bool Assert(bool condition, string error, string message = "")
		{		
			if (!condition)
			{
				LogMessage(error, "", SEVERITY_ERROR);
			}

			return condition;
		}

		public static bool AssertFatal(bool condition, string error, string message = "")
		{		
			if (!condition)
			{
				LogMessage(error, "", SEVERITY_FATAL);
				throw new AssertionFailedException();
			}

			return condition;
		}

		public static void Error(string error, string message = "")
		{
			LogMessage(error, "", SEVERITY_ERROR);
		}

		public static void Warning(string error, string message = "")
		{
			LogMessage(error, message, SEVERITY_WARNING);
		}

		public static void Info(string message)
		{
			LogMessage(message, "", SEVERITY_INFO);
		}			

		private static void LogMessage(string reason, string message, string severity)
		{
			#if (UNITY_EDITOR || DEVELOPMENT_BUILD)
			UnityEngine.Debug.Log(GetMessage(reason, message, severity));
			#endif
		}

		private static string GetMessage(string reason, string message, string severity, bool includeStacktrace = false)
		{   
			StringBuilder msg = new StringBuilder();
			msg.Append("[");
			msg.Append(severity.ToUpper());
			msg.Append("] ");
			msg.Append(reason);

			if (message != "")
			{
				msg.Append(" / ");
				msg.Append(message);
			}

			if (includeStacktrace)
			{
				StackTrace stackTrace = new StackTrace();
				msg.Append(stackTrace);
			}
             
			return msg.ToString();
		}

		public class AssertionFailedException : Exception
		{
		}
	}
}
