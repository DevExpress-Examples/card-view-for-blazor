# How to implement a responsive CardView component in Blazor 

This example demonstrates how to use DevExpress Blazor components to implement the CardView component's functionality. The main idea of the solution is to combine the following components and imitate CardView:
- [DxGridLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridLayout " DxGridLayout") to arrange data items as cards.
- [DxFormLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout "DxFormLayout") to specify card content.
- [DxPager](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager "DxPager") to implement navigation between pages.
- [DxLayoutBreakpoint](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxLayoutBreakpoint "DxLayoutBreakpoint") to make a layout responsive. 

Three break points allow you to determine the current screen size:
 ```html
<DxLayoutBreakpoint MinWidth="0" MaxWidth="576" @bind-IsActive="@isXsScreen" />
<DxLayoutBreakpoint MinWidth="576" MaxWidth="768" @bind-IsActive="@isSmScreen" />
<DxLayoutBreakpoint MinWidth="769" @bind-IsActive="@isLargeScreen" />
```
The number of rows and columns in the DxGridLayout component is defined based on these break points. 

Each item's position (the [DxGridLayoutItem.Row](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridLayoutItem.Row "DxGridLayoutItem.Row") and [DxGridLayoutItem.Column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridLayoutItem.Column "DxGridLayoutItem.Column") propeties) is calculated based on the page size, the active page index and the number of rows and columns in the component. 

The component recalculates these parameters after screen size changes and another break point becomes active. 

 ## Files to look at
 // TODO
 
 
