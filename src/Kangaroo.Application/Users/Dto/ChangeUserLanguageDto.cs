using System.ComponentModel.DataAnnotations;

namespace Kangaroo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}