using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Workflow.Activities;
using System.Drawing.Design;

namespace WorkflowDesignForms
{
    // a UI textBox view that we use the ToolBoxService class to get the type/object of the selected item 
    // so that when we start dragging it, it will be recongnised by the DesginSurface/DesignerHost
    public class ToolboxView : ListView
    {
        private IServiceProvider serviceProvider;
        private IToolboxService toolboxService;

        // Populate the toolbox
        public ToolboxView( IToolboxService toolbox)
        {
            this.toolboxService = toolbox;
            ListViewItem test = new ListViewItem("CodeActivity");
            
            this.View = View.SmallIcon;
            // notice how we also have to add the item to the toolboxService as well as the physical toolbox
            ToolboxItem item = new ToolboxItem(typeof(CodeActivity));
            toolboxService.AddToolboxItem(item,"Workflow");          
            
            Items.Add(test);
            

        }

        // Use the TextBoxService to get the drag object when we drag from the toolbox
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                if (SelectedItems.Count > 0 && SelectedItems.Count ==1)
                {
                    ToolboxItem item = System.Drawing.Design.ToolboxService.GetToolboxItem(typeof(CodeActivity));
                    DoDragDrop(toolboxService.SerializeToolboxItem(item), DragDropEffects.Move | DragDropEffects.Copy);
                }
            }
        }
      
    }
}
