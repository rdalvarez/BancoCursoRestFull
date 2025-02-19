using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDateTimeService
    {
        // Se puede agregar lo que es CreateBy y LastModifi a travez de esta interfaz
        public DateTime NowUtc { get; }
    }
}
