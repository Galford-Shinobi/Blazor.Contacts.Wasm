using Blazor.Contacts.Shared.ViewModels;
using Blazor.Contacts.Wasm.Repositories.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repositories.Application.Interfaces
{
    public interface IContactRepository
    {
        Task<GenericResponse<Contact>> InsertContact(Contact contact);
        Task<GenericResponse<Contact>> UpdateContact(Contact contact);
        Task<GenericResponse<Contact>> DeleteContact(int id);
        Task<GenericResponse<Contact>> GetAll();
        Task<GenericResponse<Contact>> GetDetails(int id);
    }
}
