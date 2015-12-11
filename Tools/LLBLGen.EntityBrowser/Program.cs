﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AW.Helper;

namespace LLBLGen.EntityBrowser
{
  static class Program
  {
    /// <summary>
    ///   Handles the ThreadException event of the Application control. Needed to use to avoid the
    ///   NativeWindow.DebuggableCallBack method when debugging.
    /// </summary>
    /// <remarks>http://support.microsoft.com/kb/836674</remarks>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Threading.ThreadExceptionEventArgs" /> instance containing the event data.</param>
    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      using (var dialog = new ThreadExceptionDialog(e.Exception))
      {
        GeneralHelper.TraceOut(e.Exception.ToString());
        if (!e.Exception.StackTrace.Contains("System.Windows.Forms.DataGridTextBoxColumn.GetText(Object value)")) //As DataGrid doesn't have DataError event
          dialog.ShowDialog();
      }
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += Application_ThreadException;
      // Set the unhandled exception mode to force all Windows Forms errors to go through
      // our handler.
      Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

      // Add the event handler for handling non-UI thread exceptions to the event. 
      AppDomain.CurrentDomain.UnhandledException +=
          new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

      Application.Run(new MainForm());
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      try
      {
        Exception ex = (Exception)e.ExceptionObject;
        string errorMsg = "An application error occurred. Please contact the adminstrator " +
            "with the following information:\n\n";

        // Since we can't prevent the app from terminating, log this to the event log.
        if (!EventLog.SourceExists("ThreadException"))
        {
          EventLog.CreateEventSource("ThreadException", "Application");
        }

        // Create an EventLog instance and assign its source.
        EventLog myLog = new EventLog();
        myLog.Source = "ThreadException";
        myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
      }
      catch (Exception exc)
      {
        try
        {
          MessageBox.Show("Fatal Non-UI Error",
              "Fatal Non-UI Error. Could not write the error to the event log. Reason: "
              + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        finally
        {
          Application.Exit();
        }
      }
    }
  }
}
