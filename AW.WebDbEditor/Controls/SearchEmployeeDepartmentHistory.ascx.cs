﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.HelperClasses;

/// <summary>
/// Control class to search one or more 'EmployeeDepartmentHistory' entity instances
/// </summary>
public partial class Controls_SearchEmployeeDepartmentHistory : System.Web.UI.UserControl, ISearchControl
{
	#region Events
	/// <summary>
	/// Event which is raised when the user clicked a search button. After this event, the 'Filter' property is valid.
	/// </summary>
	public event EventHandler SearchClicked;
	#endregion
	
	#region Class Member Declarations
	private PredicateExpression _filter;
	#endregion
		
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void Page_Load(object sender, EventArgs e)
	{
        if (!IsPostBack)
        {
            sortLookupDropDownList();
        }
	}
	
	/// <summary>
	/// Creates a predicate expression filter based on the query string passed in. 
	/// </summary>
	/// <param name="queryString">The query string with PK field names and values.</param>
	/// <returns>a predicate expression with a filter on the pk fields and values.</returns>
	public PredicateExpression CreateFilter(NameValueCollection queryString)
	{
		PredicateExpression toReturn = new PredicateExpression();
		string valueFromQueryString = null;
		valueFromQueryString = queryString["DepartmentID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(EmployeeDepartmentHistoryFields.DepartmentID==Convert.ChangeType(valueFromQueryString, typeof(System.Int16)));
		}
		valueFromQueryString = queryString["EmployeeID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(EmployeeDepartmentHistoryFields.EmployeeID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
		}
		valueFromQueryString = queryString["ShiftID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(EmployeeDepartmentHistoryFields.ShiftID==Convert.ChangeType(valueFromQueryString, typeof(System.Byte)));
		}
		valueFromQueryString = queryString["StartDate"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(EmployeeDepartmentHistoryFields.StartDate==Convert.ChangeType(valueFromQueryString, typeof(System.DateTime)));
		}
		return toReturn;
	}

	/// <summary>
	/// Handles the Click event of the btnCancel control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnCancel_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}


	/// <summary>
	/// Handles the Click event of the btnSearchPK control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnSearchPk_Click(object sender, EventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}
		_filter = new PredicateExpression();
		_filter.AddWithAnd(EmployeeDepartmentHistoryFields.DepartmentID==Convert.ChangeType(tbxDepartmentID.Text, typeof(System.Int16)));
		_filter.AddWithAnd(EmployeeDepartmentHistoryFields.EmployeeID==Convert.ChangeType(tbxEmployeeID.Text, typeof(System.Int32)));
		_filter.AddWithAnd(EmployeeDepartmentHistoryFields.ShiftID==Convert.ChangeType(tbxShiftID.Text, typeof(System.Byte)));
		_filter.AddWithAnd(EmployeeDepartmentHistoryFields.StartDate==dtxStartDate.Value);
		if((SearchClicked!=null) && (_filter.Count>0))
		{
			SearchClicked(this, new EventArgs());
		}
	}


	/// <summary>
	/// Handles the Click event of the btnSearchSubSet control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnSearchSubSet_Click(object sender, EventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}

		_filter = new PredicateExpression();
		IPredicate toAdd = null;
		if(chkEnableDepartmentID.Checked)
		{
			string fromValueAsString = tbxDepartmentIDMiFrom.Text;
			string toValueAsString = tbxDepartmentIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(EmployeeDepartmentHistoryFields.DepartmentID, Convert.ToInt32(opDepartmentID.SelectedValue), chkNotDepartmentID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableEmployeeID.Checked)
		{
			string fromValueAsString = tbxEmployeeIDMiFrom.Text;
			string toValueAsString = tbxEmployeeIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(EmployeeDepartmentHistoryFields.EmployeeID, Convert.ToInt32(opEmployeeID.SelectedValue), chkNotEmployeeID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableEndDate.Checked)
		{
			object fromValue = dtxEndDateMiFrom.Value;
			object toValue = dtxEndDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(EmployeeDepartmentHistoryFields.EndDate, Convert.ToInt32(opEndDate.SelectedValue), chkNotEndDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableModifiedDate.Checked)
		{
			object fromValue = dtxModifiedDateMiFrom.Value;
			object toValue = dtxModifiedDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(EmployeeDepartmentHistoryFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableShiftID.Checked)
		{
			string fromValueAsString = tbxShiftIDMiFrom.Text;
			string toValueAsString = tbxShiftIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(EmployeeDepartmentHistoryFields.ShiftID, Convert.ToInt32(opShiftID.SelectedValue), chkNotShiftID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStartDate.Checked)
		{
			object fromValue = dtxStartDateMiFrom.Value;
			object toValue = dtxStartDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(EmployeeDepartmentHistoryFields.StartDate, Convert.ToInt32(opStartDate.SelectedValue), chkNotStartDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(SearchClicked != null)
		{
			SearchClicked(this, new EventArgs());
		}
	}
  
	/// <summary>
	/// Method called at Page_Load to sort defined LookupDropDownList results
	/// </summary>
	private void sortLookupDropDownList()
	{
		
 	}
	
	#region Class Property Declarations
	/// <summary>
	/// Gets the filter formulated with the values specified in the search control. Valid after SearchClicked has been raised. 
	/// </summary>
	public PredicateExpression Filter 
	{ 
		get { return _filter;}
	}
	
	/// <summary>
	/// Sets the flag for allowing single entity searches. If set to true, the search control will show PK fields and if applicable, UC fields.
	/// </summary>
	public bool AllowSingleEntitySearches
	{ 
		set
		{
			phSingleInstance.Visible=value;
		}
	}
	
	/// <summary>
	/// Sets the flag for allowing multi entity searches. If set to true, the search control will show fields to formulate a search over all fields, and 
	/// thus a filter which could lead to multiple results.
	/// </summary>
	public bool AllowMultiEntitySearches 
	{ 
		set
		{
			phMultiInstance.Visible=value;
		}
	}
	#endregion
}
