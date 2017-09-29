using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    /// <summary>
    /// Representation of an Application that can be tracked by a workflow
    /// </summary>
    /// <remarks>This does does not need to be an application in the AppTitude database. It</remarks>
    public class NormalApplication
    {
        public string Name;
        public NormalApplication(string name)
        {
            Name = name;
        }
       
    }
}
