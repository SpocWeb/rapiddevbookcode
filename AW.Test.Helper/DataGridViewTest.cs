﻿using System.Linq;
using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace AW.Test.Helpers
{
  [TestFixture]
  internal class DataGridViewTest : NUnitFormTest
  {
    private DataGridViewTester _dataGridView;

    #region Overrides of NUnitFormTest

    /// <summary>
    ///   Override this Setup method if you have custom behavior to execute before each test
    ///   in your fixture.
    /// </summary>
    public override void Setup()
    {
      var f = new DataGridViewTestForm();
      f.Show();
      _dataGridView = new DataGridViewTester("dataGridView");
    }

    #endregion

    //[Test]
    public void Select()
    {
      var x = _dataGridView.Any();
    }
  }
}