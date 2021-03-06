using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.InterestedDtos
{
    public class InterestedAddDto
    {
        [DisplayName("Hobi & İlgi Alanı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(200, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(5, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string Text { get; set; }
    }
}
