//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Protell.Server.DAL.POCOS
{
    public partial class C_CAT_PUNTO_MEDICION
    {
        #region Primitive Properties
    
        public virtual long IdPuntoMedicion
        {
            get;
            set;
        }
    
        public virtual string PuntoMedicionName
        {
            get;
            set;
        }
    
        public virtual long IdUnidadMedida
        {
            get;
            set;
        }
    
        public virtual long IdTipoPuntoMedicion
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ValorReferencia
        {
            get;
            set;
        }
    
        public virtual string ParametroReferencia
        {
            get;
            set;
        }
    
        public virtual bool IsActive
        {
            get;
            set;
        }
    
        public virtual bool IsModified
        {
            get;
            set;
        }
    
        public virtual long LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual bool Visibility
        {
            get;
            set;
        }
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }

        #endregion

    }
}
