using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Utility
    {
        //Create a Static method called “LastWord” which will accepts three parameters position , stringVariable, charToParse and return type as string. for example if I pass  position as 1 , stringvariable as “welcome prathap” and charToParse as  ‘<whitespace>’ , it should split string based on charToParse and  get first word . if there is no word in given position send message  else return word in that position
        public static string LastWord(int position, string stringVariable, char charToParse)
        { 
            return (stringVariable.Split(charToParse).Length-1>=position)?(stringVariable.Split(charToParse)[position]):("Number of words are less than position mentioned.");
        }


        //Create a Non-Static method called “GetPalindromes” which accepts input as array of strings . and this method should check if any of strings are palindrome and return list of palindromes and print them on console 
        public List<string> GetPalindromes(string[] inputStringArray)
        { 
            List<string> outputList = new List<string>();
            if (inputStringArray.Length != 0)
            {
                for (int k = 0; k < inputStringArray.Length; k++)
                {
                    bool flag = true;
                    for (int i = 0, j = inputStringArray[k].Length - 1; i < j; i++, j--)
                    {
                        if (inputStringArray[k][i] != inputStringArray[k][j])
                        {
                            flag = false;
                            break;
                        }

                    }
                    if (flag == true)
                    {
                        outputList.Add(inputStringArray[k]);
                    }
                }
            }

            return outputList;
        }
    }
}
