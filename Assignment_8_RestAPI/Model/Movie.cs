using System.ComponentModel.DataAnnotations;

namespace Assignment_8_RestAPI.Model
{
    public class Movie
    {
        public int Movie_id {  get; set; }
        [Required(ErrorMessage = "Enter  Name :")]
        public string Movie_name { get; set; }
        [Required(ErrorMessage = "Enter  the language:")]
        public string Language {  get; set; }
        [Required(ErrorMessage = "Enter  the year:")]
        [Range(2020,2023)]
        public int ReleaseYear { get; set; }
        [Required(ErrorMessage = "Enter  the actorname:")]
        public string Actor {  get; set; }  
        public string Director { get; set; }

    }
}
