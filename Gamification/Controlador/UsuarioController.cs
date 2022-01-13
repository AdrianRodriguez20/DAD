using Modelo.ado;
using Modelo.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class UsuarioController
    {
        UsuarioADO usuarioADO = new UsuarioADO();
        public DataTable modelData;

        /*
      * Metodo para loguearse
      */
        public string Login(string user, string password)
        {
            Usuario usuario = null;
            String rol = "";
            if (user != null && !user.Trim().Equals("") && password != null && !password.Trim().Equals(""))
            {
                if (usuarioADO.findById(user) != null)
                {
                    if (usuarioADO.findById(user).Password.Equals(password) && usuarioADO.findById(user).Active==1)
                    {
                        usuario = usuarioADO.findById(user);
                    }
                }

            }
            return usuario != null ? usuario.Role : null;
        }
        /*
      * Metodo listar usuarios
      */
        public DataTable loadDataDA()
        {

            modelData = new DataTable();
            modelData = usuarioADO.LoadAdapter();
            return modelData;
        }
        /*
      * Metodo para listar usuarios por rol
      */
        public DataTable loadDataByRoleDA(String role)
        {
            modelData = new DataTable();
            modelData = usuarioADO.LoadAdapterByRole(role);
            return modelData;
        }

        /*
      * Metodo para crear un usuario
      */
        public bool crearUsuario(String username , String password , String confirmation, String role)
        {
            bool exito = false;
            if (username !=null && !username.Trim().Equals("") 
                && password != null && !password.Trim().Equals("")
                    && confirmation != null && !confirmation.Trim().Equals("")
                        && role != null && !role.Trim().Equals("")
                ) { 

                if (password.Equals(confirmation) && password.Length>=8)
                {
                    if (usuarioADO.findById(username) == null)
                    {
                        Usuario usuario = new Usuario(username, password, role, 1);
                        Console.WriteLine("ROL ->" + role);
                        usuarioADO.save(usuario);
                        exito = true;
                    }
                }
            }
            return exito;
        }

        /*
          * Metodo para listar usuarios en el tree view
          */

        public List<String[]> listarUsuarios()
        {
            List<Usuario> usuarios = usuarioADO.findAll();
            List<string[]> usuariosStr = new List<string[]>(); ;
            if (usuarioADO != null)
            {
                foreach (Usuario usuario in usuarios)
                {

                    usuariosStr.Add(new string[] {
                   usuario.Username,
                   usuario.Password,
                   usuario.Role,
                   usuario.Active.ToString()
                 });

                }
            }

            return usuariosStr;

        }
        /*
      * Metodo para eliminar
      */

        public bool eliminarUsuario(String username)
        {
            bool exito = false;
            if (usuarioADO.delete(username))
            {
                exito = true;
            }
            return exito;
        }

    }
}
