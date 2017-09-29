using System;
using System.Collections.Generic;
using System.Text;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.IO;
using System.Xml;
using System.ComponentModel.Design;

namespace WorkflowDesignForms
{
    // Nice class that we can use to wrap the loading/saving the xoml file.
    // this class will also be called from the DesignSurface's beingLoad function and it will
    // require us to deconstruct the xoml file into Activity objects and add them to the designerHost
    class CustomWorkflowDesignerLoader : WorkflowDesignerLoader
    {
        IDesignerHost designerHost;
        string filename;
       
        public CustomWorkflowDesignerLoader(string filename)
        {
            this.filename = filename;
        }
       

        // Called by the The Designerhost and hopes that you'll add the components to the designerhost it proves when it calls this

        public override void BeginLoad(System.ComponentModel.Design.Serialization.IDesignerLoaderHost host)
        {
            this.designerHost = host;

            if (filename.Length > 0)
            {
                Activity rootActivity = LoadWorkflowFormFile(filename);
                if (rootActivity != null)
                {
                    AddActivityToDesigner(rootActivity);
                    
                }

            }

            base.BeginLoad(host);
        }        
        // Get the root Activity from a Xoml file and return it
        private static Activity LoadWorkflowFormFile(string filename)
        {
            if (filename != null && filename.Length > 0)
            {
                ActivityMarkupSerializer serializer = new ActivityMarkupSerializer();
                Activity activity = null;
                FileStream stream = File.Open(filename, FileMode.Open);

                using (XmlReader reader = XmlReader.Create(stream))
                {
                    activity = serializer.Deserialize(reader) as Activity;
                }
                stream.Close();
                return activity;
            }
            else
            {
                return null;
            }
        }
        // Add the activity and its sub activities to designerHost
        private void AddActivityToDesigner(Activity rootActivity)
        {
            
            designerHost.Container.Add(rootActivity);

            CompositeActivity compositeActivity = rootActivity as CompositeActivity;
            if (compositeActivity != null)
            {
                foreach (Activity childActivity in compositeActivity.Activities)
                {
                    AddActivityToDesigner(childActivity);
                }
            }

        }

        // get the current filename of the xoml file
        public override string FileName
        {
            get { return filename; }
        }

        public override TextReader GetFileReader(string filePath)
        {
            return null;
        }

        public override TextWriter GetFileWriter(string filePath)
        {
            return null;
        }
        protected override void PerformFlush(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager)
        {
            IDesignerHost host = designerHost;
            Activity rootActivity = host.RootComponent as Activity;
            WorkflowMarkupSerializer serialiser = new WorkflowMarkupSerializer();
            using (XmlWriter xmlWriter = XmlWriter.Create(filename))
            {
                serialiser.Serialize(serializationManager, xmlWriter, rootActivity);
                
            }
            
        }
    }
}
