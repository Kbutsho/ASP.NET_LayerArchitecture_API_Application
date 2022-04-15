using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Database;

namespace DataAccessLayer
{
    public interface IAuth
    {
        Token Authenticate(User user);
        bool IsAuthenticated(string token);

        void Logout(Token token);
    }
}
