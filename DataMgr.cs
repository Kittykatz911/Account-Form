using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CS314App_ahenry
{
    public class DataMgr
    {
        //used to store the file name
        private string fileDir = "../../Data/";
        private string filePath = "";

        public DataMgr(string fileName)
        {
            //create the 'Data' folder to store the json files
            //if it doesn't exist
            Directory.CreateDirectory(fileDir);

            //store the name of the json file 
            filePath = fileDir + fileName + ".json";
        }
        

        public void writeToJson<T>(List<T> dataList)
        {            
            try
            {
                //write the string to the file
                File.WriteAllText(filePath, JsonConvert.SerializeObject(dataList));
            }
            catch (Exception ex)
            {
                //Console.Out.WriteLine(ex.StackTrace + " - " + ex.Message);
                //MessageBox.Show(ex.Message);
            }
        }


        public List<T> readFromJson<T>()
        {
            try
            {
                //read the string from the file
                if (File.Exists(filePath))
                {
                    string jsonDataString = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<T>>(jsonDataString);
                }
            }
            catch (Exception ex)
            {
                //Console.Out.WriteLine(ex.StackTrace + " - " + ex.Message);
                //MessageBox.Show(ex.Message);
            }

            return new List<T>();  //nothing found return empty list
        }
    }
}

