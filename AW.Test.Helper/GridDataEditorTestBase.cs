using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GridDataEditorTestBase = AW.Test.Helpers.GridDataEditorTestBase;

namespace AW.Test.Helpers
{
  public class GridDataEditorTestBase : NUnitFormMSTest
  {
    protected int ExpectedColumnCount;
    protected int ActualColumnCount;
    private const BindingFlags FieldBindingFlags = BindingFlags.Instance | BindingFlags.Public;

    /// <summary>
    ///   Edits the enumerable in a DataGridView.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="dataEditorPersister"> The grid data editor persister. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable<T> ShowInGrid<T>(IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize = GridDataEditor.DefaultPageSize)
    {
      if (enumerable != null)
        FrmDataEditor.CreateDataEditorForm(enumerable, dataEditorPersister, pageSize, false).ShowDialog();
      return enumerable;
    }

    protected void TestShowInGrid<T>(IEnumerable<T> enumerable, int numProperties = -1, int numFieldsToShow = 0, IDataEditorPersister dataEditorPersister = null)
    {
      ModalFormHandler = Handler;
      numProperties = GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
      var actual = GridDataEditorTestBase.ShowInGrid(enumerable, dataEditorPersister);
      Assert.AreEqual<IEnumerable<T>>(enumerable, actual);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
      TestEditInDataGridView(enumerable, numProperties, numFieldsToShow, dataEditorPersister);
    }

    protected int GetNumberOfColumns<T>(int numProperties, ref int numFieldsToShow)
    {
      ExpectedColumnCount = numProperties + numFieldsToShow;
      if (ExpectedColumnCount < 0)
      {
        numProperties = MetaDataHelper.GetPropertiesToDisplay(typeof (T)).Count();
        numFieldsToShow = typeof (T).GetFields(FieldBindingFlags).Count();
        ExpectedColumnCount = numProperties + numFieldsToShow;
      }
      return numProperties;
    }

    public static IEnumerable ShowInGrid(IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize = GridDataEditor.DefaultPageSize)
    {
      if (enumerable != null)
        FrmDataEditor.CreateDataEditorForm(enumerable, dataEditorPersister, pageSize).ShowDialog();
      return enumerable;
    }

    protected void TestEditInDataGridView(IEnumerable enumerable, int numProperties = -1, int numFieldsToShow = 0, IDataEditorPersister dataEditorPersister = null)
    {
      if (enumerable != null)
        ModalFormHandler = Handler;
      ExpectedColumnCount = numProperties + numFieldsToShow;
      var actual = ShowInGrid(enumerable, dataEditorPersister);
      Assert.AreEqual<IEnumerable>(enumerable, actual);
      if (enumerable != null)
      {
        var displayPropertyCount = MetaDataHelper.GetPropertiesToDisplay(enumerable).Count();
        if (displayPropertyCount == 0)
          if (ValueTypeWrapper.TypeNeedsWrappingForBinding(MetaDataHelper.GetEnumerableItemType(enumerable)))
            displayPropertyCount = MetaDataHelper.GetPropertiesToDisplay(ValueTypeWrapper.CreateWrapperForBinding(enumerable)).Count();

        if (numProperties > 0)
        {
          Assert.AreEqual(numProperties, displayPropertyCount);
        }
        else if (numProperties < 0)
        {
          ExpectedColumnCount = displayPropertyCount;
        }
        Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
      }
    }

    protected void Handler(string name, IntPtr hWnd, Form form)
    {
      //Assert.AreEqual(1, ((FrmDataEditor)form). .ColumnCount);
      //var dataGridView = new DataGridViewTester("dataGridView", name);
      //	if (_expectedColumnCount > 0)
      {
        var dataGridView = GetDataGridViewFromGridDataEditor(form);
        ActualColumnCount = dataGridView.ColumnCount;
        if (ExpectedColumnCount == ActualColumnCount)
          form.Close();
        else
        {
          Debugger.Break();
        }
      }
    }

    public static DataGridView GetDataGridViewFromGridDataEditor(Form form)
    {
      return ((DataGridView) form.Controls.All().FirstOrDefault(c => c is DataGridView));
    }
  }
}