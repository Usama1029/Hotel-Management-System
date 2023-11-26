using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SElabProject.BL;
using SElabProject.DL;

namespace SElabProject.DL
{
    // Add this class or method within the customerDL class
    public static class FeedbackDL
    {
        private static List<string> feedbackList = new List<string>();

        public static void AddFeedback(string feedback)
        {
            feedbackList.Add(feedback);
        }

        public static List<string> GetFeedbackList()
        {
            return feedbackList;
        }

        public static void StoreFeedbackToFile(string path, string feedback)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(feedback);
            }
        }

        public static List<string> ReadFeedbackFromFile(string path)
        {
            List<string> feedbackFromFile = new List<string>();
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        feedbackFromFile.Add(line);
                    }
                }
            }
            return feedbackFromFile;
        }
    }

    // Now, you can use the FeedbackDL methods to capture and store feedback in your application.

}
