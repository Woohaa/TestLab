using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TDD_Lab
{
    public class WriteToFile: IWriteToFile
    {
        public void SaveToFile(string input)
        {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\Test.txt", true))
                {
                    sw.WriteLine(input);
                }
            }
        }
    }

