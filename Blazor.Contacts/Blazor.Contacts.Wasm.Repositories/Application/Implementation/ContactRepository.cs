using Blazor.Contacts.Shared.ViewModels;
using Blazor.Contacts.Wasm.Repositories.Application.Interfaces;
using Blazor.Contacts.Wasm.Repositories.Responses;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repositories.Application.Implementation
{
    public class ContactRepository: IContactRepository
    {
        public ContactRepository()
        {

        }

        public Task<GenericResponse<Contact>> DeleteContact(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<GenericResponse<Contact>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<GenericResponse<Contact>> GetDetails(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<GenericResponse<Contact>> InsertContact(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public Task<GenericResponse<Contact>> UpdateContact(Contact contact)
        {
            throw new System.NotImplementedException();
        }
    }
}
