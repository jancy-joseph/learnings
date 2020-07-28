using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValidateForm.Models
{
    public class Dojo
    {
        [Required(ErrorMessage="DojoName required")]
        [MinLength(2,ErrorMessage ="2 Characters required")]
        public string FullName { get; set; }
        [Required(ErrorMessage="Dojo Location required")]
        public List<string> DojoLocation { get; set; }
        [Required(ErrorMessage="Favourite Language required")]
        public List<string> FavoriteLanguage { get; set; }

        [MaxLength(20,ErrorMessage="No more than 20 Characters")]
        public string Comments{get;set;}
        public Dojo(string uname)
        {

        }
        public Dojo(string dname,List<string> dloc,List<string> flang)
        {
            FullName=dname;
            DojoLocation = dloc;
            FavoriteLanguage =flang;
        }
        public Dojo(string dname,List<string> dloc,List<string> flang,string comm)
        {
            FullName=dname;
            DojoLocation = dloc;
            FavoriteLanguage =flang;
            Comments = comm;
        }

    }
}