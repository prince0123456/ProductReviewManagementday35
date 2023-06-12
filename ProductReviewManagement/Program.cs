using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product review management");
            
            List<ProductReview> list = new List<ProductReview>()
            {
            new ProductReview() { ProductID = 1, UserID = 1, Rating = 5.5, Review = "Good", IsLike=true},
            new ProductReview() { ProductID = 1, UserID = 2, Rating = 4.5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 2, UserID = 3, Rating = 6, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 2, UserID = 4, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 4, UserID = 5, Rating = 5, Review = "Nice", IsLike=true },
            new ProductReview() { ProductID = 5, UserID = 6, Rating = 5, Review = "Nice", IsLike=true },
            new ProductReview() { ProductID = 6, UserID = 7, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 7, UserID = 8, Rating = 7.5, Review = "Good", IsLike=false},
            new ProductReview() { ProductID = 4, UserID = 9, Rating = 1.5, Review = "Good", IsLike=false },
            new ProductReview() { ProductID = 9, UserID = 10, Rating = 6.5, Review = "Bad", IsLike=false },
            new ProductReview() { ProductID = 2, UserID = 11, Rating = 5, Review = "Bad", IsLike=false },
            new ProductReview() { ProductID = 1, UserID = 12, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 4, UserID = 13, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 7, UserID = 14, Rating = 5, Review = "Bad", IsLike=true },
            new ProductReview() { ProductID = 3, UserID = 15, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 1, UserID = 16, Rating = 5, Review = "Good", IsLike=true }
            };
            try
            {
                ProductReview productReview = new ProductReview();
                while (true)
                {
                    ProductReviewManagement prm = new ProductReviewManagement();
                    Console.WriteLine("\nChoose option\n1: Display all records\n2: Top 3 records by rating\n3: display records whose rating > 3\n4: CountProductIdUsingGroupBy\n5: GetProductIDAndReview\n" +
                        "6: Skip5Records\n0: Exit \n");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            //uc1
                            Console.WriteLine("Displaying all records");
                            DisplayProducts(list);
                            break;
                        case 2:
                            // uc2 display top 3 records by rating
                            Console.WriteLine("\nTop 3 records are :");
                            prm.RetriveTopThreeRecords(list);
                            break;
                        case 3:
                            //uc3 RetriveRecordsWithRatingGreaterThan3
                            Console.WriteLine("\nRecords With Rating Greater Than 3 or id =1 or 4 or 9 :");
                            prm.RetriveRecordsWithRatingGreaterThan3(list);
                            break;
                        case 4:
                            //uc4 Retrieve count of review present for each productID
                            prm.CountProductIdUsingGroupBy(list);
                            break;
                        case 5:
                            //uc5 Get ProductID And Review for all records
                            prm.GetProductIDAndReview(list);
                            break;
                        case 6:
                            //uc6 skip 5 records
                            prm.Skip5Records(list);
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Displaying all products
        /// </summary>
        /// <param name="list"></param>
        public static void DisplayProducts(List<ProductReview> list)
        {
            try
            {
                foreach (var lists in list)
                {
                    Console.WriteLine("Product id = " + lists.ProductID + "  User id = " + lists.UserID + "  Rating is = " + lists.Rating + "  Review is = " + lists.Review + "  isLike = " + lists.IsLike);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
