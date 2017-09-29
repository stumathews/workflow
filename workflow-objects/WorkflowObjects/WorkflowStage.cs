using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    /// <summary>
    /// Representation of a Workflow Stage
    /// </summary>
    public class WorkflowStage
    {
        /// <summary>
        /// List of activities
        /// </summary>
        public List<IWorkflowActivity> activities = new List<IWorkflowActivity>();
        /// <summary>
        /// Name of the stage
        /// </summary>
        public string StageName;
        /// <summary>
        /// Description of the stage
        /// </summary>
        public string Description;
        public WorkflowStage( string StageName ){
            this.StageName = StageName;
        }
      
    }
}
