﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protell.Model.IRepository
{
    public interface IPuntoMedicionMaxMin
    {
        // Read.
        IEnumerable<PuntoMedicionMaxMinModel> GetPuntoMedicionsMaxMin();
    }
}
