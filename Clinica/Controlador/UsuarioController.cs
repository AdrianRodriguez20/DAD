using Modelo;



namespace Controlador
{
    public class LoginController
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO(new GestorFichero("users.txt"));
        
        /**
         * Función para iniciar sesión , a través del usuario y deni que devuelve un rol si consta en el fichero y un null si no existe.
         */
        public string Login(string user, string password)
        {
            Usuario usuario = null;

            if (usuarioDAO.findById(user)!=null )
            {
                if (usuarioDAO.findById(user).Password.Equals(password))
                {
                    usuario = usuarioDAO.findById(user);
                }
            }
            
            return usuario!=null?usuario.Rol:null;

        }



        
    }
}