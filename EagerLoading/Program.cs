using EagerLoading.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EagerLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindContext())
            {
              var result =  context.Products.Include(p => p.Categories).ToList();

                

                Console.WriteLine();
                Console.ReadLine();
            }


            
        }
    }
}
