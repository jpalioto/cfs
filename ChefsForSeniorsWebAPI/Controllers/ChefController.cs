﻿using ChefsForSeniors.Data.DTO.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChefsForSeniorsWebAPI.Controllers
{
    public class ChefController : ApiController
    {
        [SwaggerOperation("GetAll")]
        public IEnumerable<Chef> Get()
        {
            var chef = Models.ChefModel.GetAllChefs();
            return chef;
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<Chef> Get(int id)
        {
            var chef = Models.ChefModel.GetChef(id);
            return chef;
        }
    }
}
