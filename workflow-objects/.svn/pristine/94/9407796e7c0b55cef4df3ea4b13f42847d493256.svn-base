using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowObjects
{
    /// <summary>
    /// A virtual Application, which may or may not be in the asm_application table.
    /// </summary>
    public class WorkflowApplication
    {
        /// <summary>
        /// Name of the applications
        /// </summary>
        public string Name;
        /// <summary>
        /// The workflow that the applications is bound to
        /// </summary>
        public Workflow Workflow;
        /// <summary>
        /// The current stage of the application in the workflow
        /// </summary>
        WorkflowStage CurrentStage;
        /// <summary>
        /// The History/Audit log of the appliction
        /// </summary>
        List<string> History = new List<string>();
        /// <summary>
        /// Specifes the link to the ASM_Application table if its has been associated with
        /// and existing app_id in asm_appliction table.
        /// </summary>
        public ASMApplicationLink ASMLink;
        public List<WorkflowStage> Stages = new List<WorkflowStage>();

        /// <summary>
        /// Specific, persistant information about what has occured in the Workflow of this WorkflowApplication
        /// </summary>
        public WorkflowHistory WorkflowHistoryObject;

        public WorkflowApplication(string name, Workflow workflow)
        {
            this.Workflow = workflow;
            this.Name = name;
            if (Workflow.Stages.Count > 0)
                CurrentStage = Workflow.Stages[0]; // we assume that the first stage is default
            else
                CurrentStage = new WorkflowStage("Start");

            // should add all the stages to the Stages variable...
            Stages.Add(CurrentStage);
        }


        internal void MoveToNextStage()
        {
            History.Add(DateTime.Now + " moved to next stage");
        }


        public WorkflowStage GetCurrentStage()
        {
            return CurrentStage;
        }




        public void MoveToPreviousStage()
        {
            throw new NotImplementedException();
        }


    }
    public class ASMApplicationLink
    {
        public ASMApplicationLink() { }
        public int? app_id = null;
    }
}
