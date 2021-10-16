using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnlalyseMood_is_Happy_or_Sad()
        {
            Mood_Analyser_Problemcore.UC1_Mood_Anaylser test = new Mood_Analyser_Problemcore.UC1_Mood_Anaylser("HAPPY");
            string result = test.analyseMood();
            Assert.AreEqual(result, "HAPPY");
        }

        [TestMethod]
        public void AnalyseTheMood_I_In_Sad_mood_return_SAD()
        {
            Mood_Analyser_Problemcore.UC1_Mood_Anaylser test1 = new Mood_Analyser_Problemcore.UC1_Mood_Anaylser("I AM IN SAD MOOD");
            string result = test1.analyseMood();
            Assert.AreEqual(result, "SAD");
        }
        [TestMethod]
        public void Analyse_mood_I_Am_InAnyMood_Should_ReturnHAPPY()
        {
            Mood_Analyser_Problemcore.UC1_Mood_Anaylser test2 = new Mood_Analyser_Problemcore.UC1_Mood_Anaylser("I AM IN ANY MOOD");
            string result = test2.analyseMood();
            Assert.AreNotEqual(result, "HAPPY");
        }

        [TestMethod]
        public void AnalyseMood_NOMessage_Passed_return_SAD()
        {
            Mood_Analyser_Problemcore.UC1_Mood_Anaylser test3 = new Mood_Analyser_Problemcore.UC1_Mood_Anaylser("null");
            string result= test3.analyseMood();
            Assert.AreEqual("SAD",result);

        }

        
        
        
    }
}
