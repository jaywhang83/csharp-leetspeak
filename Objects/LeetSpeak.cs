using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class LeetSpeakTranslator
  {
    public string Translate(string input)
    {
      char[] charArray = input.ToCharArray();
      char eChar = System.Convert.ToChar("e");
      char oChar = System.Convert.ToChar("o");
      char iChar = System.Convert.ToChar("I");
      char sChar = System.Convert.ToChar("s");
      char threeChar = System.Convert.ToChar("3");
      char zeroChar = System.Convert.ToChar("0");
      char oneChar = System.Convert.ToChar("1");
      char zChar = System.Convert.ToChar("z");
      Console.WriteLine(charArray);
      string holder = "";
      for (int i = 0; i < charArray.Length; i++)
      {

        if (charArray[i] == eChar)
        {
          charArray[i] = threeChar;
        }
        else if(charArray[i] == oChar)
        {
          charArray[i] = zeroChar;
        }
        else if(charArray[i] == iChar)
        {
          charArray[i] = oneChar;
        }
        else if(charArray[i] == sChar)
        {
          if(charArray[0].Equals(sChar) == false)
          {
            charArray[i] = zChar;
          }
        }
        holder = String.Join("", charArray);
      }
      Console.WriteLine(holder);
      return holder;
    }
  }
}
