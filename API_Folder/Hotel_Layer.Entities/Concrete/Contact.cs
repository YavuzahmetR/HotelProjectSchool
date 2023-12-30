﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Entities.Concrete
{
    public class Contact
    {
        public int ContactID {  get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int MessageCategoryID { get; set; }
        //public MessageCategory MessageCategory { get; set; }
        public DateTime Date { get; set; }
    }
}
