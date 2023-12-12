using NotesManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NotesManagementApp.DAL.Services.Repository
{
    public class NotesRepository : INotesRepository
    {
        private readonly DatabaseContext _dbContext;
        public NotesRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Notes> CreateNotes(Notes expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteNotesById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Notes> GetAllNotess()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Notes> GetNotesById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Notes> UpdateNotes(Notes model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}