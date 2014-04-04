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
    public partial class CAT_ESTRUCTURA
    {
        #region Primitive Properties
    
        public virtual long IdEstructura
        {
            get;
            set;
        }
    
        public virtual string EstructuraName
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
    
        public virtual long IdSistema
        {
            get { return _idSistema; }
            set
            {
                if (_idSistema != value)
                {
                    if (CAT_SISTEMA != null && CAT_SISTEMA.IdSistema != value)
                    {
                        CAT_SISTEMA = null;
                    }
                    _idSistema = value;
                }
            }
        }
        private long _idSistema;

        #endregion
        #region Navigation Properties
    
        public virtual CAT_SISTEMA CAT_SISTEMA
        {
            get { return _cAT_SISTEMA; }
            set
            {
                if (!ReferenceEquals(_cAT_SISTEMA, value))
                {
                    var previousValue = _cAT_SISTEMA;
                    _cAT_SISTEMA = value;
                    FixupCAT_SISTEMA(previousValue);
                }
            }
        }
        private CAT_SISTEMA _cAT_SISTEMA;
    
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
    
        public virtual ICollection<REL_EST_PUNTOMED> REL_EST_PUNTOMED
        {
            get
            {
                if (_rEL_EST_PUNTOMED == null)
                {
                    var newCollection = new FixupCollection<REL_EST_PUNTOMED>();
                    newCollection.CollectionChanged += FixupREL_EST_PUNTOMED;
                    _rEL_EST_PUNTOMED = newCollection;
                }
                return _rEL_EST_PUNTOMED;
            }
            set
            {
                if (!ReferenceEquals(_rEL_EST_PUNTOMED, value))
                {
                    var previousValue = _rEL_EST_PUNTOMED as FixupCollection<REL_EST_PUNTOMED>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_EST_PUNTOMED;
                    }
                    _rEL_EST_PUNTOMED = value;
                    var newValue = value as FixupCollection<REL_EST_PUNTOMED>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_EST_PUNTOMED;
                    }
                }
            }
        }
        private ICollection<REL_EST_PUNTOMED> _rEL_EST_PUNTOMED;
    
        public virtual ICollection<REL_ESTRUCTURA_DEPENDENCIA> REL_ESTRUCTURA_DEPENDENCIA
        {
            get
            {
                if (_rEL_ESTRUCTURA_DEPENDENCIA == null)
                {
                    var newCollection = new FixupCollection<REL_ESTRUCTURA_DEPENDENCIA>();
                    newCollection.CollectionChanged += FixupREL_ESTRUCTURA_DEPENDENCIA;
                    _rEL_ESTRUCTURA_DEPENDENCIA = newCollection;
                }
                return _rEL_ESTRUCTURA_DEPENDENCIA;
            }
            set
            {
                if (!ReferenceEquals(_rEL_ESTRUCTURA_DEPENDENCIA, value))
                {
                    var previousValue = _rEL_ESTRUCTURA_DEPENDENCIA as FixupCollection<REL_ESTRUCTURA_DEPENDENCIA>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_ESTRUCTURA_DEPENDENCIA;
                    }
                    _rEL_ESTRUCTURA_DEPENDENCIA = value;
                    var newValue = value as FixupCollection<REL_ESTRUCTURA_DEPENDENCIA>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_ESTRUCTURA_DEPENDENCIA;
                    }
                }
            }
        }
        private ICollection<REL_ESTRUCTURA_DEPENDENCIA> _rEL_ESTRUCTURA_DEPENDENCIA;

        #endregion
        #region Association Fixup
    
        private void FixupCAT_SISTEMA(CAT_SISTEMA previousValue)
        {
            if (previousValue != null && previousValue.CAT_ESTRUCTURA.Contains(this))
            {
                previousValue.CAT_ESTRUCTURA.Remove(this);
            }
    
            if (CAT_SISTEMA != null)
            {
                if (!CAT_SISTEMA.CAT_ESTRUCTURA.Contains(this))
                {
                    CAT_SISTEMA.CAT_ESTRUCTURA.Add(this);
                }
                if (IdSistema != CAT_SISTEMA.IdSistema)
                {
                    IdSistema = CAT_SISTEMA.IdSistema;
                }
            }
        }
    
        private void FixupREL_ACCION_PROTOCOLO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_ACCION_PROTOCOLO item in e.NewItems)
                {
                    item.CAT_ESTRUCTURA = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_ACCION_PROTOCOLO item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_ESTRUCTURA, this))
                    {
                        item.CAT_ESTRUCTURA = null;
                    }
                }
            }
        }
    
        private void FixupREL_EST_PUNTOMED(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_EST_PUNTOMED item in e.NewItems)
                {
                    item.CAT_ESTRUCTURA = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_EST_PUNTOMED item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_ESTRUCTURA, this))
                    {
                        item.CAT_ESTRUCTURA = null;
                    }
                }
            }
        }
    
        private void FixupREL_ESTRUCTURA_DEPENDENCIA(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_ESTRUCTURA_DEPENDENCIA item in e.NewItems)
                {
                    item.CAT_ESTRUCTURA = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_ESTRUCTURA_DEPENDENCIA item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_ESTRUCTURA, this))
                    {
                        item.CAT_ESTRUCTURA = null;
                    }
                }
            }
        }

        #endregion
    }
}
