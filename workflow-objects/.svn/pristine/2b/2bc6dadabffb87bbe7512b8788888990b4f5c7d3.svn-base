using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    /// <summary>
    /// All Activities should have the following properties.    
    /// </summary>
    public class WorkflowActivityBase : IWorkflowActivity
    {
        public string ActivityDescription;
        ActivityState currentState;
        #region IWorkflowActivity Members

        public bool isComplete()
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IWorkflowActivity Members

        public ActivityState GetCurrentStatus()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
