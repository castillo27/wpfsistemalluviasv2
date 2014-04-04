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

namespace Protell.DAL
{
    public partial class CAT_CONDPRO
    {
        #region Primitive Properties
    
        public virtual long IdCondicion
        {
            get;
            set;
        }
    
        public virtual string CondicionName
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

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<CAT_CONSIDERACION> CAT_CONSIDERACION
        {
            get
            {
                if (_cAT_CONSIDERACION == null)
                {
                    var newCollection = new FixupCollection<CAT_CONSIDERACION>();
                    newCollection.CollectionChanged += FixupCAT_CONSIDERACION;
                    _cAT_CONSIDERACION = newCollection;
                }
                return _cAT_CONSIDERACION;
            }
            set
            {
                if (!ReferenceEquals(_cAT_CONSIDERACION, value))
                {
                    var previousValue = _cAT_CONSIDERACION as FixupCollection<CAT_CONSIDERACION>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCAT_CONSIDERACION;
                    }
                    _cAT_CONSIDERACION = value;
                    var newValue = value as FixupCollection<CAT_CONSIDERACION>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCAT_CONSIDERACION;
                    }
                }
            }
        }
        private ICollection<CAT_CONSIDERACION> _cAT_CONSIDERACION;
    
        public virtual ICollection<REL_ACCION_PROTOCOLO> REL_ACCION_PROTOCOLO
        {
            get
            {
                if (_rEL_ACCION_PROTOCOLO == null)
                {
                    var newCollection = new FixupCollection<REL_ACCION_PROTOCOLO>();
                    newCollection.CollectionChanged += FixupREL_ACCION_PROTOCOLO;
                    _rEL_ACCION_PROTOCOLO = newCollection;
                }
                return _rEL_ACCION_PROTOCOLO;
            }
            set
            {
                if (!ReferenceEquals(_rEL_ACCION_PROTOCOLO, value))
                {
                    var previousValue = _rEL_ACCION_PROTOCOLO as FixupCollection<REL_ACCION_PROTOCOLO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_ACCION_PROTOCOLO;
                    }
                    _rEL_ACCION_PROTOCOLO = value;
                    var newValue = value as FixupCollection<REL_ACCION_PROTOCOLO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_ACCION_PROTOCOLO;
                    }
                }
            }
        }
        private ICollection<REL_ACCION_PROTOCOLO> _rEL_ACCION_PROTOCOLO;

        #endregion
        #region Association Fixup
    
        private void FixupCAT_CONSIDERACION(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CAT_CONSIDERACION item in e.NewItems)
                {
                    item.CAT_CONDPRO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CAT_CONSIDERACION item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_CONDPRO, this))
                    {
                        item.CAT_CONDPRO = null;
                    }
                }
            }
        }
    
        private void FixupREL_ACCION_PROTOCOLO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_ACCION_PROTOCOLO item in e.NewItems)
                {
                    item.CAT_CONDPRO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_ACCION_PROTOCOLO item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_CONDPRO, this))
                    {
                        item.CAT_CONDPRO = null;
                    }
                }
            }
        }

        #endregion
    }
}