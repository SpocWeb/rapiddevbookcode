﻿using System;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

public partial class Controls_ListSalesOrderHeaderSalesReasonInstancesReport : System.Web.UI.UserControl, IListControl
{
	protected void Page_Load(object sender, EventArgs e)
	{
		PrefetchPath path = new PrefetchPath((int)EntityType.SalesOrderHeaderSalesReasonEntity);
		

		_SalesOrderHeaderSalesReasonDS.PrefetchPathToUse = path;
	}


	/// <summary>
	/// Handles the Click event of the btnHome control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnHome_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}
	
	
	/// <summary>
	/// Handles the Click event of the btnAddNew control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnAddNew_Click(object sender, EventArgs e)
	{
		object additionalFilters = ViewState["additionalFilters"];
		string additionalFiltersAsString = string.Empty;
		if(additionalFilters != null)
		{
			additionalFiltersAsString = (string)additionalFilters;
		}
		Response.Redirect("~/AddNew.aspx?EntityType=" + (int)EntityType.SalesOrderHeaderSalesReasonEntity + additionalFiltersAsString);
	}
		


	/// <summary>
	/// Sets the containing entity for the entities enlisted in this control. When a particular containing entity is set (e.g. 'Customer' for orders), the
	/// set entity is used to obtain the filter for the entities to show, and FilterToUse is then overruled. The entity is also used to produce FK field values
	/// for AddNew, so for example when a list of orders is shown, which are related to customer, the AddNew button should make the order's AddNew form preselect
	/// the Customer.
	/// </summary>
	/// <param name="containingEntity">The containing entity instance</param>
	/// <param name="name">the field name mapped on the relation from the containing entity with this entity</param>
	public void SetContainingEntity(IEntityCore containingEntity, string name)
	{
		IPredicateExpression dsFilter;
		switch(containingEntity.LLBLGenProEntityName)
		{
			case "SalesOrderHeaderEntity":
				switch(name)
				{
					case "SalesOrderHeaderSalesReasons":
						dsFilter = new PredicateExpression();
						dsFilter.AddWithAnd(SalesOrderHeaderSalesReasonFields.SalesOrderID == ((SalesOrderHeaderEntity)containingEntity).SalesOrderID);
						_SalesOrderHeaderSalesReasonDS.FilterToUse = dsFilter;
						ViewState["additionalFilters"] = "&SalesOrderID=" + 
								((SalesOrderHeaderEntity)containingEntity).SalesOrderID +
								"&20FkField=SalesOrderID";
						break;
					default:
						break;
				}
				break;
			case "SalesReasonEntity":
				switch(name)
				{
					case "SalesOrderHeaderSalesReasons":
						dsFilter = new PredicateExpression();
						dsFilter.AddWithAnd(SalesOrderHeaderSalesReasonFields.SalesReasonID == ((SalesReasonEntity)containingEntity).SalesReasonID);
						_SalesOrderHeaderSalesReasonDS.FilterToUse = dsFilter;
						ViewState["additionalFilters"] = "&SalesReasonID=" + 
								((SalesReasonEntity)containingEntity).SalesReasonID +
								"&20FkField=SalesReasonID";
						break;
					default:
						break;
				}
				break;
			default:
				break;
		}
	}


	/// <summary>
	/// Sets the filter to use for the ListControl's datasource control.
	/// </summary>
	public IPredicateExpression FilterToUse 
	{
		set { _SalesOrderHeaderSalesReasonDS.FilterToUse = value; }
	}

    /// <summary>
    /// Ask to reload its data
    /// </summary>
    public void GridDataBind()
    {
        theReportViewer.LocalReport.Refresh();
    }

	/// <summary>
	/// Sets the flag to show the Home button or not. The home button is hidden when the control is shown inside a form with other information.
	/// </summary>
	public bool ShowHomeButton 
	{
		set { phHomeButton.Visible = value; }
	}	


	/// <summary>
	/// Sets the flag to show the AddNew button or not. The AddNew button is hidden when the data in the control is the data of an m:n relation.
	/// </summary>
	public bool ShowAddNewButton 
	{
		set 
		{ 

			phAddNewButton.Visible = value; 

		}
	}	
}