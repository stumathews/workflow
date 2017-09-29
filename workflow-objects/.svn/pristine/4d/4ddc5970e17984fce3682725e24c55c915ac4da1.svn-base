using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkflowObjects;

namespace WorkflowDesignForms
{
    public partial class MainForm : Form
    {
        private ApplicationListScreen applicationListScreen;
        private WorkflowApplicationsScreen workflowApplicationScreen;
        public MainForm()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Loading Workflows...");

            // Usually load workflows from db as XOML files and use to contruct
            // Workflow type objects to represeent them
            Workflow workflow1 = new Workflow("workflow1.def");
            Workflow workflow2 = new Workflow("workflow2.def");
            Workflow workflow3 = new Workflow("workflow3.def");


            System.Diagnostics.Debug.WriteLine("Loading Workflow Applications...");
            System.Diagnostics.Debug.WriteLine("Loading Workflow Application View...");

            // Dummy normal applications
            // This would normally be the applications is asm_applications table

            NormalApplication app1 = new NormalApplication("normalApp1");
            NormalApplication app2 = new NormalApplication("normalApp2");
            NormalApplication app3 = new NormalApplication("normalApp3");


            // Collect them and group them into a list object
            List<NormalApplication> normalApplications = new List<NormalApplication>();
            normalApplications.Add(app1);
            normalApplications.Add(app2);
            normalApplications.Add(app3);

            // collect the workflows and group them into a list
            List<Workflow> workflows = new List<Workflow>();
            workflows.Add(workflow1);
            workflows.Add(workflow2);
            workflows.Add(workflow3);


            // Send to Application List Screen:
            // Lists applications that can be added to a workflow.
            applicationListScreen = new ApplicationListScreen(normalApplications, workflows);
            
        }

        private void showAppScreenButton_Click(object sender, EventArgs e)
        {
            applicationListScreen.ShowDialog();           
            
            //load all WorkflowApplications from db but we cheat and load an
            // alrady deserialized list of WorkflowApplications ...
            List<WorkflowApplication> workflowApplications = applicationListScreen.GetNewWorkflowApps();

            // Show up the workflowApplicationsScreen
            workflowApplicationScreen = new WorkflowApplicationsScreen();
            workflowApplicationScreen.injectWorkflowObjects(workflowApplications);
            workflowApplicationScreen.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Launch the Workflow Designer View
            WorkflowDesignerView workflowDesignerView = new WorkflowDesignerView();
            workflowDesignerView.Show();
        }
    }
}
