using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace People.Models.Infrastructure
{
    public interface IDatabaseAccessor
    {
         DataSet Query(FormattableString query);//formattable è una classe che getisce la divisione tra query e parametri

    }
}