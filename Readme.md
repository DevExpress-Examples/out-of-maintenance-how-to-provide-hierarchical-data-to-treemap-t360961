<!-- default file list -->
*Files to look at*:

* [DataObjects.cs](./CS/HierarchicalDataAdapterSample/DataObjects.cs) (VB: [DataObjects.vb](./VB/HierarchicalDataAdapterSample/DataObjects.vb))
* **[Form1.cs](./CS/HierarchicalDataAdapterSample/Form1.cs) (VB: [Form1.vb](./VB/HierarchicalDataAdapterSample/Form1.vb))**
<!-- default file list end -->
# How to: provide hierarchical data to TreeMap


This example demonstrates how to visualize hierarchical data using TreeMap and color it using Gradient Colorizer.


<h3>Description</h3>

<p>To provide hierarchical data to TreeMap, create a&nbsp;<strong>TreeMapHierarchicalDataAdapter</strong>&nbsp;object and assign it to the&nbsp;<strong>TreeMapControl.DataAdapter</strong>&nbsp;property. Then, specify the adapter's data source object using the&nbsp;<strong>DataSource&nbsp;</strong>property. To configure how hierarchical data should be converted to tree map items, use&nbsp;<strong>TreeMapHierarchicalDataMapping</strong>&nbsp;objects. The LabelDataMember property allows you to specify label data member, the ValueDataMember property -&nbsp;a value data member, the&nbsp;<strong>ChildrenDataMember&nbsp;</strong>property&nbsp;-&nbsp;a data member containing children items and the&nbsp;<strong>Type&nbsp;</strong>property - a type of items on current nesting level.<br><br>Finally, to color each tree map items depending on its value&nbsp;colors, use the&nbsp;<strong>TreeMapGradientColoriezer&nbsp;</strong>class. The&nbsp;<strong>StartColor</strong>&nbsp;property allows you to specify color for an item with the maximum value, and&nbsp;the&nbsp;<strong>EndColor&nbsp;</strong>property&nbsp;allows you to specify color for an item with the&nbsp;minimum&nbsp;value.</p>

<br/>


