using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Design;
using System.Collections;

namespace WorkflowDesignForms
{

    // We create one of these Toolbox services to aid the selection of components on out Real ToolBox UI
    class CustomToolboxService : ToolboxService
    {
        private ToolboxItemContainer selectedContainer;
        private string selectedCategory;
        private ArrayList itemContainers;
        protected override CategoryNameCollection CategoryNames
        {
            get
            {
                return new CategoryNameCollection(
                 new String[] { "Workflow" });
            }
        }

        protected override System.Collections.IList GetItemContainers(string categoryName)
        {
            // we only have one called "Workflow"
            return GetItemContainers();
        }

        protected override System.Collections.IList GetItemContainers()
        {
            if (itemContainers == null)
            {
                itemContainers = new ArrayList();
            }
            return itemContainers;
        }

        protected override void Refresh()
        {
            throw new NotImplementedException();
        }

        protected override string SelectedCategory
        {
            get
            {
                return selectedCategory;
            }
            set
            {
                selectedCategory = value;
            }
            
        }
       
        protected override ToolboxItemContainer SelectedItemContainer
        {
            get
            {
                return selectedContainer;
            }
            set
            {
                selectedContainer = value;
            }
        }
    }
}
