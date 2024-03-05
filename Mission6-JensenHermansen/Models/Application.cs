using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Mission6_JensenHermansen.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public string Category { get; set; }
        public String Title { get; set; }
        [Range(1888, 2050, ErrorMessage = "You must enter a valid Year")]

        public int Year { get; set; } = 2024;
        public string Director {  get; set; }
        public string Rating { get; set; }
        public bool edited {  get; set; }
        public string? Lent { get; set; }


    }
}
