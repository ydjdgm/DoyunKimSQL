using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyunKimSQL
{
    public interface IController
    {
        IView View { get; set; }
        IModel Model { get; set; }
        List<Klasse> LadenKlasse();
        List<Schueler> LadenSchueler();
        List<Workshop> LadenWorkshop();
    }
}
