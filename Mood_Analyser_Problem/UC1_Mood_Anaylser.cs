using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using Mood_Analyser_Problemcore;
using Mood_Analyser_Problem;



namespace Mood_Analyser_Problemcore
{
   public class UC1_Mood_Anaylser
    {
        private string message;
       
        public UC1_Mood_Anaylser (string message)
        {
            this.message = message;
        }
        public UC1_Mood_Anaylser()
        {

        }
        public   string analyseMood()

        {
            string from="raja";
            try
                {
                    if (this.message.Equals(string.Empty))
                    {
                        return "SAD";
                    }
                    if (this.message.Equals("HAPPY"))
                        return "HAPPY";
                    else
                        return "SAD";
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Mood Should Not Be Null");
                }

            return from;

                                                               
            
            
        }
    }
}
