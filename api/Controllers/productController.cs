using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myApi.Models;

namespace myApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private static List<product> product = new List<product>
        {
            new product{
                Id = Guid.NewGuid().ToString(),
                Name = "นม",
                price = 50,
                ProfileImage="https://static.bigc.co.th/media/catalog/product/cache/8/image/500x/9df78eab33525d08d6e5fb8d27136e95/8/8/8850329150113_1.jpg"
            },
             new product{
                Id = Guid.NewGuid().ToString(),
                Name = "นมนม",
                price = 60,
                ProfileImage="https://static.bigc.co.th/media/catalog/product/cache/8/image/500x/9df78eab33525d08d6e5fb8d27136e95/8/8/8850329183418_1_1.jpg"
            },
             new product{
                Id = Guid.NewGuid().ToString(),
                Name = "นมนมนม",
                price = 20,
                ProfileImage="https://d2t5tgzzxhb6v2.cloudfront.net/media//catalog/product/8/8/8851717030512.jpg"
            },
        };
        [HttpGet]
        public List<product> Getallproduct()
        {
            return product;
        }   
        [HttpGet("{id}")]
        public product Getproduct(string id)
        {
            return product.Find(it => it.Id == id);
        }
        [HttpPost]
        public void Createproduct([FromBody]product newStudent)
        {
            newStudent.Id = Guid.NewGuid().ToString();
            product.Add(newStudent);
        }
      
    }
}
