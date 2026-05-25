
using Bibilotec_MVC_DEV.Models;

namespace Bibilotec_MVC_DEV.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> BuscarPorEmailSenha(string email, string senha);
    }
}