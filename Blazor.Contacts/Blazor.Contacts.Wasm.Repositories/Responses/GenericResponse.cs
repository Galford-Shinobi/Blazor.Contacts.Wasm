using System.Collections.Generic;

namespace Blazor.Contacts.Wasm.Repositories.Responses
{
    public class GenericResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
        public List<T> ListResults { get; set; }
        public string ErrorMessage { get; set; }
        public int TruePasswordHash { get; set; }
    }
}
