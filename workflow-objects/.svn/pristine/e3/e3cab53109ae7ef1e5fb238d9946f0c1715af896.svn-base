using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    /// <summary>
    /// Workflow applications should all exhibit this behaviour
    /// </summary>
    public interface IWorkflowApplication
    {
        /// <summary>
        /// Tell this application to move to the next stage in its workflow
        /// </summary>
        void MoveToNextStage();
        /// <summary>
        /// Tell this applications to move to the previous stage in its workflow
        /// </summary>
        void MoveToPreviousStage();
        /// <summary>
        /// Tell the application retrieve its current stage
        /// </summary>
        /// <returns></returns>
        WorkflowStage GetCurrentStage();
    }
}
