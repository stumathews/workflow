using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    class Common
    {
    }

    /// <summary>
    /// Defines what a WorkflowActivity is doing. Also indicate what needs to be done when reloaded from persistance
    /// </summary>
    /// Dormant is not yet started.
    /// Started is has performed some logic which may need to be reloaded from persistant storage
    /// Running is currently being executed, logic is runnning, if not complete, load state from persistant storage
    /// Complete is currently finsihed activity - state should be stored in persistant storage or reloaed from persistant storage
    public enum ActivityState { Dormant, Started, Running, Completed }
}
