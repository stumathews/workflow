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
    public partial class WorkflowApplicationsScreen : Form
    {
        private List<WorkflowApplication> workflowApplications;
        public WorkflowApplicationsScreen()
        {
            InitializeComponent();
            workflowApplicationsListView.MultiSelect = false;
            workflowApplicationsListView.MouseDoubleClick += new MouseEventHandler(workflowApplicationsListView_MouseDoubleClick);
            
        }

        void workflowApplicationsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listView = (sender as ListView);

            ListViewItem item = listView.SelectedItems[0];
            WorkflowApplication workflowApplication = (item.Tag as WorkflowApplication);
            WorkflowApplicationManagmentScreen workflowApplicationManagmentScreen = new WorkflowApplicationManagmentScreen(workflowApplication);
            workflowApplicationManagmentScreen.ShowDialog();
        }

        internal void injectWorkflowObjects(List<WorkflowObjects.WorkflowApplication> workflowApplications)
        {
            // use this as the source of all workflow Applicatinos to load
            this.workflowApplications = workflowApplications;
            // Show the workflow Applications to the user:


            setupHeaders();
            for (int i = 0; i < workflowApplications.Count; i++)
            {
                ListViewItem item = new ListViewItem( new string[] {workflowApplications[i].Name, workflowApplications[i].GetCurrentStage().StageName });
                item.Tag = workflowApplications[i];
                
                workflowApplicationsListView.Items.Add(item);
            }

        }

        private void setupHeaders()
        {
            ColumnHeader AppName = new ColumnHeader();
            AppName.Name = "App Name";
            AppName.Text = "AppName";
            ColumnHeader WorkflowName = new ColumnHeader();
            WorkflowName.Name = "Workflow";
            WorkflowName.Text = "Workflow Name";

            workflowApplicationsListView.Columns.Add(AppName);
            workflowApplicationsListView.Columns.Add(WorkflowName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (workflowApplicationsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = workflowApplicationsListView.SelectedItems[0];
                WorkflowApplication workflowApplication = (selectedItem.Tag as WorkflowApplication);
                MessageBox.Show("You chose to manage this workflow application" + (selectedItem.Tag as WorkflowApplication).Name);
                manageWorkflowApplication(workflowApplication);
                
            }
            else
            {
                MessageBox.Show("You didnt select anything");
            }

        }

        private void manageWorkflowApplication(WorkflowApplication workflowApplication)
        {
            // Here we pass the workflow Application to be managed into the Workflow Managment Screen
            WorkflowApplicationManagmentScreen workflowApplicationManagmentScreen = new WorkflowApplicationManagmentScreen(workflowApplication);
            workflowApplicationManagmentScreen.ShowDialog();
        }

        private void workflowApplicationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
