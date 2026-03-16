using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyunKimSQL
{
    public interface IView
    {
        IModel Model { get; set; }
        IController Controller { get; set; }
    }
}
