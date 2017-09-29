using System;
using System.Collections.Generic;

using System.Text;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Serialization;


namespace ApptitudeWorkflowDesigner
{

    internal sealed class WorkflowLoader : WorkflowDesignerLoader
    {
        protected override void PerformLoad(IDesignerSerializationManager serializationManager)
        {
            base.PerformLoad(serializationManager);
            // Implement the logic to read from the serialized state,
            // create the activity tree and the corresponding designer
            // tree and add it to the designer host

            
            
        }

        protected override void PerformFlush(IDesignerSerializationManager manager)
        {
            // Implement the logic to save the activity tree to a
            // serialized state along with any code beside elements 
        }


        public override string FileName
        {
            get { throw new NotImplementedException(); }
        }

        public override System.IO.TextReader GetFileReader(string filePath)
        {
            throw new NotImplementedException();
        }

        public override System.IO.TextWriter GetFileWriter(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
