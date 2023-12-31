﻿using Hotel_Layer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.DataAccess.Abstract
{
    public interface ISendMessageDal :IGenericDal<SendMessage>
    {
        int GetSendMessageNumber();
    }
}
