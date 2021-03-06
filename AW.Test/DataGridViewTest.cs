﻿using System;
using System.Windows.Forms;
using AW.Test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
  [TestClass]
  public class DataGridViewTest : NUnitFormMSTest
  {
    private DataGridViewTester _dataGridView;
    private DataGridViewTestForm _dataGridViewTestForm;

    #region Overrides of NUnitFormMSTest

    /// <summary>
    ///   Override this Setup method if you have custom behavior to execute before each test
    ///   in your fixture.
    /// </summary>
    protected override void Setup()
    {
      _dataGridViewTestForm = new DataGridViewTestForm {dataGridView = {DataSource = SerializableBaseClass.GenerateList()}};
    }

    #endregion

    //Use TestInitialize to run code before running each test
    [TestInitialize]
    public void MyTestInitialize()
    {
      Init();
    }

    //Use TestCleanup to run code after each test has run
    [TestCleanup]
    public void MyTestCleanup()
    {
      Verify();
    }

    [TestMethod]
    public void TestColumnsNonModal()
    {
      _dataGridViewTestForm.Show();
      _dataGridView = new DataGridViewTester("dataGridView");
      Assert.AreEqual(1, _dataGridView.Properties.ColumnCount);
    }

    [TestMethod]
    public void TestColumnsModal()
    {
      ModalFormHandler = Handler;
      _dataGridViewTestForm.ShowDialog();
    }

    private static void Handler(string name, IntPtr hWnd, Form form)
    {
      Assert.AreEqual(1, ((DataGridViewTestForm) form).dataGridView.ColumnCount);
      form.Close();
    }
  }
}