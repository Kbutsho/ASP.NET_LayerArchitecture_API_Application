using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Database;

namespace DataAccessLayer.Repos
{
    public class ProductRatingRepo : IRepository<ProductRating, int>
    {
        private ProjectEntities db;
        public ProductRatingRepo(ProjectEntities db)
        {
            this.db = db;
        }
        public void Add(ProductRating obj)
        {
            throw new NotImplementedException();
        }

        public ProductRating Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductRating> Get()
        {
            return db.ProductRatings.ToList();
        }

        public void Edit(ProductRating obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductRating> GetByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
