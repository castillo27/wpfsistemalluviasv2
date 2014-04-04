﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace Protell.Server.DAL.POCOS
{
    public partial class db_SeguimientoProtocolo_r2Entities : ObjectContext
    {
        public const string ConnectionString = "name=db_SeguimientoProtocolo_r2Entities";
        public const string ContainerName = "db_SeguimientoProtocolo_r2Entities";
    
        #region Constructors
    
        public db_SeguimientoProtocolo_r2Entities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public db_SeguimientoProtocolo_r2Entities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public db_SeguimientoProtocolo_r2Entities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<C_CAT_PUNTO_MEDICION> C_CAT_PUNTO_MEDICION
        {
            get { return _c_CAT_PUNTO_MEDICION  ?? (_c_CAT_PUNTO_MEDICION = CreateObjectSet<C_CAT_PUNTO_MEDICION>("C_CAT_PUNTO_MEDICION")); }
        }
        private ObjectSet<C_CAT_PUNTO_MEDICION> _c_CAT_PUNTO_MEDICION;
    
        public ObjectSet<APP_ROL> APP_ROL
        {
            get { return _aPP_ROL  ?? (_aPP_ROL = CreateObjectSet<APP_ROL>("APP_ROL")); }
        }
        private ObjectSet<APP_ROL> _aPP_ROL;
    
        public ObjectSet<APP_USUARIO> APP_USUARIO
        {
            get { return _aPP_USUARIO  ?? (_aPP_USUARIO = CreateObjectSet<APP_USUARIO>("APP_USUARIO")); }
        }
        private ObjectSet<APP_USUARIO> _aPP_USUARIO;
    
        public ObjectSet<APP_USUARIO_ROL> APP_USUARIO_ROL
        {
            get { return _aPP_USUARIO_ROL  ?? (_aPP_USUARIO_ROL = CreateObjectSet<APP_USUARIO_ROL>("APP_USUARIO_ROL")); }
        }
        private ObjectSet<APP_USUARIO_ROL> _aPP_USUARIO_ROL;
    
        public ObjectSet<CAT_CONDPRO> CAT_CONDPRO
        {
            get { return _cAT_CONDPRO  ?? (_cAT_CONDPRO = CreateObjectSet<CAT_CONDPRO>("CAT_CONDPRO")); }
        }
        private ObjectSet<CAT_CONDPRO> _cAT_CONDPRO;
    
        public ObjectSet<CAT_DEPENDENCIA> CAT_DEPENDENCIA
        {
            get { return _cAT_DEPENDENCIA  ?? (_cAT_DEPENDENCIA = CreateObjectSet<CAT_DEPENDENCIA>("CAT_DEPENDENCIA")); }
        }
        private ObjectSet<CAT_DEPENDENCIA> _cAT_DEPENDENCIA;
    
        public ObjectSet<CAT_ESTRUCTURA> CAT_ESTRUCTURA
        {
            get { return _cAT_ESTRUCTURA  ?? (_cAT_ESTRUCTURA = CreateObjectSet<CAT_ESTRUCTURA>("CAT_ESTRUCTURA")); }
        }
        private ObjectSet<CAT_ESTRUCTURA> _cAT_ESTRUCTURA;
    
        public ObjectSet<CAT_PUNTO_MEDICION> CAT_PUNTO_MEDICION
        {
            get { return _cAT_PUNTO_MEDICION  ?? (_cAT_PUNTO_MEDICION = CreateObjectSet<CAT_PUNTO_MEDICION>("CAT_PUNTO_MEDICION")); }
        }
        private ObjectSet<CAT_PUNTO_MEDICION> _cAT_PUNTO_MEDICION;
    
        public ObjectSet<CAT_PUNTO_MEDICION_MAX_MIN> CAT_PUNTO_MEDICION_MAX_MIN
        {
            get { return _cAT_PUNTO_MEDICION_MAX_MIN  ?? (_cAT_PUNTO_MEDICION_MAX_MIN = CreateObjectSet<CAT_PUNTO_MEDICION_MAX_MIN>("CAT_PUNTO_MEDICION_MAX_MIN")); }
        }
        private ObjectSet<CAT_PUNTO_MEDICION_MAX_MIN> _cAT_PUNTO_MEDICION_MAX_MIN;
    
        public ObjectSet<CAT_SERVER_LASTDATA> CAT_SERVER_LASTDATA
        {
            get { return _cAT_SERVER_LASTDATA  ?? (_cAT_SERVER_LASTDATA = CreateObjectSet<CAT_SERVER_LASTDATA>("CAT_SERVER_LASTDATA")); }
        }
        private ObjectSet<CAT_SERVER_LASTDATA> _cAT_SERVER_LASTDATA;
    
        public ObjectSet<CAT_SISTEMA> CAT_SISTEMA
        {
            get { return _cAT_SISTEMA  ?? (_cAT_SISTEMA = CreateObjectSet<CAT_SISTEMA>("CAT_SISTEMA")); }
        }
        private ObjectSet<CAT_SISTEMA> _cAT_SISTEMA;
    
        public ObjectSet<CAT_SYNC> CAT_SYNC
        {
            get { return _cAT_SYNC  ?? (_cAT_SYNC = CreateObjectSet<CAT_SYNC>("CAT_SYNC")); }
        }
        private ObjectSet<CAT_SYNC> _cAT_SYNC;
    
        public ObjectSet<CAT_TIPO_PUNTO_MEDICION> CAT_TIPO_PUNTO_MEDICION
        {
            get { return _cAT_TIPO_PUNTO_MEDICION  ?? (_cAT_TIPO_PUNTO_MEDICION = CreateObjectSet<CAT_TIPO_PUNTO_MEDICION>("CAT_TIPO_PUNTO_MEDICION")); }
        }
        private ObjectSet<CAT_TIPO_PUNTO_MEDICION> _cAT_TIPO_PUNTO_MEDICION;
    
        public ObjectSet<CAT_UNIDAD_MEDIDA> CAT_UNIDAD_MEDIDA
        {
            get { return _cAT_UNIDAD_MEDIDA  ?? (_cAT_UNIDAD_MEDIDA = CreateObjectSet<CAT_UNIDAD_MEDIDA>("CAT_UNIDAD_MEDIDA")); }
        }
        private ObjectSet<CAT_UNIDAD_MEDIDA> _cAT_UNIDAD_MEDIDA;
    
        public ObjectSet<CAT_UPLOAD_LOG> CAT_UPLOAD_LOG
        {
            get { return _cAT_UPLOAD_LOG  ?? (_cAT_UPLOAD_LOG = CreateObjectSet<CAT_UPLOAD_LOG>("CAT_UPLOAD_LOG")); }
        }
        private ObjectSet<CAT_UPLOAD_LOG> _cAT_UPLOAD_LOG;
    
        public ObjectSet<CI_REGISTRO> CI_REGISTRO
        {
            get { return _cI_REGISTRO  ?? (_cI_REGISTRO = CreateObjectSet<CI_REGISTRO>("CI_REGISTRO")); }
        }
        private ObjectSet<CI_REGISTRO> _cI_REGISTRO;
    
        public ObjectSet<REL_EST_PUNTOMED> REL_EST_PUNTOMED
        {
            get { return _rEL_EST_PUNTOMED  ?? (_rEL_EST_PUNTOMED = CreateObjectSet<REL_EST_PUNTOMED>("REL_EST_PUNTOMED")); }
        }
        private ObjectSet<REL_EST_PUNTOMED> _rEL_EST_PUNTOMED;
    
        public ObjectSet<REL_ESTRUCTURA_DEPENDENCIA> REL_ESTRUCTURA_DEPENDENCIA
        {
            get { return _rEL_ESTRUCTURA_DEPENDENCIA  ?? (_rEL_ESTRUCTURA_DEPENDENCIA = CreateObjectSet<REL_ESTRUCTURA_DEPENDENCIA>("REL_ESTRUCTURA_DEPENDENCIA")); }
        }
        private ObjectSet<REL_ESTRUCTURA_DEPENDENCIA> _rEL_ESTRUCTURA_DEPENDENCIA;
    
        public ObjectSet<CI_TRACKING> CI_TRACKING
        {
            get { return _cI_TRACKING  ?? (_cI_TRACKING = CreateObjectSet<CI_TRACKING>("CI_TRACKING")); }
        }
        private ObjectSet<CI_TRACKING> _cI_TRACKING;
    
        public ObjectSet<CAT_AGRUPADOR_ISOYETA> CAT_AGRUPADOR_ISOYETA
        {
            get { return _cAT_AGRUPADOR_ISOYETA  ?? (_cAT_AGRUPADOR_ISOYETA = CreateObjectSet<CAT_AGRUPADOR_ISOYETA>("CAT_AGRUPADOR_ISOYETA")); }
        }
        private ObjectSet<CAT_AGRUPADOR_ISOYETA> _cAT_AGRUPADOR_ISOYETA;
    
        public ObjectSet<CAT_LINKS> CAT_LINKS
        {
            get { return _cAT_LINKS  ?? (_cAT_LINKS = CreateObjectSet<CAT_LINKS>("CAT_LINKS")); }
        }
        private ObjectSet<CAT_LINKS> _cAT_LINKS;
    
        public ObjectSet<CAT_OPERACION_ESTRUCTURA> CAT_OPERACION_ESTRUCTURA
        {
            get { return _cAT_OPERACION_ESTRUCTURA  ?? (_cAT_OPERACION_ESTRUCTURA = CreateObjectSet<CAT_OPERACION_ESTRUCTURA>("CAT_OPERACION_ESTRUCTURA")); }
        }
        private ObjectSet<CAT_OPERACION_ESTRUCTURA> _cAT_OPERACION_ESTRUCTURA;
    
        public ObjectSet<MODIFIEDDATA> MODIFIEDDATAs
        {
            get { return _mODIFIEDDATAs  ?? (_mODIFIEDDATAs = CreateObjectSet<MODIFIEDDATA>("MODIFIEDDATAs")); }
        }
        private ObjectSet<MODIFIEDDATA> _mODIFIEDDATAs;
    
        public ObjectSet<SYNCTABLE> SYNCTABLEs
        {
            get { return _sYNCTABLEs  ?? (_sYNCTABLEs = CreateObjectSet<SYNCTABLE>("SYNCTABLEs")); }
        }
        private ObjectSet<SYNCTABLE> _sYNCTABLEs;

        #endregion

        #region Function Imports
        public ObjectResult<GdGetDatosEstructuras_Result> SpGdGetDatosEstructuras()
        {
            return base.ExecuteFunction<GdGetDatosEstructuras_Result>("SpGdGetDatosEstructuras");
        }
        public ObjectResult<SpGdGetDatosEstructuras2_Result> SpGdGetDatosEstructuras2()
        {
            return base.ExecuteFunction<SpGdGetDatosEstructuras2_Result>("SpGdGetDatosEstructuras2");
        }
        public ObjectResult<spSelectLastCI_Registro_Result> spSelectLastCI_Registro(string fechaActual, Nullable<long> idPuntoMedicion, Nullable<long> lMD, Nullable<long> sLMD, Nullable<int> dias)
        {
    
            ObjectParameter fechaActualParameter;
    
            if (fechaActual != null)
            {
                fechaActualParameter = new ObjectParameter("FechaActual", fechaActual);
            }
            else
            {
                fechaActualParameter = new ObjectParameter("FechaActual", typeof(string));
            }
    
            ObjectParameter idPuntoMedicionParameter;
    
            if (idPuntoMedicion.HasValue)
            {
                idPuntoMedicionParameter = new ObjectParameter("IdPuntoMedicion", idPuntoMedicion);
            }
            else
            {
                idPuntoMedicionParameter = new ObjectParameter("IdPuntoMedicion", typeof(long));
            }
    
            ObjectParameter lMDParameter;
    
            if (lMD.HasValue)
            {
                lMDParameter = new ObjectParameter("LMD", lMD);
            }
            else
            {
                lMDParameter = new ObjectParameter("LMD", typeof(long));
            }
    
            ObjectParameter sLMDParameter;
    
            if (sLMD.HasValue)
            {
                sLMDParameter = new ObjectParameter("SLMD", sLMD);
            }
            else
            {
                sLMDParameter = new ObjectParameter("SLMD", typeof(long));
            }
    
            ObjectParameter diasParameter;
    
            if (dias.HasValue)
            {
                diasParameter = new ObjectParameter("Dias", dias);
            }
            else
            {
                diasParameter = new ObjectParameter("Dias", typeof(int));
            }
            return base.ExecuteFunction<spSelectLastCI_Registro_Result>("spSelectLastCI_Registro", fechaActualParameter, idPuntoMedicionParameter, lMDParameter, sLMDParameter, diasParameter);
        }
        public ObjectResult<spDownloadCiRegistroOnDemand_Result> spDownloadCiRegistroOnDemand(Nullable<long> fechaActual, Nullable<long> idPuntoMedicion)
        {
    
            ObjectParameter fechaActualParameter;
    
            if (fechaActual.HasValue)
            {
                fechaActualParameter = new ObjectParameter("FechaActual", fechaActual);
            }
            else
            {
                fechaActualParameter = new ObjectParameter("FechaActual", typeof(long));
            }
    
            ObjectParameter idPuntoMedicionParameter;
    
            if (idPuntoMedicion.HasValue)
            {
                idPuntoMedicionParameter = new ObjectParameter("IdPuntoMedicion", idPuntoMedicion);
            }
            else
            {
                idPuntoMedicionParameter = new ObjectParameter("IdPuntoMedicion", typeof(long));
            }
            return base.ExecuteFunction<spDownloadCiRegistroOnDemand_Result>("spDownloadCiRegistroOnDemand", fechaActualParameter, idPuntoMedicionParameter);
        }
        public ObjectResult<spDownloadCiRegistroRecurrent_Result> spDownloadCiRegistroRecurrent(Nullable<long> fechaActual, Nullable<long> fechaFin, Nullable<long> sLMD, Nullable<long> lMD)
        {
    
            ObjectParameter fechaActualParameter;
    
            if (fechaActual.HasValue)
            {
                fechaActualParameter = new ObjectParameter("FechaActual", fechaActual);
            }
            else
            {
                fechaActualParameter = new ObjectParameter("FechaActual", typeof(long));
            }
    
            ObjectParameter fechaFinParameter;
    
            if (fechaFin.HasValue)
            {
                fechaFinParameter = new ObjectParameter("FechaFin", fechaFin);
            }
            else
            {
                fechaFinParameter = new ObjectParameter("FechaFin", typeof(long));
            }
    
            ObjectParameter sLMDParameter;
    
            if (sLMD.HasValue)
            {
                sLMDParameter = new ObjectParameter("SLMD", sLMD);
            }
            else
            {
                sLMDParameter = new ObjectParameter("SLMD", typeof(long));
            }
    
            ObjectParameter lMDParameter;
    
            if (lMD.HasValue)
            {
                lMDParameter = new ObjectParameter("LMD", lMD);
            }
            else
            {
                lMDParameter = new ObjectParameter("LMD", typeof(long));
            }
            return base.ExecuteFunction<spDownloadCiRegistroRecurrent_Result>("spDownloadCiRegistroRecurrent", fechaActualParameter, fechaFinParameter, sLMDParameter, lMDParameter);
        }

        #endregion

    }
}