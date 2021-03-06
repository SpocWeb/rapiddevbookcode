﻿using AW.Winforms.Helpers.DataEditor;

namespace AW.Winforms.Helpers.Controls
{
	partial class HierarchyEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HierarchyEditor));
      this.bindingSourceHierarchicalData = new System.Windows.Forms.BindingSource(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelSelectePath = new System.Windows.Forms.ToolStripStatusLabel();
      this.bindingNavigatorHierarchicalData = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonCollapseAll = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonExpandAll = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonUnSelectNodes = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonCancelEdit = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dataTreeView = new Chaliy.Windows.Forms.DataTreeView();
      this.splitContainerHorizontal = new System.Windows.Forms.SplitContainer();
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHierarchicalData)).BeginInit();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHierarchicalData)).BeginInit();
      this.bindingNavigatorHierarchicalData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataTreeView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).BeginInit();
      this.splitContainerHorizontal.Panel1.SuspendLayout();
      this.splitContainerHorizontal.Panel2.SuspendLayout();
      this.splitContainerHorizontal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridDataEditor)).BeginInit();
      this.SuspendLayout();
      // 
      // bindingSourceHierarchicalData
      // 
      this.bindingSourceHierarchicalData.AllowNew = true;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSelectePath});
      this.statusStrip1.Location = new System.Drawing.Point(0, 584);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(895, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabelSelectePath
      // 
      this.toolStripStatusLabelSelectePath.Name = "toolStripStatusLabelSelectePath";
      this.toolStripStatusLabelSelectePath.Size = new System.Drawing.Size(173, 17);
      this.toolStripStatusLabelSelectePath.Text = "toolStripStatusLabelSelectePath";
      // 
      // bindingNavigatorHierarchicalData
      // 
      this.bindingNavigatorHierarchicalData.AddNewItem = null;
      this.bindingNavigatorHierarchicalData.BindingSource = this.bindingSourceHierarchicalData;
      this.bindingNavigatorHierarchicalData.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigatorHierarchicalData.DeleteItem = null;
      this.bindingNavigatorHierarchicalData.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.bindingNavigatorHierarchicalData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonCollapseAll,
            this.toolStripButtonExpandAll,
            this.toolStripButtonUnSelectNodes,
            this.toolStripSeparator,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonCancelEdit,
            this.toolStripSeparator1,
            this.saveToolStripButton});
      this.bindingNavigatorHierarchicalData.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
      this.bindingNavigatorHierarchicalData.Location = new System.Drawing.Point(0, 561);
      this.bindingNavigatorHierarchicalData.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigatorHierarchicalData.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigatorHierarchicalData.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigatorHierarchicalData.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigatorHierarchicalData.Name = "bindingNavigatorHierarchicalData";
      this.bindingNavigatorHierarchicalData.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigatorHierarchicalData.Size = new System.Drawing.Size(895, 23);
      this.bindingNavigatorHierarchicalData.TabIndex = 4;
      this.bindingNavigatorHierarchicalData.Text = "bindingNavigator1";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
      // 
      // toolStripButtonCollapseAll
      // 
      this.toolStripButtonCollapseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonCollapseAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.toolStripButtonCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCollapseAll.Image")));
      this.toolStripButtonCollapseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCollapseAll.Name = "toolStripButtonCollapseAll";
      this.toolStripButtonCollapseAll.Size = new System.Drawing.Size(23, 19);
      this.toolStripButtonCollapseAll.Text = "-";
      this.toolStripButtonCollapseAll.ToolTipText = "Collapse All";
      this.toolStripButtonCollapseAll.Click += new System.EventHandler(this.toolStripButtonCollapseAll_Click);
      // 
      // toolStripButtonExpandAll
      // 
      this.toolStripButtonExpandAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonExpandAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.toolStripButtonExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExpandAll.Image")));
      this.toolStripButtonExpandAll.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonExpandAll.Name = "toolStripButtonExpandAll";
      this.toolStripButtonExpandAll.Size = new System.Drawing.Size(23, 19);
      this.toolStripButtonExpandAll.Text = "+";
      this.toolStripButtonExpandAll.ToolTipText = "Expand All";
      this.toolStripButtonExpandAll.Click += new System.EventHandler(this.toolStripButtonExpandAll_Click);
      // 
      // toolStripButtonUnSelectNodes
      // 
      this.toolStripButtonUnSelectNodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonUnSelectNodes.Image = global::AW.Winforms.Helpers.Properties.Resources.layer__minus;
      this.toolStripButtonUnSelectNodes.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonUnSelectNodes.Name = "toolStripButtonUnSelectNodes";
      this.toolStripButtonUnSelectNodes.Size = new System.Drawing.Size(23, 20);
      this.toolStripButtonUnSelectNodes.Text = "UnSelectNodes";
      this.toolStripButtonUnSelectNodes.Click += new System.EventHandler(this.toolStripButtonUnSelectNodes_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(6, 23);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Enabled = false;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
      // 
      // toolStripButtonCancelEdit
      // 
      this.toolStripButtonCancelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonCancelEdit.Enabled = false;
      this.toolStripButtonCancelEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelEdit.Image")));
      this.toolStripButtonCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCancelEdit.Name = "toolStripButtonCancelEdit";
      this.toolStripButtonCancelEdit.Size = new System.Drawing.Size(23, 20);
      this.toolStripButtonCancelEdit.Text = "Cancel";
      this.toolStripButtonCancelEdit.Click += new System.EventHandler(this.toolStripButtonCancelEdit_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Enabled = false;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 20);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dataTreeView);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainerHorizontal);
      this.splitContainer1.Size = new System.Drawing.Size(895, 561);
      this.splitContainer1.SplitterDistance = 298;
      this.splitContainer1.TabIndex = 5;
      // 
      // dataTreeView
      // 
      this.dataTreeView.AllowDrop = true;
      this.dataTreeView.ChildCollectionPropertyName = null;
      this.dataTreeView.DataMember = "";
      this.dataTreeView.DataSource = this.bindingSourceHierarchicalData;
      this.dataTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataTreeView.FullRowSelect = true;
      this.dataTreeView.HideSelection = false;
      this.dataTreeView.HotTracking = true;
      this.dataTreeView.IgnoreErrors = true;
      this.dataTreeView.LabelEdit = true;
      this.dataTreeView.Location = new System.Drawing.Point(0, 0);
      this.dataTreeView.Name = "dataTreeView";
      this.dataTreeView.ShowNodeToolTips = true;
      this.dataTreeView.Size = new System.Drawing.Size(298, 561);
      this.dataTreeView.TabIndex = 3;
      this.dataTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.dataTreeView_AfterExpand);
      this.dataTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.dataTreeView_AfterExpand);
      this.dataTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dataTreeView1_AfterSelect);
      // 
      // splitContainerHorizontal
      // 
      this.splitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
      this.splitContainerHorizontal.Name = "splitContainerHorizontal";
      this.splitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerHorizontal.Panel1
      // 
      this.splitContainerHorizontal.Panel1.Controls.Add(this.propertyGrid1);
      // 
      // splitContainerHorizontal.Panel2
      // 
      this.splitContainerHorizontal.Panel2.Controls.Add(this.gridDataEditor);
      this.splitContainerHorizontal.Size = new System.Drawing.Size(593, 561);
      this.splitContainerHorizontal.SplitterDistance = 300;
      this.splitContainerHorizontal.TabIndex = 0;
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(593, 300);
      this.propertyGrid1.TabIndex = 0;
      // 
      // gridDataEditor
      // 
      this.gridDataEditor.DataMember = "";
      this.gridDataEditor.DataSource = null;
      this.gridDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDataEditor.EnsureFilteringEnabled = false;
      this.gridDataEditor.Location = new System.Drawing.Point(0, 0);
      this.gridDataEditor.MembersToExclude = null;
      this.gridDataEditor.Name = "gridDataEditor";
      this.gridDataEditor.PageSize = ((ushort)(0));
      this.gridDataEditor.Readonly = false;
      this.gridDataEditor.Size = new System.Drawing.Size(593, 257);
      this.gridDataEditor.TabIndex = 0;
      // 
      // HierarchyEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.bindingNavigatorHierarchicalData);
      this.Controls.Add(this.statusStrip1);
      this.Name = "HierarchyEditor";
      this.Size = new System.Drawing.Size(895, 606);
      this.Load += new System.EventHandler(this.HierarchyEditor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHierarchicalData)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHierarchicalData)).EndInit();
      this.bindingNavigatorHierarchicalData.ResumeLayout(false);
      this.bindingNavigatorHierarchicalData.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataTreeView)).EndInit();
      this.splitContainerHorizontal.Panel1.ResumeLayout(false);
      this.splitContainerHorizontal.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).EndInit();
      this.splitContainerHorizontal.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridDataEditor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectePath;
		private System.Windows.Forms.BindingSource bindingSourceHierarchicalData;
		private Chaliy.Windows.Forms.DataTreeView dataTreeView;
		private System.Windows.Forms.BindingNavigator bindingNavigatorHierarchicalData;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonCollapseAll;
		private System.Windows.Forms.ToolStripButton toolStripButtonExpandAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		public System.Windows.Forms.ToolStripButton toolStripButtonCancelEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainerHorizontal;
		private GridDataEditor gridDataEditor;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.ToolStripButton toolStripButtonUnSelectNodes;
  }
}