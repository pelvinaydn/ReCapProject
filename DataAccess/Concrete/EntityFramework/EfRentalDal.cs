using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, SqlContext>, IRentalDal
    {
        public List<RentCarDetailDto> GetRentCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (SqlContext context = new SqlContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars on r.CarId equals c.CarId
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new RentCarDetailDto
                             {
                                 CarId = c.CarId,
                                 DailyPrice = c.DailyPrice,
                                 CompanyName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 RentId = r.RentId,
                                 BrandName = b.BrandName
                             };

                return result.ToList();
            }
        }
    }
}
