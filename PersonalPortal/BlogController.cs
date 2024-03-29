﻿using System.Threading.Tasks;
using DBRepository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace PersonalPortal
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [Route("page")]
        [HttpGet]
        public async Task<Page<Post>> GetPosts(int pageIndex, string tag)
        {
            return await _blogRepository.GetPosts(pageIndex, 10, tag);
        }
    }
}
