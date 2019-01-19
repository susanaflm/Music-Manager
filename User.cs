using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenário_B
{
    class User
    {
        public int id;
        public string username;
        public string email;
        public string password;
        public string perfil;

        public User()
        {
                
        }


        public User(int id, string username, string email, string password, string perfil)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
            this.perfil = perfil;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        //to get the values
        public string getUsername()
        {
            //returns the value it got
            return this.username;
        }
        //to use the values
        public void setUsername(string username)
        {
            //then it sets the value got
            this.username = username;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPerfil()
        {
            return this.perfil;
        }

        public void setPerfil(string perfil)
        {
            this.perfil = perfil;
        }
    }
}
