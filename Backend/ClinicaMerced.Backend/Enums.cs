using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Backend.DAC;
using System.Drawing;

namespace ClinicaMerced.Common.Enums
{
    
    public static class Constants
    {
        public static Color FOCUSED_BACK_COLOR = System.Drawing.Color.FromArgb(255, 255, 192);
    }
    public enum CommonValuesEnum
    {
        TodosComboBoxValue = -1000,
        VariosComboBoxValue = -2000,
        SeleccioneUnaOpcion = -3000,
        Ninguno = -4000
    }
    public enum TipoParametroEnum
    {
        TipoIngreso = 1,
        ClaseTipoGasto = 2,
        FormaPago = 14,
        TipoGasto = 20


    }

    public enum TipoConsulta
    {
        ConsultaMedica = 200,
        Recetario = 201,
        Practica = 203,
        Geriatrico  = 204
    }
    public enum TipoProfecional
    {
        Externo = 301,
        Alquiler = 302,
        Propietario =303	                                           
    }

    public enum TipoIngresoCaja
    {
        Rezeta = 401,
        ProfecionalMedico = 402,
        Alquiler = 403
    }

    public enum Meses
    {
        Enero = 1,
        Febrero = 2,
        Marzo = 3, Abril = 4, Mayo = 5, Junio = 6, Julio = 7, Agosto = 8,
        Septiembre = 9,
        Octubre = 10,
        Noviembre = 11,
        Diciembre = 12

    }
}
