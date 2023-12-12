using NotesManagement.Models;
using NotesManagementApp.DAL.Interrfaces;
using NotesManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NotesManagementApp.Controllers
{
    public class NotesController : ApiController
    {
        private readonly INotesService _service;
        public NotesController(INotesService service)
        {
            _service = service;
        }
        public NotesController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Notes/CreateNotes")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateNotes([FromBody] Notes model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Notes/UpdateNotes")]
        public async Task<IHttpActionResult> UpdateNotes([FromBody] Notes model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Notes/DeleteNotes")]
        public async Task<IHttpActionResult> DeleteNotes(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Notes/GetNotesById")]
        public async Task<IHttpActionResult> GetNotesById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Notes/GetAllNotess")]
        public async Task<IEnumerable<Notes>> GetAllNotess()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
