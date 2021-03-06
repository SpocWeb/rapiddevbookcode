Code for Rapid C# Windows Development eBook + LINQPad and Data Tools

The worked example in [Joseph Chancellor](http://www.lulu.com/josephchancellor)’s book [Rapid C# Windows Development](http://www.lulu.com/product/paperback/rapid-c%23-windows-development-visual-studio-2005-sql-server-2005-and-llblgen-pro/408111) which uses [LLBLGen Pro](http://www.llblgen.com) to connect to the [Adventure Works sample database](http://msftdbprodsamples.codeplex.com/).  
It also contains this [Enumerable Debugger Visualizer for Visual Studio](../../wiki/EnumerableDebugVisualizer), an [**LLBLGen Entity Browser**](../../wiki/LLBLGen%20Entity%20Browser) and some [LINQPad Extensions and Tools](../../wiki/LINQPad) and a few [Winform Controls](../../wiki/Controls).

The [book](http://www.lulu.com/product/paperback/rapid-c%23-windows-development-visual-studio-2005-sql-server-2005-and-llblgen-pro/408111), published in February 2006 about 'Quickly Build Robust, Database-Driven Applications', along with the code is a great introduction into performing common tasks in Database-Driven Applications, however it was written with version 1.X of [LLBLGen Pro](http://www.llblgen.com) so I have updated it to work with the later versions (2.6, 3.x and 4.x). At the same time I wanted to use this code as a starting point for evaluating LINQ To LLBLGen so I have converted all of the queries to use LINQ (but kept the originals for comparison).  

**[Book source code details](../../wiki/BookSourceCode)**

### Additional controls and tools contained in this project

*   [**Enumerable Debugger Visualizer for Visual Studio**](../../wiki/EnumerableDebugVisualizer) that displays any registered (currently 575 mainly BCL) IEnumerable object such as a lists, collections, dictionaries and Linq enumerables in a [GridDataEditor](../../wiki/GridDataEditor).
*   [**LLBLGen Entity Browser**](../../wiki/LLBLGen%20Entity%20Browser) is an application that lets you browse, view and edit the data in a database via the mapped [LLBLGen Pro](http://www.llblgen.com/) entities.
*   [**Object as Source Code Debugger Visualizer**](../../wiki/ObjectAsSourceCodeDebuggerVisualizer) is a Debugger Visualizer that displays C# source code the will generate the .Net object chosen in the debugger.
*   [List IIS Apps](../../wiki/ListIISApps) is a web app which provides a clickable list of all the web applications on an IIS instance along with metadata such as connection strings and app settings (Think web-based read only IIS Manger).
*   [LINQPad Extensions and Tools](../../wiki/LINQPad)
    *   **[LLBLGen Pro Driver](../../wiki/LLBL4linqpad)** to show [LLBLGen Pro](http://www.llblgen.com) generated entities in the Schema Explorer.
    *   [Custom Visualizers](../../wiki/LINQPadCustomVisualizer) that expose some of the [Winform Controls](../../wiki/Controls) below to be displayed in the [LINQPad](http://www.linqpad.net) output panel.
*   [Winform Controls](../../wiki/Controls)
    *   **[DataTreeView](https://github.com/JeremyThomas/rapiddevbookcode/blob/LLBL_Pro_v4.2/AW.Winforms.Helpers/Controls/DataTreeView.cs)**. An enhanced version of this [Databound TreeView control](http://www.codeproject.com/KB/tree/bindablehierarchicaltree.aspx) for displaying [Adjacency List](http://articles.sitepoint.com/article/hierarchical-data-database) (self referencing) data.
    *   [HierarchyEditor](../../wiki/LINQPadHierarchyEditor), based on the DataTreeView, for displaying and editing [Adjacency List](http://articles.sitepoint.com/article/hierarchical-data-database) (self referencing) data. ([Available in LINQPad](../../wiki/LINQPadCustomVisualizer) )
    *   [GridDataEditor](../../wiki/GridDataEditor). Essentially a paged [DataGridView](http://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.aspx), implemented as a [UserControl](http://msdn.microsoft.com/en-us/library/system.windows.forms.usercontrol.aspx) containing an [ADGV.AdvancedDataGridView](https://adgv.codeplex.com/) and two [BindingNavigator](http://msdn.microsoft.com/en-us/library/b9y7cz6d.aspx)’s, one for the data and one for the pages. ([Available in LINQPad](../../wiki/LINQPadCustomVisualizer) )
    *   [Entity Browser](../../wiki/EntityDataBrowser) to browse and edit [LLBLGen Pro](http://www.llblgen.com) entities from a database. ([Available in LINQPad](../../wiki/LINQPadCustomVisualizer) )
    *   [Object Inspector](../../wiki/ObjectInspector) for browsing the properties of an object and any objects it references. ([Available in LINQPad](../../wiki/LINQPadCustomVisualizer) )
    *   **[QueryRunner](https://github.com/JeremyThomas/rapiddevbookcode/blob/LLBL_Pro_v4.2/AW.Winforms.Helpers/QueryRunner/QueryRunner.cs)**. A query runner user control (poor man's version of [LINQPad](http://www.linqpad.net)).

[Background](../../wiki/Notes)  
[Acknowledgements, credits and attributions](../../wiki/Attributions)

### Links

[http://www.lulu.com/josephchancellor](http://www.lulu.com/josephchancellor)  
[http://josephchancellor.wordpress.com](http://josephchancellor.wordpress.com)  
[http://www.llblgen.com](http://www.llblgen.com)  
[http://www.linqpad.net](http://www.linqpad.net)  

Thanks to [Joseph Chancellor](http://www.lulu.com/josephchancellor) for writing the book and making the code available for this project
