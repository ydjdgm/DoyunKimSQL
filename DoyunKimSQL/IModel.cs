using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyunKimSQL
{
    internal interface IModel
    {
        IView View { get; set; }
        IController Controller { get; set; }
    }
}
