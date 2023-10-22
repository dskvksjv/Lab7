using System.ComponentModel.DataAnnotations;

namespace Lab7.Models
{
    public class FileDownloadModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "File Name")]
        public string FileName { get; set; }
    }
}

