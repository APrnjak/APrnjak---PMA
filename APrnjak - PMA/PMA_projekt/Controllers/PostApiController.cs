using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PMA_projekt.DtoMapper;
using PMA_projekt.Models;
using PMA_projekt.Services;

namespace PMA_projekt.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostApiController : ControllerBase
    {
        private PostService _postService;
        public PostApiController(PostService postService) //konstruktor API-a
        {
            _postService = postService;
        }


        [HttpGet]
        public ActionResult<List<Objava>> Get()
        {
            return _postService.GetAll().ToList();
        }

        [HttpGet("{id}")]    //putanja ->  .../api/post/{id}
        public ActionResult<Objava> Get(int id)    //dohvati jednog iz baze; onog sa zadanim tj. primljenim id-om; 
        {
            return _postService.GetAll(id);
        }

        [HttpDelete("delete/{id}")]  //ruta ce imati dodatni parametar zvan id
        public ActionResult DeleteAndReturnAll(int id)
        {
            var result = _postService.DeleteAndReturnAll(id);
            return Ok(result); //moramo vratiti funkciju ok -> uz to saljemo i preostale knjige u nasoj bazi
        }

        [HttpPut("update")]
        public ActionResult<List<Objava>> Update([FromBody] JObject json)
        {
            var post = PostDto.FromJson(json);
            var result = _postService.Update(post);
            return Ok(result);
        }

        [HttpPost("save")]
        public ActionResult Save([FromBody] JObject json)
        {
            var post = PostDto.FromJson(json);
            _postService.Save(post);
            return Ok();
        }
    }
}
