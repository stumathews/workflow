using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using System.IO;

namespace WriteLineActivity
{    
    public partial class WriteLine : Activity
    {
        private string message;
        public string Message { get; set; }
        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext)
        {
            StreamWriter sw;

            sw = File.AppendText(@"C:\Users\mathst\Documents\output.txt");

            sw.WriteLine(Message + " -> " + DateTime.Now.ToString());
            sw.Close();
            System.Diagnostics.Debug.WriteLine("Activity Running, output" + Message);


            return ActivityExecutionStatus.Closed;
        }
    }
}
