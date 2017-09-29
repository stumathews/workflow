using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Workflow.Activities;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Serialization;
using System.Xml;
using System.IO;
using System.Drawing.Design;

namespace WorkflowDesignForms
{
    /*
     Workflow Designer View needs to do the following things
     
     1. Define A new stage.
     2. Add Activity to stage
     
     */

    public partial class WorkflowDesignerView : Form
    {
        // We have a Design Surface.
        DesignSurface theDesignSurface = new DesignSurface(); 
        // We will get a IDesignerHost from our DesignSurface
        IDesignerHost designerHostService;
        // Designer of the root component that we will set later
        IRootDesigner rootDesigner;
        // We will connect a propertygrid to the selected item in the DesignerHost
        PropertyGrid propertyGrid = new PropertyGrid();
        // We will get a Selection Service from the designerHost
        ISelectionService selectionService;
        // The DesignSurface will call CustomWorkflowDesignerLoader's beginLoad function when it beingLoads
        CustomWorkflowDesignerLoader loader;
        
        // Default Constructor - nothing interesting here, move along
        public WorkflowDesignerView()
        {
            InitializeComponent();
       
        }

       
        // Get the RootDesigner's component's view and show it (it is essentially the canvas) in split container
        private void addRootWorkflowView(IRootDesigner rootDesigner)
        {
            
            WorkflowView rootView = rootDesigner.GetView(ViewTechnology.Default) as WorkflowView;
            rootView.Dock = DockStyle.Fill;
            splitContainer2.Panel1.Controls.Add(rootView);
        }

        // When a new designer is selected, this event handler is triggered.
        // Set the property grid to the newsly selected activity in the designerhost
        void selectionService_SelectionChanged(object sender, EventArgs e)
        {
            ISelectionService selectionService = sender as ISelectionService;
                       
            Activity selected = selectionService.PrimarySelection as Activity;
            
            propertyGrid.SelectedObject = selected;
        }

        
        
        // Load a workflow
        private void button1_Click(object sender, EventArgs e)
        {
            // Ask the user for a file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.ShowDialog();
            string filename = ofd.FileName;
            if (filename != null && filename.Length > 0)
            {
                if (theDesignSurface.IsLoaded)
                {
                    theDesignSurface.Dispose();
                    theDesignSurface = new DesignSurface();
                }
                loader = new CustomWorkflowDesignerLoader(filename);
                // Let the DesignerLoader deconstruct the xoml file and then add to the designerHost
                theDesignSurface.BeginLoad(loader);
                // Store the IDesignerHost for later
                designerHostService = theDesignSurface.GetService(typeof(IDesignerHost)) as IDesignerHost;
                rootDesigner = designerHostService.GetDesigner(designerHostService.RootComponent) as IRootDesigner;
                // Get the SelectionService form the DesignerHost
                selectionService = theDesignSurface.GetService(typeof(ISelectionService)) as ISelectionService;
                // Make event for when an activity in designerhost changes selection
                selectionService.SelectionChanged += new EventHandler(selectionService_SelectionChanged);
                // Set the default selected activity to tbe the root component which is notmall a SequentialWorkflowActivity
                selectionService.SetSelectedComponents(new object[] { rootDesigner.Component });
                // Get DesignerHost to use our ToolboxService, as it does not exist by default 
                // and we want to use it to concide with out implementation of our UI Toolbox
                CustomToolboxService toolboxService = new CustomToolboxService();
                designerHostService.AddService(typeof(IToolboxService), toolboxService);
                // Show the workflow View on the form
                addRootWorkflowView(rootDesigner);
                // Put the Grid on the form
                //propertyGrid.Dock = DockStyle.Fill;
                //splitContainer4.Panel2.Controls.Add(propertyGrid);
                // put the UI Toolbox on the form
                ToolboxView toolbox = new ToolboxView(toolboxService) ;
                toolbox.Dock = DockStyle.Fill;
                splitContainer4.Panel1.Controls.Add(toolbox);
            }
            
        }


        //easily get a service form the designhost service
        private T GetHostService<T>() where T : class
        {
            T service = designerHostService.GetService(typeof(T)) as T;
            return service;
        }

        // add to the designerHot container
        private void addActivity_Click(object sender, EventArgs e)
        {
            
            
            CompositeActivity compo_activity = rootDesigner.Component as CompositeActivity;
            compo_activity.Activities.Add( designerHostService.CreateComponent(typeof(SequenceActivity)) as SequenceActivity);
            



        }
        // Create a new Sequential Workflow -remove existing
        private void newWorkFlowButton_Click(object sender, EventArgs e)
        {
            theDesignSurface = new DesignSurface(typeof(SequentialWorkflowActivity));
            
            designerHostService = theDesignSurface.GetService(typeof(IDesignerHost)) as IDesignerHost;
            rootDesigner = designerHostService.GetDesigner( designerHostService.RootComponent ) as IRootDesigner;
            addRootWorkflowView(rootDesigner);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            WorkflowDesignerLoader loader = GetHostService<WorkflowDesignerLoader>();
            loader.Flush();
        }

       




        

        
    }
}
