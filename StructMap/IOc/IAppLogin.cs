using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOc
{
    public interface IAppLogin
    {
        void login();
        void logout();
        TyService GetTypeService<TyService>();
    }
}
