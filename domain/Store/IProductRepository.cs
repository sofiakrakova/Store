using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IProductRepository
    {
        Product[] GetAllByTitle(string titlePart);

    }
}
