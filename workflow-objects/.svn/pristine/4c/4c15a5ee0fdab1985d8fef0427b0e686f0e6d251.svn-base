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
    public partial class ApplicationListScreen : Form
    {
        public ApplicationListScreen()
        {
            InitializeComponent();
        }
        private List<WorkflowApplication> virtualAppsCreated = new List<WorkflowApplication>();
        public List<WorkflowApplication> GetNewWorkflowApps()
        {
            return virtualAppsCreated;
        }
        public ApplicationListScreen(List<NormalApplication> normalApplications, List<Workflow> workflows)
        {
            InitializeComponent();
            
            // Populate the form with applications from apptitude

            foreach( NormalApplication app in normalApplications ){

                // add list of normal appliations to the screen
                ApptitudeApplicationList.Items.Add(app.Name);                
            }

            //populate workflows from apptitude

            foreach (Workflow workflow in workflows)
            {
                workflowList.Items.Add(workflow.Name);
            }
            // default to select fist workflow
            LayoutAfterLogic();
        }

        /// <summary>
        /// Checks to see if workflows list is populated, if so selects the first item
        /// </summary>
        private void LayoutAfterLogic()
        {
            if (workflowList.Items.Count > 0)
            {
                workflowList.SelectedItem = workflowList.Items[0];
            }
            else
            {
                MessageBox.Show("Couldn't load workflows");
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add the NormalApplication and Workfow together as a WorkflowApplication object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addWorkflowButton_Click(object sender, EventArgs e)
        {
            // construct virtual applicatinos
            List< NormalApplication > normalApplications = new List<NormalApplication>();
            
            for( int i = 0; i < ApptitudeApplicationList.CheckedItems.Count;i++){
                string name = ApptitudeApplicationList.CheckedItems[i].ToString();  
               
                    
                    normalApplications.Add( new NormalApplication( name));
                
            }

            Workflow workflow = new Workflow();
            if (workflowList.SelectedItem != null)
            {
                workflow =  new Workflow(workflowList.SelectedItem.ToString());
            }else{
                workflow.Name = "failed to get selected workflow";
            }

            //if custom workflow add field it edited use it only
            if (customAppEditbox.Text.Length > 0)
            {
                NormalApplication nApp = new NormalApplication(customAppEditbox.Text);
                List<NormalApplication> nList = new List<NormalApplication>();
                nList.Add(nApp);
                CreateVirtualApplication(nList, workflow);
            }
            else
            {
                CreateVirtualApplication(normalApplications, workflow);
            }
        }

        private void CreateVirtualApplication(List<NormalApplication> applications, Workflow workflow)
        {
            // Create virtualApplications from this list.
            List<WorkflowApplication> virtualApplications = new List<WorkflowApplication>();
            string virtualApplicationsString = "";
            foreach (NormalApplication app in applications)
            {
                virtualApplications.Add( new WorkflowApplication(app.Name, workflow));
                virtualApplicationsString += app.Name + "(" + workflow.Name + ")"; 

            }

            // We should now write these to the database and let WorkflowApplicationScreen deserialise them

            MessageBox.Show(virtualApplicationsString);
            this.virtualAppsCreated = virtualApplications;
            Close();
        }
    }
}
