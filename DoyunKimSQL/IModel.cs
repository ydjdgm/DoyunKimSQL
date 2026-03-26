using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyunKimSQL
{
    public interface IModel
    {
        IView View { get; set; }
        IController Controller { get; set; }
        List<Klasse> GetKlasse();
        List<Schueler> GetSchueler();
        List<Workshop> GetWorkshop();
        void AendernKlasse(List<Klasse> klassen);
    }
}
