using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentacarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentacarContext context = new RentacarContext())
            {
                var result = from r in context.Rentals                             
                             join c in context.Cars 
                             on r.CarId equals c.Id
                             join b in context.Brands 
                             on c.BrandId equals b.Id
                             join cu in context.Customers 
                             on r.CustomerId equals cu.Id
                             join u in context.Users 
                             on cu.UserId equals u.Id

                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 BrandName = b.Name,
                                 CarName = c.CarName,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
                                 