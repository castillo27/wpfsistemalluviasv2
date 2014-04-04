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
    public partial class CI_TRACKING
    {
        #region Primitive Properties
    
        public virtual long IdTracking
        {
            get;
            set;
        }
    
        public virtual string Accion
        {
            get;
            set;
        }
    
        public virtual string Valor
        {
            get;
            set;
        }
    
        public virtual string Ip
        {
            get;
            set;
        }
    
        public virtual string Equipo
        {
            get;
            set;
        }
    
        public virtual string Ubicacion
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdRegistro
        {
            get { return _idRegistro; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idRegistro != value)
                    {
                        if (CI_REGISTRO != null && CI_REGISTRO.IdRegistro != value)
                        {
                            CI_REGISTRO = null;
                        }
                        _idRegistro = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idRegistro;
    
        public virtual Nullable<long> IdUsuario
        {
            get { return _idUsuario; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idUsuario != value)
                    {
                        if (APP_USUARIO != null && APP_USUARIO.IdUsuario != value)
                        {
                            APP_USUARIO = null;
                        }
                        _idUsuario = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idUsuario;
    
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

        #endregion

        #region Navigation Properties
    
        public virtual APP_USUARIO APP_USUARIO
        {
            get { return _aPP_USUARIO; }
            set
            {
                if (!ReferenceEquals(_aPP_USUARIO, value))
                {
                    var previousValue = _aPP_USUARIO;
                    _aPP_USUARIO = value;
                    FixupAPP_USUARIO(previousValue);
                }
            }
        }
        private APP_USUARIO _aPP_USUARIO;
    
        public virtual CI_REGISTRO CI_REGISTRO
        {
            get { return _cI_REGISTRO; }
            set
            {
                if (!ReferenceEquals(_cI_REGISTRO, value))
                {
                    var previousValue = _cI_REGISTRO;
                    _cI_REGISTRO = value;
                    FixupCI_REGISTRO(previousValue);
                }
            }
        }
        private CI_REGISTRO _cI_REGISTRO;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupAPP_USUARIO(APP_USUARIO previousValue)
        {
            if (previousValue != null && previousValue.CI_TRACKING.Contains(this))
            {
                previousValue.CI_TRACKING.Remove(this);
            }
    
            if (APP_USUARIO != null)
            {
                if (!APP_USUARIO.CI_TRACKING.Contains(this))
                {
                    APP_USUARIO.CI_TRACKING.Add(this);
                }
                if (IdUsuario != APP_USUARIO.IdUsuario)
                {
                    IdUsuario = APP_USUARIO.IdUsuario;
                }
            }
            else if (!_settingFK)
            {
                IdUsuario = null;
            }
        }
    
        private void FixupCI_REGISTRO(CI_REGISTRO previousValue)
        {
            if (previousValue != null && previousValue.CI_TRACKING.Contains(this))
            {
                previousValue.CI_TRACKING.Remove(this);
            }
    
            if (CI_REGISTRO != null)
            {
                if (!CI_REGISTRO.CI_TRACKING.Contains(this))
                {
                    CI_REGISTRO.CI_TRACKING.Add(this);
                }
                if (IdRegistro != CI_REGISTRO.IdRegistro)
                {
                    IdRegistro = CI_REGISTRO.IdRegistro;
                }
            }
            else if (!_settingFK)
            {
                IdRegistro = null;
            }
        }

        #endregion

    }
}
