using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Reflection;

namespace WorkflowObjects
{
    public enum WorkflowPart { Element, Attribute, Content };
    
    /// <summary>
    /// Workflow loader is responsible to parsing the workflow definition file.
    /// It makes all constituents of the defintion file accessible from within this object.
    /// </summary>
    public class WorkflowLoader
    {
        private string workflowDefinition;
        Workflow workflow;
        public WorkflowLoader(string WorkflowDefinitionFile)
        {
            workflowDefinition = WorkflowDefinitionFile;
            // This should break the text representation of the workflow and
            // construct a WorkflowObject to represent it.
            //parse();
        }

        /// <summary>
        /// Parses the workflow definition file and populates the Workflow Object.
        /// </summary>
        private void parse()
        {
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.IgnoreWhitespace = true;
            xmlReaderSettings.IgnoreComments = true;
            xmlReaderSettings.ConformanceLevel = ConformanceLevel.Fragment;

            //test
            Assembly asm = Assembly.GetExecutingAssembly();
            XmlReader xmlReader = XmlReader.Create(asm.GetManifestResourceStream("WorkflowObjects.WorkflowDef.xml"));
            
            // BUilt up map of the workflow definition file:
            
            List<List<KeyValuePair<WorkflowPart, KeyValuePair<string, string>>>> topList = new List<List<KeyValuePair<WorkflowPart, KeyValuePair<string, string>>>>();
            while (xmlReader.Read())
            {
                List<KeyValuePair<WorkflowPart, KeyValuePair<string, string>>> aa = new List<KeyValuePair<WorkflowPart, KeyValuePair<string, string>>>();
                if (xmlReader.IsStartElement())
                {   
                    aa.Add( new KeyValuePair<WorkflowPart,KeyValuePair<string,string>>(WorkflowPart.Element,new KeyValuePair<string,string>("name",xmlReader.Name)));
                    topList.Add(aa);
                    Console.WriteLine(xmlReader.Name + " start");
                    if (xmlReader.HasAttributes)
                    {
                       
                        for (int i = 0; i < xmlReader.AttributeCount; i++)
                        {
                            xmlReader.MoveToAttribute(i);
                           
                            Console.WriteLine("\t"+xmlReader.Name+"="+xmlReader.GetAttribute(i));
                            topList[topList.Count-1].Add(new KeyValuePair<WorkflowPart, KeyValuePair<string, string>>(WorkflowPart.Attribute, new KeyValuePair<string, string>(xmlReader.Name, xmlReader.GetAttribute(i))));
                            //aa.Add(new KeyValuePair<WorkflowPart, KeyValuePair<string, string>>(WorkflowPart.Attribute, new KeyValuePair<string, string>(xmlReader.Name, xmlReader.GetAttribute(i))));
                        }
                        
                    }
                }
                else
                {                    
                    if (xmlReader.HasValue)
                    {
                        Console.WriteLine("\t\t" + xmlReader.Value);
                        topList[topList.Count-1].Add(new KeyValuePair<WorkflowPart, KeyValuePair<string, string>>(WorkflowPart.Content, new KeyValuePair<string, string>("value", xmlReader.Value)));
                        //aa.Add(new KeyValuePair<WorkflowPart, KeyValuePair<string, string>>(WorkflowPart.Content, new KeyValuePair<string, string>("value", xmlReader.Value)));
                    }
                    else
                    {
                        Console.WriteLine(xmlReader.Name + " end");
                    }

                }
                //aa.Clear();
            }
                System.Console.ReadLine();

                foreach (List<KeyValuePair<WorkflowPart, KeyValuePair<string, string>>> a in topList)
                {
                    KeyValuePair<WorkflowPart, KeyValuePair<string, string>> keyvalue = a[0];

                    string key = keyvalue.Value.Value;
                    if (key == "workflow") 
                    {
                        for (int i = 0; i < a.Count; i++)
                        {
                            WorkflowPart type = a[i].Key;
                            string identifiyer = a[i].Value.Key;
                            string value = a[i].Value.Value;
                        }
                    }
                    if (key == "stage")
                    {
                        
                        for (int i = 0; i < a.Count; i++)
                        {
                            WorkflowPart type = a[i].Key;
                            string identifiyer = a[i].Value.Key;
                            string value = a[i].Value.Value;
                        }
                        
                    }
                    if (key == "activity")
                    {
                        for (int i = 0; i < a.Count; i++)
                        {
                            WorkflowPart type = a[i].Key;
                            string identifiyer = a[i].Value.Key;
                            string value = a[i].Value.Value;
                        }
                    }
                }
                // And then we create.populate the workflow object
                workflow = new Workflow();
            }
     }
}
