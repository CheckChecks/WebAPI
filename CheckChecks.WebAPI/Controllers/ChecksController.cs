using CheckChecks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CheckChecks.WebAPI.Controllers
{
    public class ChecksController : ApiController
    {
        public List<Check> ListOfChecks { get; set; }
        public ChecksController()
        {
            ListOfChecks = new List<Check>()
            {
                new Check()
                {
                    Id = 1,
                    Shop = "Linella",
                    Purcheses = new List<Purchase>()
                    {
                        new Purchase()
                        {
                            Id = 1,
                            Item = new Item() {Name = "Krusovice 0.5l" },
                            Quantity = 4,
                            Price = 25
                        },
                        new Purchase()
                        {
                            Id = 2,
                            Item = new Item() {Name = "Carlsberg 0.5l" },
                            Quantity = 3,
                            Price = 21
                        },
                        new Purchase()
                        {
                            Id = 3,
                            Item = new Item() {Name = "Tuborg 0.5l" },
                            Quantity = 5,
                            Price = 18
                        }
                    },
                    Total = 600
                },
                new Check()
                {
                    Id = 2,
                    Shop = "N1",
                    Purcheses = new List<Purchase>()
                    {
                        new Purchase()
                        {
                            Id = 1,
                            Item = new Item() {Name = "Cronenbourg1664 0.5l" },
                            Quantity = 1,
                            Price = 22
                        },
                        new Purchase()
                        {
                            Id = 2,
                            Item = new Item() {Name = "Bud 0.5l" },
                            Quantity = 2,
                            Price = 17
                        },
                        new Purchase()
                        {
                            Id = 3,
                            Item = new Item() {Name = "Kozel 0.5l" },
                            Quantity = 6,
                            Price = 16
                        }
                    },
                    Total = 500
                }
            };
        }
        // GET: api/v1/Checks
        public IEnumerable<Check> Get()
        {
            return ListOfChecks;
        }

        // GET: api/v1/Checks/5
        public Check Get(int id)
        {
            return ListOfChecks.FirstOrDefault(c => c.Id == id);
        }

        // POST: api/v1/Checks
        public Check Post([FromBody]Check check)
        {
            return check;
        }

        // PUT: api/v1/Checks/5
        public void Put(int id, [FromBody]Check check)
        {
        }

        // DELETE: api/v1/Checks/5
        public void Delete(int id)
        {
        }
    }
}
