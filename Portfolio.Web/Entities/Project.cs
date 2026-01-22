using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        [MinLength(5, ErrorMessage = "Proje adı en az 5 karakter olmalıdır.")]
        [MaxLength(50, ErrorMessage = "Proje adı en fazla 50 karakter olabilir.")]
        [Required(ErrorMessage = "Proje adı gereklidir.")]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Resim URL'si boş bırakılamaz.")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Github URL'si boş bırakılamaz.")]
        public string GithubURL { get; set; }
        [Required(ErrorMessage = "Kategori boş bırakılamaz.")]
        public int CategoryId { get; set; }

        //navigation property
        public Category? Category { get; set; }
    }
}
