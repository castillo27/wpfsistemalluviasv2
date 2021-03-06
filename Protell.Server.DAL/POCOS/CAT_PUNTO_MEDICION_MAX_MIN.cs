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
    public partial class CAT_PUNTO_MEDICION_MAX_MIN
    {
        #region Primitive Properties
    
        public virtual long IdPuntoMedicionMaxMin
        {
            get;
            set;
        }
    
        public virtual long IdPuntoMedicion
        {
            get { return _idPuntoMedicion; }
            set
            {
                if (_idPuntoMedicion != value)
                {
                    if (CAT_PUNTO_MEDICION != null && CAT_PUNTO_MEDICION.IdPuntoMedicion != value)
                    {
                        CAT_PUNTO_MEDICION = null;
                    }
                    _idPuntoMedicion = value;
                }
            }
        }
        private long _idPuntoMedicion;
    
        public virtual double Max
        {
            get;
            set;
        }
    
        public virtual double Min
        {
            get;
            set;
        }
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<long> LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> IsModified
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual CAT_PUNTO_MEDICION CAT_PUNTO_MEDICION
        {
            get { return _cAT_PUNTO_MEDICION; }
            set
            {
                if (!ReferenceEquals(_cAT_PUNTO_MEDICION, value))
                {
                    var previousValue = _cAT_PUNTO_MEDICION;
                    _cAT_PUNTO_MEDICION = value;
                    FixupCAT_PUNTO_MEDICION(previousValue);
                }
            }
        }
        private CAT_PUNTO_MEDICION _cAT_PUNTO_MEDICION;

        #endregion

        #region Association Fixup
    
        private void FixupCAT_PUNTO_MEDICION(CAT_PUNTO_MEDICION previousValue)
        {
            if (previousValue != null && previousValue.CAT_PUNTO_MEDICION_MAX_MIN.Contains(this))
            {
                previousValue.CAT_PUNTO_MEDICION_MAX_MIN.Remove(this);
            }
    
            if (CAT_PUNTO_MEDICION != null)
            {
                if (!CAT_PUNTO_MEDICION.CAT_PUNTO_MEDICION_MAX_MIN.Contains(this))
                {
                    CAT_PUNTO_MEDICION.CAT_PUNTO_MEDICION_MAX_MIN.Add(this);
                }
                if (IdPuntoMedicion != CAT_PUNTO_MEDICION.IdPuntoMedicion)
                {
                    IdPuntoMedicion = CAT_PUNTO_MEDICION.IdPuntoMedicion;
                }
            }
        }

        #endregion

    }
}
