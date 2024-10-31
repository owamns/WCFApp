using Business;
using DataAccess;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Usuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Usuario.svc o Usuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Usuario : IUsuario
    {
        private readonly BOUsuario _business;

        public Usuario()
        {
            _business = new BOUsuario();
        }

        DOUsuario.Usuario IUsuario.ObtenerUsuario(string id)
        {
            int userId = int.Parse(id);
            return _business.ObtenerUsuario(userId);
        }
    }
}
