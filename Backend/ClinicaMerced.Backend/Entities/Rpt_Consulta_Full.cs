//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a allus Code Generator.
//     Runtime Version: 1.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Fwk.Bases;

namespace ClinicaMerced.Common.Entities.x
{

    [XmlRoot("Rpt_Consulta_FullList"), SerializableAttribute]
    public class Rpt_Consulta_FullList : Entities<Rpt_Consulta_Full>
    { }

    [XmlInclude(typeof(Rpt_Consulta_Full)), Serializable]
    public class Rpt_Consulta_Full : Entity
    {
        #region [Private Members]
        private System.Int32? _IdProfecional;

        private System.Int32? _IdMutual;

        private System.DateTime _Fecha;

        private System.Boolean? _PresentaOrden;

        private System.Decimal? _Coseguro;

        private System.Boolean? _ExigeCoseguro;

        private System.Decimal? _ArancelMutual;

        private System.Int32? _IdTipoConsulta;

        private System.String _TipoConsulta;

        private System.String _Profecional;

        private System.String _Consulta;


        #endregion

        #region [Properties]
        #region [IdProfecional]
        public System.Int32? IdProfecional
        {
            get { return _IdProfecional; }
            set { _IdProfecional = value; }
        }
        #endregion


        #region [IdMutual]
        public System.Int32? IdMutual
        {
            get { return _IdMutual; }
            set { _IdMutual = value; }
        }
        #endregion


        #region [Fecha]
        public System.DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        #endregion


        #region [PresentaOrden]
        public System.Boolean? PresentaOrden
        {
            get { return _PresentaOrden; }
            set { _PresentaOrden = value; }
        }
        #endregion


        #region [Coseguro]
        public System.Decimal? Coseguro
        {
            get { return _Coseguro; }
            set { _Coseguro = value; }
        }
        #endregion


        #region [ExigeCoseguro]
        public System.Boolean? ExigeCoseguro
        {
            get { return _ExigeCoseguro; }
            set { _ExigeCoseguro = value; }
        }
        #endregion


        #region [ArancelMutual]
        public System.Decimal? ArancelMutual
        {
            get { return _ArancelMutual; }
            set { _ArancelMutual = value; }
        }
        #endregion


        #region [IdTipoConsulta]
        public System.Int32? IdTipoConsulta
        {
            get { return _IdTipoConsulta; }
            set { _IdTipoConsulta = value; }
        }
        #endregion


        #region [TipoConsulta]
        public System.String TipoConsulta
        {
            get { return _TipoConsulta; }
            set { _TipoConsulta = value; }
        }
        #endregion


        #region [Profecional]
        public System.String Profecional
        {
            get { return _Profecional; }
            set { _Profecional = value; }
        }
        #endregion


        #region [Consulta]
        public System.String Consulta
        {
            get { return _Consulta; }
            set { _Consulta = value; }
        }
        #endregion



        #endregion

    }


}
         

   
