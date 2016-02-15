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
    [Fact]
    public void LeetSpeakTranslator_ForS_Z()
    {
      LeetSpeakTranslator testTranslator = new LeetSpeakTranslator();
      Assert.Equal("pizz", testTranslator.Translate("piss"));
    }
    [Fact]
    public void LeetSpeakTranslator_ForWordStartingWithS_S()
    {
      LeetSpeakTranslator testTranslator = new LeetSpeakTranslator();
      Assert.Equal("D0n't y0u l0v3 th3z3 'String' 3x3rciz3z? 1 d0!", testTranslator.Translate("Don't you love these 'String' exercises? I do!" ));
    }
  }


}
