using IntroduccionMaui.Maodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionMaui.ConexionDatos
{
    public interface IRestConexionDatos
    {
        Task<List<Plato>> GetPlatosAsync();
        Task AddPlatoAsync(Plato plato);
        Task UpdatePlatoAsync(Plato plato);
        Task DeletePlato(int id);
    }
}
