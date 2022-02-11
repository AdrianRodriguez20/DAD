using System;


namespace Modelo
{
    
    public class Usuario
    {
        private String user;
        private String password;
        private String rol;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Usuario()
        {
            
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="user"> nombre de usuario</param>
        /// <param name="password">contraseña del usuario</param>
        /// <param name="rol"> rol del usuario</param>
        public Usuario(String user, String password, String rol)
        {
            this.user = user;
            this.password = password;
            this.rol = rol;
        }
        public Usuario(String user, String password)
        {
            this.user = user;
            this.password = password;
        }

        
        
        public string User
        {
            get => user;
            set => user = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
        
        public string Rol
        {
            get => rol;
            set => rol = value;
        }

        public override string ToString()
        {
            return user+":"+password+":"+rol;
        }
    }
    
}
