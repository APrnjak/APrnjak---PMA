using PMA_projekt.Models;
using PMA_projekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Services
{
    public class PostService
    {
        private readonly PostRepository _postRepository;
        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IEnumerable<Models.Objava> GetAll()
        {
            return _postRepository.GetAll();
        }

        public Models.Objava GetAll(int id)
        {
            return _postRepository.GetAll(id);
        }

        public IEnumerable<Models.Objava> DeleteAndReturnAll(int id)
        {
            return _postRepository.DeleteAndReturnAll(id);
        }

        public IEnumerable<Models.Objava> Update(Objava post)
        {
            return _postRepository.Update(post);
        }

        public void Save(Objava post)
        {
            _postRepository.Save(post);
        }
    }
}

