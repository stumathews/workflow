using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Workflow.ComponentModel.Design;
using System.Design;
using System.ComponentModel.Design;

namespace ApptitudeWorkflowDesigner
{
    public partial class WorkflowDesigner : Form
    {
        ScintillaNet.Scintilla codeEditor = new ScintillaNet.Scintilla();

        public WorkflowDesigner()
        {
            // Show the Splash screen.
            //SplashScreen.frmSplash splash = new SplashScreen.frmSplash();
            //splash.ShowDialog();
            InitializeComponent();
            codeEditor.Dock = DockStyle.Fill;
            codeEditor.ConfigurationManager.Language = "xml";
            
            sourceView.Controls.Add(codeEditor);

        }

        private void WorkflowDesigner_Load(object sender, EventArgs e)
        {

        }

        private void sourceView_Enter(object sender, EventArgs e)
        {
            //load the XML
            codeEditor.Text = workflowDesignerControl1.getXoml();
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xoml files (*.xoml)|*.xoml|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            sfd.ShowDialog();
            if (sfd.FileName.Length > 0)
            {
                workflowDesignerControl1.Save(sfd.FileName);
               

            }

            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "xoml files (*.xoml)|*.xoml|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            ofd.ShowDialog();
            if (ofd.FileName.Length > 0)
            {
                workflowDesignerControl1.LoadWorkflow(ofd.FileName);
            }
              
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
