﻿
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

namespace ClinicaMerced.Common.Entities.Angel
{
	
	[XmlRoot("patientList"), SerializableAttribute]
    public class PatientList : Entities<Patient>
	{}
	
	[XmlInclude(typeof(Patient)), Serializable]
	public class Patient:Entity
	{
		#region [Private Members]
		private System.Int32 _id1;

		private System.Int32 _id2;

		private System.String _last_name;

		private System.String _first_name;

		private System.String _sex;

		private System.DateTime? _birth;

		private System.DateTime? _death;

		private System.Int32? _marital_status;

		private System.String _cuil;

		private System.String _tin;

		private System.String _occupation;

		private System.String _title;

		private System.Int32? _patient_medins_default_plan_id;

		private System.String _home_addy;

		private System.String _home_city;

		private System.String _home_zip_code;

		private System.String _home_phone;

		private System.String _home_email;

		private System.Int32? _home_province_id;

		private System.String _home_province_name;

		private System.Int32? _home_country_id;

		private System.String _business_addy;

		private System.String _business_zip_code;

		private System.String _business_phone;

		private System.String _business_email;

		private System.String _business_city;

		private System.Int32? _business_province_id;

		private System.String _business_province_name;

		private System.Int32? _business_country_id;

		private System.String _relative_first_name;

		private System.String _relative_last_name;

		private System.String _relative_linkage;

		private System.Int32? _relative_id1;

		private System.Int32? _relative_id2;

		private System.String _relative_addy;

		private System.String _relative_zip_code;

		private System.String _relative_phone;

		private System.String _relative_email;

		private System.String _relative_city;

		private System.Int32? _relative_province_id;

		private System.String _relative_province_name;

		private System.Int32? _relative_country_id;

		private System.String _notes;

		private System.Byte[] _extra;


		#endregion
		
		#region [Properties]
		#region [id1]
		public System.Int32 id1
		{
			get { return _id1; }
			set { _id1 = value;}
		}
		#endregion


		#region [id2]
		public System.Int32 id2
		{
			get { return _id2; }
			set { _id2 = value;}
		}
		#endregion


		#region [last_name]
		public System.String last_name
		{
			get { return _last_name; }
			set { _last_name = value;}
		}
		#endregion


		#region [first_name]
		public System.String first_name
		{
			get { return _first_name; }
			set { _first_name = value;}
		}

        public System.String full_name
        {
            get { return string.Concat(_last_name, ", ",_first_name); }
        }
		#endregion


		#region [sex]
		public System.String sex
		{
			get { return _sex; }
			set { _sex = value;}
		}
		#endregion


		#region [birth]
		public System.DateTime? birth
		{
			get { return _birth; }
			set { _birth = value;}
		}
		#endregion


		#region [death]
		public System.DateTime? death
		{
			get { return _death; }
			set { _death = value;}
		}
		#endregion


		#region [marital_status]
		public System.Int32? marital_status
		{
			get { return _marital_status; }
			set { _marital_status = value;}
		}
		#endregion


		#region [cuil]
		public System.String cuil
		{
			get { return _cuil; }
			set { _cuil = value;}
		}
		#endregion


		#region [tin]
		public System.String tin
		{
			get { return _tin; }
			set { _tin = value;}
		}
		#endregion


		#region [occupation]
		public System.String occupation
		{
			get { return _occupation; }
			set { _occupation = value;}
		}
		#endregion


		#region [title]
		public System.String title
		{
			get { return _title; }
			set { _title = value;}
		}
		#endregion


		#region [patient_medins_default_plan_id]
		public System.Int32? patient_medins_default_plan_id
		{
			get { return _patient_medins_default_plan_id; }
			set { _patient_medins_default_plan_id = value;}
		}
		#endregion


		#region [home_addy]
		public System.String home_addy
		{
			get { return _home_addy; }
			set { _home_addy = value;}
		}
		#endregion


		#region [home_city]
		public System.String home_city
		{
			get { return _home_city; }
			set { _home_city = value;}
		}
		#endregion


		#region [home_zip_code]
		public System.String home_zip_code
		{
			get { return _home_zip_code; }
			set { _home_zip_code = value;}
		}
		#endregion


		#region [home_phone]
		public System.String home_phone
		{
			get { return _home_phone; }
			set { _home_phone = value;}
		}
		#endregion


