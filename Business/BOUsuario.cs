using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.DOUsuario;

namespace Business
{
    public class BOUsuario
    {
        private readonly DataAccess.DOUsuario _dataAccess;

        public BOUsuario()
        {
            _dataAccess = new DataAccess.DOUsuario();
        }

        public Usuario ObtenerUsuario(int id)
        {
            return _dataAccess.ObtenerUsuario(id);
        }
    }
}
