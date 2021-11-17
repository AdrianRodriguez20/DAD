using Modelo;



namespace Controlador
{
    public class LoginController
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO(new GestorFichero("users.txt"));
        
        
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