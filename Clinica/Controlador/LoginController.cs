using Modelo;



namespace Controlador
{
    public class LoginController
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO("users.txt");
        
        
        public Usuario Login(string user, string password)
        {
            Usuario usuario = null;
            Usuario usuarioLogin = new Usuario(user,password);

            if (usuarioDAO.findById(user)!=null )
            {
                if (usuarioDAO.findById(user).Password.Equals(password))
                {
                    usuario = usuarioDAO.findById(user);
                }
            }
            
            return usuario;

        }



        
    }
}