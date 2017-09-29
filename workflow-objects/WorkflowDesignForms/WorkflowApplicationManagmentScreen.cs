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
    public partial class WorkflowApplicationManagmentScreen : Form
    {
        private WorkflowApplicationController workflowAppController;
        public WorkflowApplicationManagmentScreen( WorkflowApplication workflowApplication)
        {
            InitializeComponent();

            log("Workflow details for "+workflowApplication.Name+" :");
            log("Workflow Name: "+ workflowApplication.Workflow.Name);
            log("Workflow Start Stage:"+ workflowApplication.GetCurrentStage().StageName);
            
            // add it to the controller which will perform actions against the workflow Applications
            // it will also allow you to serialise the WorkflowApplicatio being controlled
            workflowAppController = new WorkflowApplicationController(workflowApplication);
            
            // add the stages to the form

            for (int i = 0; i < workflowApplication.Stages.Count; i++)
            {
                workflowStageList.Items.Add(workflowApplication.Stages[i].StageName);
            }

        }

        private void log(string p)
        {
            output.Items.Add(p);
        }

        private void SerializeWorkflowApplicationButton_Click(object sender, EventArgs e)
        {
            // Here we would save to the database via calls through the WSL
        }
    }
}
