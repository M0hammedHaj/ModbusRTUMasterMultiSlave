using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusRTUMasterMultiSlave
{
    public class clsGlobal
    {
        public static List<List<string>> ReadDataFromFile(string path,string separator)
        {
            List<List<string>> strings = new List<List<string>>();
            StreamReader streamReader = new StreamReader(path);

            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] result = line.Split(new string[] { separator },
                    StringSplitOptions.RemoveEmptyEntries);

                List<string> LineAsList = new List<string>();
                foreach (string s in result)
                {
                    LineAsList.Add(s);
                }

                strings.Add(LineAsList);
            }

            streamReader.Close();
            return strings;
        }
    }
}
