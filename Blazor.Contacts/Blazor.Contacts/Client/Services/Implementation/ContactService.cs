using Blazor.Contacts.Client.Services.Interfaces;
using Blazor.Contacts.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Contacts.Client.Services.Implementation
{
    public class ContactService : IContactService
    {
        public ContactService()
        {

        }

        public Task DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
