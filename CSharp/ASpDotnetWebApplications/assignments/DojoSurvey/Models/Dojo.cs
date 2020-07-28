namespace DojoSurvey.Models
{
    public class Dojo
    {
        public string[] locate{get;set;}
        public string[] lang{get;set;}
        public string name{get;set;}
        public string comments{get;set;}
        public Dojo(string[] loc,string[] lan,string nam="",string comm ="")
        {
            locate= loc;
            lang =lan;
            name = nam;
            comments = comm;

        }
    }
}