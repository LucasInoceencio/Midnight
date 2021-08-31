using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Midnight
{
    public static class Folders
    {
        #region Description problem

        // Link: https://www.testdome.com/questions/c-sharp/folders/35601?visibility=1&skillId=18

        // Level: Hard

        //Implement a function FolderNames, which accepts a string containing an XML file that specifies folder structure and
        //returns all folder names that start with startingLetter.The XML format is given in the example below.

        //For example, for the letter 'u' and XML file:

        //<?xml version = "1.0" encoding= "UTF-8" ?>
        //< folder name = "c" >
        //    < folder name= "program files" >
        //        < folder name= "uninstall information" />
        //    </ folder >
        //    < folder name= "users" />
        //</ folder >

        //the function should return "uninstall information" and "users" (in any order).

        #endregion

        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            var result = new List<string>();
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            var elementList = xmlDocument.GetElementsByTagName("folder");
            foreach(XmlElement element in elementList)
            {
                if (element.HasAttribute("name"))
                    if (element.GetAttribute("name")[0] == startingLetter)
                        result.Add(element.GetAttribute("name"));
            }
            return result.AsEnumerable();
        }
    }
}
