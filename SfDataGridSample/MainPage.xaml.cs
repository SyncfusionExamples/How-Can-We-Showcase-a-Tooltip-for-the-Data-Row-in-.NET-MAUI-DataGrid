using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataGrid.CellRenderers.Remove("Text");
            dataGrid.CellRenderers.Remove("DateTime");
            dataGrid.CellRenderers.Remove("ComboBox");
            dataGrid.CellRenderers.Add("Text", new CustomTextRenderer());
            dataGrid.CellRenderers.Add("DateTime", new CustomDateRenderer());
            dataGrid.CellRenderers.Add("ComboBox", new CustomComboBoxRenderer());

        }
    }

    public class CustomDateRenderer : DataGridDateCellRenderer
    {
        protected override void OnSetCellStyle(DataColumnBase dataColumn)
        {
            base.OnSetCellStyle(dataColumn);

            if (dataColumn != null)
            {
                var gridStyle = this.DataGrid?.DefaultStyle;
                DataGridCell gridCell = dataColumn.ColumnElement;
                var mappingName = dataColumn.DataGridColumn.MappingName;

                if (mappingName == "HireDate")
                {
                    var label = gridCell.Children[0] as Label;
                    if (label != null)
                    {
                        var toolTipText = label.Text;
                        ToolTipProperties.SetText(label,toolTipText);
                    }
                }

                gridStyle = null;
                mappingName = null;
                gridCell = null;
            }
        }
    }

    public class CustomTextRenderer : DataGridTextBoxCellRenderer
    {
        protected override void OnSetCellStyle(DataColumnBase dataColumn)
        {
            base.OnSetCellStyle(dataColumn);

            if (dataColumn != null)
            {
                var gridStyle = this.DataGrid?.DefaultStyle;
                DataGridCell gridCell = dataColumn.ColumnElement;
                var mappingName = dataColumn.DataGridColumn.MappingName;

                if(mappingName == "Name")
                {
                    var label = gridCell.Children[0] as Label;
                    if (label != null)
                    {
                        var toolTipText = label.Text;
                        ToolTipProperties.SetText(label, toolTipText);
                    }
                }

                gridStyle = null;
                mappingName = null;
                gridCell = null;
            }
        }
    }

    public class CustomComboBoxRenderer : DataGridComboBoxRenderer
    {
        protected override void OnSetCellStyle(DataColumnBase dataColumn)
        {
            base.OnSetCellStyle(dataColumn);

            if (dataColumn != null)
            {
                var gridStyle = this.DataGrid?.DefaultStyle;
                DataGridCell gridCell = dataColumn.ColumnElement;
                var mappingName = dataColumn.DataGridColumn.MappingName;

                if (mappingName == "Name")
                {
                    var label = gridCell.Children[0] as Label;
                    if (label != null)
                    {
                        var toolTipText = label.Text;
                        ToolTipProperties.SetText(label, toolTipText);
                    }
                }

                gridStyle = null;
                mappingName = null;
                gridCell = null;
            }
        }
    }
}
