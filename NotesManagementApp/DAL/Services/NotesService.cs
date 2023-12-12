using NotesManagementApp.DAL.Interrfaces;
using NotesManagementApp.DAL.Services.Repository;
using NotesManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NotesManagementApp.DAL.Services
{
    public class NotesService : INotesService
    {
        private readonly INotesRepository _repository;

        public NotesService(INotesRepository repository)
        {
            _repository = repository;
        }

        public Task<Notes> CreateNotes(Notes expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNotesById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Notes> GetAllNotess()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Notes> GetNotesById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Notes> UpdateNotes(Notes model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}