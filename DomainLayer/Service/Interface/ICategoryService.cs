﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DomainLayer.Service.Interface
{
    public interface ICategoryService : IService<Category>
    {
        void Create(Category a);
    }
}
