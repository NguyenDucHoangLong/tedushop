﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProDuctCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(String alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProDuctCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) 
            : base(dbFactory)
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}