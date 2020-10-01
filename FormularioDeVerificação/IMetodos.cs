using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioDeVerificação
{
   public interface IMetodos
    {
        bool ValidaTelefoneRecado(string Numero);
        bool ValidaNome(string Nome);
        bool ValidaVaga(int id);
        bool ValidaNomeRecado(string Numero, string NomeRecado); 
    }
}
