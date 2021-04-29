using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SettingsReader : MonoBehaviour
{

    private string pathToSettingsFile = "Assets / Scripts / GamePlaySettings.txt";

    internal string GetPathToSettinsFile() => pathToSettingsFile;

    internal string TakeSettingByLine(int lineNumber)
    {
        TextReader sr = new StreamReader(pathToSettingsFile);
        int FileLength = GetLengthOfFile(sr);
        string Line = "";
        try
        {
            for(int i=0; i<FileLength; i++)
            {
                Line = sr.ReadLine();
                if (i == lineNumber)
                {
                    return Line;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        sr.Close();

        return Line;
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
