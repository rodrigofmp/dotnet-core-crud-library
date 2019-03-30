using AutoMapper;
using LibraryAPI.Core.Entities;
using LibraryAPI.Core.Repository;
using LibraryAPI.Models.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public BooksController(IMapper mapper, IBookRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<BookResource> Get()
        {
            var result = new List<BookResource>();
            
            var books = _repository.GetAllBooks();
            foreach (var book in books)
            {
                result.Add(_mapper.Map<Book, BookResource>(book));
            }

            return result;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _repository.GetBook(id);

            if (book == null)
                return NotFound();

            var resource = _mapper.Map<Book, BookResource>(book);

            return Ok(resource);
        }

        [HttpPost]
        public IActionResult Post([FromBody] SaveBookResource form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = _mapper.Map<SaveBookResource, Book>(form);

            _repository.Add(model);
            _unitOfWork.Complete();

            var book = _repository.GetBook(model.Id);

            var result = _mapper.Map<Book, BookResource>(book);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SaveBookResource form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = _repository.GetBook(id);

            if (model == null)
                return NotFound();

            _mapper.Map<SaveBookResource, Book>(form, model);

            _unitOfWork.Complete();

            var book = _repository.GetBook(model.Id);

            var result = _mapper.Map<Book, BookResource>(book);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _repository.GetBook(id);

            if (book == null)
                return NotFound();

            _repository.Remove(book);
            _unitOfWork.Complete();

            return Ok(id);
        }
    }
}
