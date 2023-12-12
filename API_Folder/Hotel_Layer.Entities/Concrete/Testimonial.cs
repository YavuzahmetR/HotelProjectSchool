using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Entities.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string Name {  get; set; }
        public string TestimonialTitle {  get; set; }
        public string Description { get; set; }
        public string TestimonialImage { get; set; }
    }
}
