using System;
using System.Collections.Generic;
using Xunit;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void LeetSpeakTranslator_ForLetterE_3()
    {
      LeetSpeakTranslator testTranslator = new LeetSpeakTranslator();
      Assert.Equal("3", testTranslator.Translate("e"));
      Console.WriteLine(testTranslator.Translate("e"));
    }
    [Fact]
    public void LeetSpeakTranslator_ForWord_h3llo()
    {
      LeetSpeakTranslator testTranslator = new LeetSpeakTranslator();
      Console.WriteLine(testTranslator.Translate("been"));
      Assert.Equal("b33n", testTranslator.Translate("been"));

    }
    [Fact]
    public void LeetSpeakTranslator_ForO_d00r()
    {
      LeetSpeakTranslator testTranslator = new LeetSpeakTranslator();
      Console.WriteLine(testTranslator.Translate("door"));
      Assert.Equal("d00r", testTranslator.Translate("door"));
    }
    [Fact]
    public void LeetSpeakTranslator_ForI_1()
    {
      LeetSpeakTranslator testTranslator = new LeetSpeakTranslator();
      Assert.Equal("1 am", testTranslator.Translate("I am"));
    }
  }

}
