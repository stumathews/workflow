using System;
using System.Collections.Generic;
using System.Text;
using WorkflowObjects;
using System.Reflection;
using System.IO;
using WorkflowObjects;


namespace WorkflowDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            
           System.Diagnostics.Debug.WriteLine("Loading Workflows...");

           //Workflow workflow1 = new Workflow("workflow1.def");
           //Workflow workflow2 = new Workflow("workflow2.def");
           //Workflow workflow3 = new Workflow("workflow3.def");
           

           System.Diagnostics.Debug.WriteLine("Loading Workflow Applications...");
            // Essentially create a list of virtual applictions:

            List<WorkflowApplication> virtualApps = new List<WorkflowApplication>();

            //WorkflowApplication app1 = new WorkflowApplication("App1", workflow1);            
            //WorkflowApplication app2 = new WorkflowApplication("App2", workflow2);
            //WorkflowApplication app3 = new WorkflowApplication("App3", workflow3);

            // Manages the list of Workflow applications.
            // Also hands off WorkflowApplication to WorkflowApplication Detail screen,
            // which modifies the application's stage in the workflow and instantiates the
            // workflow stage's activities.
            System.Diagnostics.Debug.WriteLine("Loading Workflow Application View...");

            // Dummy normal applications

            NormalApplication app1 = new NormalApplication("normalApp1");
            NormalApplication app2 = new NormalApplication("normalApp2");
            NormalApplication app3 = new NormalApplication("normalApp3");

            List<NormalApplication> normalApplications = new List<NormalApplication>();
            normalApplications.Add(app1);
            normalApplications.Add(app2);
            normalApplications.Add(app3);

            ApplicationListScreen applicationListScreen = new ApplicationListScreen(normalApplications);
            applicationListScreen.Show();


            
        }
    }
}
