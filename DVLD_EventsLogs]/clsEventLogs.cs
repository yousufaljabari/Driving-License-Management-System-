using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_EventsLogs_
{
  
          public class clsEventLogs
        {
            private static string LogSource = "DVLD-Project";
            private static string logName = "Application";

            public static void LogSuccessfulLogin(string Username)
            {
                EventLog.WriteEntry(LogSource, $"User {Username} Logged into system successfully.", EventLogEntryType.Information);
            }
            public static void LogOut(string Username)
            {
                EventLog.WriteEntry(LogSource, $"User {Username} Logged out of the  system successfully.", EventLogEntryType.Information);
            }

            public static void LogFailedLogin()
            {
                EventLog.WriteEntry(LogSource, $"Failed to log into the system", EventLogEntryType.Warning);
            }

            public static void LogError(Exception Message)
            {
                EventLog.WriteEntry(LogSource, Message.ToString(), EventLogEntryType.Warning);
            }

            public static bool CreateEventLogSource()
            {
                try
                {
                    if (!EventLog.SourceExists(LogSource))
                    {
                        EventLog.CreateEventSource(LogSource, logName);
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
        }
    }
