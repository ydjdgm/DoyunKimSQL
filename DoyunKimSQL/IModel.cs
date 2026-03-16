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
        public List<Klasse> GetKlasse();
        public List<Schueler> GetSchueler();
        public List<Workshop> GetWorkshop();
    }
}
