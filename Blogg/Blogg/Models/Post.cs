using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blogg.Models
{
    public partial class Post
    {
        [Required(ErrorMessage = "Text är obligatoriskt i ett inlägg")]
        [DisplayName("Skriv ditt inlägg: ")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Lägg in en rubrik")]
        [DisplayName("Ange rubrik: ")]
        public string Header { get; set; }

        public DateTime Time { get; set; }

        [Required(ErrorMessage = "Välj en kategori")]
        [DisplayName("Välj en kategori: ")]
        public int CategoryId { get; set; }

        public int PostId { get; set; }

        public Category Category { get; set; }
    }
}
