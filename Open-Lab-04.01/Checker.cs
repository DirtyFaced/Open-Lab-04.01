using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            int dlzka = str.Length;
            for (int i = 0; i < dlzka - 1; i++)
            {
                char first = str[i];
                char second = str[i+1];
                if (first == second)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
