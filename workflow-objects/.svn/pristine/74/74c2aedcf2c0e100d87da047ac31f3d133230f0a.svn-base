using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    /// <summary>
    /// Manages Stages and acts like a controller.
    /// </summary>
    public class Workflow
    {
        /// <summary>
        /// Name of this workflow.
        /// </summary>
        public string Name;
        /// <summary>
        /// Summary of what this workflow
        /// </summary>
        public string WorkflowDescription;
        /// <summary>
        /// List of Stages in this workflow
        /// </summary>
        public List<WorkflowStage> Stages = new List<WorkflowStage>();

        private WorkflowLoader loader;
        public Workflow(string workflowDefinition)
        {
            // for now set the workflow to the name of the definition file
            Name = workflowDefinition;
            // This should break down the WorkflowDefinition into its constituents
            loader = new WorkflowLoader(workflowDefinition);
            
            // loader should now contain the manipulatable workflow objects
            
        }
        // Construct an empty workflow and add stages manually.
        public Workflow() { }
     
    }
}
