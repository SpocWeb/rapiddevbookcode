﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.EntityViewer;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public partial class UsrCntrlEntityBrowser : UserControl
	{
		private readonly Type _baseType;
		private readonly ILinqMetaData _linqMetaData;
    private object _selectedObject;
    private bool _userHasInteracted;

    public UsrCntrlEntityBrowser()
		{
			InitializeComponent();
		}

		public UsrCntrlEntityBrowser(Type baseType) : this()
		{
			_baseType = baseType;
			LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, GetEntitiesTypes());
		}

		public UsrCntrlEntityBrowser(ILinqMetaData linqMetaData) : this()
		{
			_linqMetaData = linqMetaData;
		  var entitiesTypes = GetEntitiesTypes();
		  var firstEntityType = entitiesTypes.FirstOrDefault();
		  if (firstEntityType != null)
		  {
		    IDataAccessAdapter adapter = null;
		    if (firstEntityType.Implements(typeof (IEntity2)))
		    {
		      dynamic dlinqMetaData = linqMetaData;
		      if (dlinqMetaData != null) adapter = dlinqMetaData.AdapterToUse;
		    }
		    LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities.Nodes, entitiesTypes, adapter);
		  }
		  if (treeViewEntities.Nodes.Count == 0)
			  LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities.Nodes, _linqMetaData.GetType());
		}


		#region Overrides of Form

		/// <summary>
		/// Raises the CreateControl event.
		/// </summary>
		protected override void OnCreateControl()
		{
			gridDataEditor.bindingSourceEnumerable.CurrentChanged += bindingSourceEnumerable_CurrentChanged;
			if (treeViewEntities.Nodes.Count == 0)
				LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, GetEntitiesTypes());
			base.OnCreateControl();
		}

		#endregion

		public IEnumerable<Type> GetEntitiesTypes()
		{
			if (_baseType != null)
				return MetaDataHelper.GetDescendants(_baseType);
			return _linqMetaData == null ? EntityHelper.GetEntitiesTypes() : EntityHelper.GetEntitiesTypes(_linqMetaData);
		}

		private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(((TreeNode) e.Item).Text, DragDropEffects.All);
		}

		private void bindingSourceEnumerable_CurrentChanged(object sender, EventArgs e)
		{
			_selectedObject = gridDataEditor.bindingSourceEnumerable.Current;
		}

		private void treeViewEntities_AfterSelect(object sender, TreeViewEventArgs e)
		{
			_selectedObject = treeViewEntities.SelectedNode.Tag;
      if (!_userHasInteracted)
        return;
			var prop = treeViewEntities.SelectedNode.Tag as PropertyDescriptor;
			if (prop != null)
			{
				var typeParameter = ListBindingHelper.GetListItemType(prop.PropertyType);
				//if (typeof(IEntityCore).IsAssignableFrom(prop.PropertyType))
				//  typeParameter = prop.PropertyType;
				//if (typeParameter == null)
				//  typeParameter = MetaDataHelper.GetTypeParameterOfGenericType(prop.PropertyType);
				if (typeParameter != null)
					if (treeViewEntities.Nodes.ContainsKey(typeParameter.Name))
					{
						treeViewEntities.SelectedNode = treeViewEntities.Nodes[typeParameter.Name];
						treeViewEntities.SelectedNode.Expand();
					}
			}
			else 
			{
				openPagedToolStripMenuItem_Click(sender, e);
			}
			toolStripStatusLabelSelected.Text = treeViewEntities.SelectedNode.Text;
		}

		private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
		{
			Open(0);
		}

		private void Open(ushort pageSize)
		{
			var entityQueryable = GetEntityQueryable();
			if (entityQueryable != null)
				ViewEntities(entityQueryable, pageSize);
		}

		private IQueryable GetEntityQueryable()
		{
			var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
			IQueryable entityQueryable = null;
			if (typeOfEntity != null && _linqMetaData != null)
			{
				var dataSource = _linqMetaData.GetQueryableForEntity(typeOfEntity);
				entityQueryable = dataSource as IQueryable;
			}
			return entityQueryable;
		}

		private void ViewEntities(IQueryable entityQueryable, ushort pageSize)
		{
			if (gridDataEditor.DataEditorPersister == null)
				if (typeof (IEntity).IsAssignableFrom(entityQueryable.ElementType))
					gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister();
				else
				{
					var provider = entityQueryable.Provider as LLBLGenProProvider2;
					if (provider != null)
						gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(provider.AdapterToUse);
				}
			gridDataEditor.BindEnumerable(entityQueryable, pageSize);
		}

		private void openPagedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Open(DataEditorExtensions.DefaultPageSize);
		}

		private void getCountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var entityQueryable = GetEntityQueryable();
			if (entityQueryable != null)
				toolStripStatusLabelSelected.Text = entityQueryable.Count().ToString();
		}

		private void treeViewEntities_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (!e.Node.IsExpanded)
				openPagedToolStripMenuItem_Click(sender, e);
		}

		private void treeViewEntities_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.Node.Tag != null)
			{
				treeViewEntities.SelectedNode = e.Node;
				contextMenuStrip1.Show(treeViewEntities, e.Location);
			}
		}

		private void viewInPropertyGridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_selectedObject = treeViewEntities.SelectedNode.Tag;
		}

		private void viewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var entityQueryable = GetEntityQueryable();
			if (entityQueryable != null)
			{
				_selectedObject = entityQueryable;

			}
		}

		private void viewFieldsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
			var fields = EntityHelper.CreateEntity(typeOfEntity).Fields;
			_selectedObject = fields;
			gridDataEditor.BindEnumerable(fields);

		}

		private void viewPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
			if (typeOfEntity != null)
			{
				var properties = typeOfEntity.GetProperties();
				_selectedObject = properties;
				gridDataEditor.BindEnumerable(properties);
			}

		}

		private void viewPropertyDescriptorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
			if (typeOfEntity != null)
			{
				var properties = MetaDataHelper.GetPropertyDescriptors(typeOfEntity);
				_selectedObject = properties;
				gridDataEditor.BindEnumerable(properties);
			}

		}

		private void viewAttributesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
			if (typeOfEntity != null)
			{
				var properties = MetaDataHelper.GetPropertyDescriptors(typeOfEntity);
				var attributes = properties.SelectMany(prop => prop.Attributes.Cast<Attribute>());
				_selectedObject = attributes;
				gridDataEditor.BindEnumerable(attributes);
			}

		}

		private void viewInObjectBrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var entityQueryable = GetEntityQueryable();
			if (entityQueryable != null)
			{
				FrmEntityViewer.LaunchAsChildForm(entityQueryable, gridDataEditor.DataEditorPersister);
			}
		}

    private void treeViewEntities_Click(object sender, EventArgs e)
    {
      _userHasInteracted = true;
    }

    private void treeViewEntities_KeyDown(object sender, KeyEventArgs e)
    {
      _userHasInteracted = true;
    }
	}
}