using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PickerSettings
{
    class Reader
    {
        StreamWriter streamReader = new StreamWriter("Assets / Scripts / GamePlaySettings.txt");

        public void WriteIntoFileByLine(int line)
        {

        }

        private int GetLengthOfFile(TextReader stream)
        {

            int Count = 0;
            try
            {
                using (stream)
                {
                    string line;

                    while ((line = stream.ReadLine()) != null)
                    {
                        Count++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            stream.Close();
            return Count;
        }
    }
}
