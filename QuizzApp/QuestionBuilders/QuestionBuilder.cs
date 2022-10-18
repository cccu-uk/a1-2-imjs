using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuizzApp.QuestionBuilders
{
    internal class QuestionBuilder
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Incorrect1 { get; set; }
        public string Incorrect2 { get; set; }
        public string Incorrect3 { get; set; }

        public QuestionBuilder() 
        {
            using (StreamReader sr = new StreamReader("Questions.json"))
            {
                string json = sr.ReadToEnd();
                JSONObject obj = JsonConvert.DeserializeObject<JSONObject>(json);

                var random = new Random();
                var dataGeneralKnowledge = obj.GeneralKnowledge[random.Next(0, obj.GeneralKnowledge.Length)];
            }
        }
    }

    class JSONObject 
    {
        public string Questions { get; set; }
        public Film[] Films { get; set; }
        public GeneralKnowledge[] GeneralKnowledge { get; set; }
        public Music[] Music { get; set; }
        public Animals Animals { get; set; }
    }


    public class Film
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Incorrect1 { get; set; }
        public string Incorrect2 { get; set; }
        public string Incorrect3 { get; set; }
    }

    public class GeneralKnowledge
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Incorrect1 { get; set; }
        public string Incorrect2 { get; set; }
        public string Incorrect3 { get; set; }
    }

    public class Music
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Incorrect1 { get; set; }
        public string Incorrect2 { get; set; }
        public string Incorrect3 { get; set; }
    }

    public class Animals
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Incorrect1 { get; set; }
        public string Incorrect2 { get; set; }
        public string Incorrect3 { get; set; }
    }
}
