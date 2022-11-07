using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();  //işlem sonucu ve mesajı da döndürmek istiyorum
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();
        IDataResult<Product> GetById(int product);
        IResult Add(Product product);
        IResult Update(Product product);
    }
}
