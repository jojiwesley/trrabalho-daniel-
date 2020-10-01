using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioDeVerificação
{
    class Funcionalidades : IMetodos
    {
        #region CampoNome
        public bool ValidaNome(string Nome)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
#endregion
     
        public bool ValidaNomeRecado(string Numero, string NomeRecado)
        {
            if (string.IsNullOrEmpty(Numero) && string.IsNullOrEmpty(NomeRecado))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool ValidaTelefoneRecado(string Numero)
        {
            if (string.IsNullOrEmpty(Numero))
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        #region CampoVaga
        public bool ValidaVaga(int id)
        {
            if(id < 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        #endregion
            
    }
}
