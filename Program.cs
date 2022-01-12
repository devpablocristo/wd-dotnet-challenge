using BookStore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class Program
    {
        public static List<Book> Inventory = new List<Book>();
        public static void Main(string[] args) {
            //Adding some sqmpleData
            Inventory  = new List<Book>(){ 
                new Book() { Title = "Lord of the Rings", Stock = 10 },
                new Book() { Title = "Harry Potter", Stock = 20 },
                new Book() { Title = "Hunger Games", Stock = 30},
                new Book() { Title = "The Martian", Stock = 40 }};

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
