﻿using System;
using System.Configuration;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers
{
  public partial class FrmPersistantLocation : Form
  {
    private SettingsPropertyValue _windowSettingsSettingsProperty;
    private string _windowSettingsName;

    public string WindowSettingsName
    {
      private get
      {
        if (String.IsNullOrEmpty(_windowSettingsName))
          _windowSettingsName = GetType().Name + "WindowSettings";
        return _windowSettingsName;
      }
      set { _windowSettingsName = value; }
    }

    public FrmPersistantLocation()
    {
      InitializeComponent();
    }

    public static FrmPersistantLocation ShowControlInForm(Control control, string formTitle = null, Form parentForm = null, string windowSettingsName = null)
    {
      var form = new FrmPersistantLocation
      {
        WindowSettingsName = windowSettingsName,
        Text = formTitle,
        Icon = parentForm == null ? null : parentForm.Icon,
      };
      control.Dock = DockStyle.Fill;
    form.Controls.Add(control);
      AWHelper.ShowForm(form, parentForm);
      return form;
    }

    private WindowSettings WindowSettings
    {
      get
      {
        if (WindowSettingsSettingsProperty != null)
          return WindowSettingsSettingsProperty.PropertyValue as WindowSettings;
        return null;
      }
      set
      {
        if (WindowSettingsSettingsProperty != null)
          WindowSettingsSettingsProperty.PropertyValue = value;
      }
    }

    protected virtual SplitContainer[] Splitters
    {
      get { return null; }
    }

    private SettingsPropertyValue WindowSettingsSettingsProperty
    {
      get { return _windowSettingsSettingsProperty ?? (_windowSettingsSettingsProperty = GeneralHelper.GetSetting(Settings.Default, WindowSettingsName, typeof (WindowSettings))); }
    }

    #region Overrides of Form

    /// <summary>
    ///   Raises the CreateControl event.
    /// </summary>
    protected override void OnCreateControl()
    {
      RestoreWindowSettings();
      base.OnCreateControl();
    }

    /// <summary>
    ///   Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" /> event.
    /// </summary>
    /// <param name="e">
    ///   A <see cref="T:System.Windows.Forms.FormClosingEventArgs" /> that contains the event data.
    /// </param>
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      RecordWindowSettings();
      base.OnFormClosing(e);
    }

    /// <summary>
    ///   Raises the <see cref="E:System.Windows.Forms.Form.FormClosed" /> event.
    /// </summary>
    /// <param name="e">
    ///   A <see cref="T:System.Windows.Forms.FormClosedEventArgs" /> that contains the event data.
    /// </param>
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      base.OnFormClosed(e);
      Settings.Default.Save();
    }

    #endregion

    protected virtual void RestoreWindowSettings()
    {
      if (!DesignMode && WindowSettings != null)
        WindowSettings.Restore(this, Splitters);
    }

    private void RecordWindowSettings()
    {
      if (WindowSettings == null)
        WindowSettings = new WindowSettings();
      // ReSharper disable ConditionIsAlwaysTrueOrFalse
      if (WindowSettings != null)
        // ReSharper restore ConditionIsAlwaysTrueOrFalse
        WindowSettings.Record(this, Splitters);
    }

    //private void FrmPersistantLocation_Resize(object sender, EventArgs e)
    //{
    //  Text = Size.ToString();
    //}
  }
}