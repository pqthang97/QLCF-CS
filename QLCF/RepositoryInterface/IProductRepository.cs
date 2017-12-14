﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.RepositoryInterface
{
    interface IProductRepository
    {
        IEnumerable<Product> FindAll();
        IEnumerable<Product> FindAvailable();
        Product FindBy(int id);
        void Save(Product order);
    }
}