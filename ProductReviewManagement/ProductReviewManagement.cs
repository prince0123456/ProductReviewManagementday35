using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewManagement
    {
        /// <summary>
        /// Retriving Top ThreeRecords by passing object of list of product review 
        /// </summary>
        /// <param name="list"></param>
        public void RetriveTopThreeRecords(List<ProductReview> list)
        {
            var top3Records=list.OrderByDescending(P=>P.Rating).Take(3).ToList();       //using lambda expression
            Program.DisplayProducts(top3Records);
        }
        /// <summary>
        /// UC3 Retrive All Records With Rating Greater Than 3 or id =1 or 4 or 9
        /// </summary>
        /// <param name="list"></param>
        public void RetriveRecordsWithRatingGreaterThan3(List<ProductReview> list)
        {
            var allRecords = list.Where(P => P.Rating > 3 && (P.ProductID == 1) || (P.ProductID == 4) || (P.ProductID == 9)).ToList();      //using lambda expression
            Program.DisplayProducts(allRecords);
        }

        /// <summary>
        /// uc4 Count ProductID Using GroupBy
        /// </summary>
        /// <param name="list"></param>
        public void CountProductIdUsingGroupBy(List<ProductReview> list)     
        {
            Console.WriteLine("\n Count ProductId Using GroupBy ");
            var res = list.GroupBy(p => p.ProductID).Select(p => new { Id = p.Key, count = p.Count() });
            foreach (var p in res)
            {
                Console.WriteLine("ProductID="+p.Id+" Count="+p.count);
            }
        }

        /// <summary>
        ///uc5  Get ProductID And Review for all records
        /// </summary>
        /// <param name="list"></param>
        public void GetProductIDAndReview(List<ProductReview> list)
        {
            Console.WriteLine("\n ProductId and review are :");
            var res = list.Select(p => new { Id = p.ProductID, Review = p.Review }).ToList();
            foreach(var p in res)
            {
                Console.WriteLine("Product ID="+p.Id+" Review="+p.Review);
            }
        }

        /// <summary>
        /// uc6 skip 5 records and dispaly all others
        /// </summary>
        /// <param name="list"></param>
        public void Skip5Records(List<ProductReview> list)
        {
            Console.WriteLine("skipping 5 records");
            var res = list.Skip(5).ToList();
            Program.DisplayProducts(res);
        }
    }
}
