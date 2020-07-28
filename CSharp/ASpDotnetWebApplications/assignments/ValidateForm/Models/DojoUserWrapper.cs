namespace ValidateForm.Models
{
    public class DojoUserWrapper
    {
        public User user{get;set;}
        public Dojo dojo{get; set;}
        public DojoUserWrapper()
        {
            
        }

        public DojoUserWrapper( User u, Dojo d)
        {
            user = u;
            dojo = d;
        }
    }
}