using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    class WorkflowScriptActivity : WorkflowActivityBase, IWorkflowActivity
    {
        #region IWorkflowActivity Members

        public bool isComplete()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IWorkflowActivity Members

        ActivityState IWorkflowActivity.GetCurrentStatus()
        {
            throw new NotImplementedException();
        }

        bool IWorkflowActivity.isComplete()
        {
            throw new NotImplementedException();
        }

        void IWorkflowActivity.Perform()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