		#region [home_email]
		public System.String home_email
		{
			get { return _home_email; }
			set { _home_email = value;}
		}
		#endregion


		#region [home_province_id]
		public System.Int32? home_province_id
		{
			get { return _home_province_id; }
			set { _home_province_id = value;}
		}
		#endregion


		#region [home_province_name]
		public System.String home_province_name
		{
			get { return _home_province_name; }
			set { _home_province_name = value;}
		}
		#endregion


		#region [home_country_id]
		public System.Int32? home_country_id
		{
			get { return _home_country_id; }
			set { _home_country_id = value;}
		}
		#endregion


		#region [business_addy]
		public System.String business_addy
		{
			get { return _business_addy; }
			set { _business_addy = value;}
		}
		#endregion


		#region [business_zip_code]
		public System.String business_zip_code
		{
			get { return _business_zip_code; }
			set { _business_zip_code = value;}
		}
		#endregion


		#region [business_phone]
		public System.String business_phone
		{
			get { return _business_phone; }
			set { _business_phone = value;}
		}
		#endregion


		#region [business_email]
		public System.String business_email
		{
			get { return _business_email; }
			set { _business_email = value;}
		}
		#endregion


		#region [business_city]
		public System.String business_city
		{
			get { return _business_city; }
			set { _business_city = value;}
		}
		#endregion


		#region [business_province_id]
		public System.Int32? business_province_id
		{
			get { return _business_province_id; }
			set { _business_province_id = value;}
		}
		#endregion


		#region [business_province_name]
		public System.String business_province_name
		{
			get { return _business_province_name; }
			set { _business_province_name = value;}
		}
		#endregion


		#region [business_country_id]
		public System.Int32? business_country_id
		{
			get { return _business_country_id; }
			set { _business_country_id = value;}
		}
		#endregion


		#region [relative_first_name]
		public System.String relative_first_name
		{
			get { return _relative_first_name; }
			set { _relative_first_name = value;}
		}
		#endregion


		#region [relative_last_name]
		public System.String relative_last_name
		{
			get { return _relative_last_name; }
			set { _relative_last_name = value;}
		}
		#endregion


		#region [relative_linkage]
		public System.String relative_linkage
		{
			get { return _relative_linkage; }
			set { _relative_linkage = value;}
		}
		#endregion


		#region [relative_id1]
		public System.Int32? relative_id1
		{
			get { return _relative_id1; }
			set { _relative_id1 = value;}
		}
		#endregion


		#region [relative_id2]
		public System.Int32? relative_id2
		{
			get { return _relative_id2; }
			set { _relative_id2 = value;}
		}
		#endregion


		#region [relative_addy]
		public System.String relative_addy
		{
			get { return _relative_addy; }
			set { _relative_addy = value;}
		}
		#endregion


		#region [relative_zip_code]
		public System.String relative_zip_code
		{
			get { return _relative_zip_code; }
			set { _relative_zip_code = value;}
		}
		#endregion


		#region [relative_phone]
		public System.String relative_phone
		{
			get { return _relative_phone; }
			set { _relative_phone = value;}
		}
		#endregion


		#region [relative_email]
		public System.String relative_email
		{
			get { return _relative_email; }
			set { _relative_email = value;}
		}
		#endregion


		#region [relative_city]
		public System.String relative_city
		{
			get { return _relative_city; }
			set { _relative_city = value;}
		}
		#endregion


		#region [relative_province_id]
		public System.Int32? relative_province_id
		{
			get { return _relative_province_id; }
			set { _relative_province_id = value;}
		}
		#endregion


		#region [relative_province_name]
		public System.String relative_province_name
		{
			get { return _relative_province_name; }
			set { _relative_province_name = value;}
		}
		#endregion


		#region [relative_country_id]
		public System.Int32? relative_country_id
		{
			get { return _relative_country_id; }
			set { _relative_country_id = value;}
		}
		#endregion


		#region [notes]
		public System.String notes
		{
			get { return _notes; }
			set { _notes = value;}
		}
		#endregion


		#region [extra]
        [System.Xml.Serialization.XmlElementAttribute("extra", DataType = "base64Binary")]
		public Byte[] extra
		{
			get { return _extra; }
			set { _extra = value;  }
		}
		#endregion
		


		#endregion
		
	}
	

}



