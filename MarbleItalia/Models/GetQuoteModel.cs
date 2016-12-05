using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarbleItalia.Models
{
    public class Quote
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Location { get; set; }
        public string Marble { get; set; }
        public string Travertin { get; set; }
        public string Limestone { get; set; }
        public string OtherStone { get; set; }

        public string TypeSize { get; set; }
        public string Finishing { get; set; }
        public string Thickness { get; set; }
        public string Size { get; set; }
        public string Lenght { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Quantity { get; set; }
        public string Edge { get; set; }
        public string TypeSizeDescription { get; set; }
        public string Message { get; set; }

    }
}
