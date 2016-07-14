using CheckChecks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CheckChecks.WebAPI.Controllers
{
    public class ImagesController : ApiController
    {
        // POST: api/v1/Images
        public Check Post()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            return new Check()
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
            };
        }
    }
}