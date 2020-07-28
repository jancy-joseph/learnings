namespace ViewModelFun.Models
{
    public class User
    {
        public string firstName { get; set; }
        public string lastname{get;set;}
        public User(string fname="",string lname="") 
        {
            firstName =fname;
            lastname=lname;
        }
    }
}