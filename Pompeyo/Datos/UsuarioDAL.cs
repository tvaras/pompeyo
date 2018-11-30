using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class UsuarioDAL
    {

        public UsuarioDTO login(string username, string pass)
        {
            UsuarioDTO user = null;

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                user = (from u in dbo.Usuario
                        where u.usuario1 == username && u.contraseña == pass
                        select new UsuarioDTO() {
                            idUsuario = u.idUsuario,
                            nombre = u.nombre,
                            usuario1 = u.usuario1,
                            contraseña = u.contraseña
                        }).FirstOrDefault<UsuarioDTO>();
            }

            return user;
        }
    }
}
