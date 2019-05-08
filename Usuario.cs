using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoPulseira
{
    class Usuario
    {
        public  String[,] users = new String[1000,2];
        public int qtdusers=2;

        public Usuario() {
            for (int i = 0;i<users.GetLength(0) ;i++ )
            {
                users[i, 0] = "#MstrBz2012";
                users[i, 1] = "#BizuDigital559";
            }

            users[0, 0] = "q";
            users[0, 1] = "q";
            users[1, 0] = "Fernando";
            users[1, 1] = "123456";
        }

        public int Autenticar(String usu,String senha) {

            for (int i = 0; i<users.GetLength(0);i++ )
            {
                if(users[i,0]==usu && users[i,1]==senha){
                    return 1;
                }
            }

            return 0;
        }

        public void add(String us, String senha)
        {

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] != "#MstrBz2012" && users[i, 1] != "BizuDigital559")
                {
                    users[i, 0] = us;
                    users[i, 1] = senha;
                    break;
                }
            }
        }

        public void remover(String us, String senha)
        {
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == us && users[i, 1] == senha)
                {
                    users[i, 0] = "MstrBz2012";
                    users[i, 1] = "BizuDigital559";
                    break;
                }
            }
        }
    }
}
