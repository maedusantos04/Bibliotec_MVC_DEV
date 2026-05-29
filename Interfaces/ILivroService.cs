using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibilotec_MVC_DEV.Models;

namespace Bibilotec_MVC_DEV.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> BuscarLivrosComCatAsync();
    }
}