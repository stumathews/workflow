using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    /// <summary>
    /// Manages WorkflowApplication interactions.
    /// Basically picks out workflow applications and perform generic functions/actions on them
    /// It will also allow you to serialise the WorkflowApplicatio being controlled
    /// </summary>
    public class WorkflowApplicationController
    {
        public WorkflowApplication workflowApplication;
        
        
        public WorkflowApplicationController(WorkflowApplication workflowApplication)
        {
            this.workflowApplication = workflowApplication;
            
        }
        public void MoveToNextStage()
        {
            workflowApplication.MoveToNextStage();
        }
        public void MoveToPreviousStage()
        {
            workflowApplication.MoveToPreviousStage();
        }
        
        /// <summary>
        /// executes activity
        /// </summary>
        /// <param name="workflowActivity"></param>
        public void PerformActivity( WorkflowActivityBase workflowActivity )
        {
            workflowActivity.Perform();
        }
        // Take the modified WorkflowApplication and save it into the database
        // as a database entity.
        public void SerialiseWorkflowApplication()
        {
        
        }
    }
}
