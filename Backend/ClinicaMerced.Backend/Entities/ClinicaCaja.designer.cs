﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicaMerced.Common.Entities.Caja
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Clinica1")]
	public partial class ClinicaCajaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProfecional(Profecional instance);
    partial void UpdateProfecional(Profecional instance);
    partial void DeleteProfecional(Profecional instance);
    partial void InsertCierreCajaDiario(CierreCajaDiario instance);
    partial void UpdateCierreCajaDiario(CierreCajaDiario instance);
    partial void DeleteCierreCajaDiario(CierreCajaDiario instance);
    #endregion
		
		public ClinicaCajaDataContext() : 
				base(global::ClinicaMerced.Backend.Properties.Settings.Default.Clinica1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ClinicaCajaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClinicaCajaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClinicaCajaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClinicaCajaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Profecional> Profecionals
		{
			get
			{
				return this.GetTable<Profecional>();
			}
		}
		
		public System.Data.Linq.Table<CierreCajaDiario> CierreCajaDiarios
		{
			get
			{
				return this.GetTable<CierreCajaDiario>();
			}
		}
		
		public System.Data.Linq.Table<vw_ConsultaToCierreCajaDetail> vw_ConsultaToCierreCajaDetails
		{
			get
			{
				return this.GetTable<vw_ConsultaToCierreCajaDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Profecional")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Profecional : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdProfecional;
		
		private string _Nombre;
		
		private System.Nullable<int> _IdEspecialidad;
		
		private System.Nullable<System.Guid> _UserId;
		
		private string _Apellido;
		
		private System.Nullable<int> _IdTipoProfecional;
		
		private EntitySet<CierreCajaDiario> _CierreCajaDiarios;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdProfecionalChanging(int value);
    partial void OnIdProfecionalChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnIdEspecialidadChanging(System.Nullable<int> value);
    partial void OnIdEspecialidadChanged();
    partial void OnUserIdChanging(System.Nullable<System.Guid> value);
    partial void OnUserIdChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnIdTipoProfecionalChanging(System.Nullable<int> value);
    partial void OnIdTipoProfecionalChanged();
    #endregion
		
		public Profecional()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProfecional", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int IdProfecional
		{
			get
			{
				return this._IdProfecional;
			}
			set
			{
				if ((this._IdProfecional != value))
				{
					this.OnIdProfecionalChanging(value);
					this.SendPropertyChanging();
					this._IdProfecional = value;
					this.SendPropertyChanged("IdProfecional");
					this.OnIdProfecionalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEspecialidad", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.Nullable<int> IdEspecialidad
		{
			get
			{
				return this._IdEspecialidad;
			}
			set
			{
				if ((this._IdEspecialidad != value))
				{
					this.OnIdEspecialidadChanging(value);
					this.SendPropertyChanging();
					this._IdEspecialidad = value;
					this.SendPropertyChanged("IdEspecialidad");
					this.OnIdEspecialidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="UniqueIdentifier")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Nullable<System.Guid> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(20)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoProfecional", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public System.Nullable<int> IdTipoProfecional
		{
			get
			{
				return this._IdTipoProfecional;
			}
			set
			{
				if ((this._IdTipoProfecional != value))
				{
					this.OnIdTipoProfecionalChanging(value);
					this.SendPropertyChanging();
					this._IdTipoProfecional = value;
					this.SendPropertyChanged("IdTipoProfecional");
					this.OnIdTipoProfecionalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Profecional_CierreCajaDiario", Storage="_CierreCajaDiarios", ThisKey="IdProfecional", OtherKey="IdProfecional")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7, EmitDefaultValue=false)]
		public EntitySet<CierreCajaDiario> CierreCajaDiarios
		{
			get
			{
				if ((this.serializing 
							&& (this._CierreCajaDiarios.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._CierreCajaDiarios;
			}
			set
			{
				this._CierreCajaDiarios.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CierreCajaDiarios(CierreCajaDiario entity)
		{
			this.SendPropertyChanging();
			entity.Profecional = this;
		}
		
		private void detach_CierreCajaDiarios(CierreCajaDiario entity)
		{
			this.SendPropertyChanging();
			entity.Profecional = null;
		}
		
		private void Initialize()
		{
			this._CierreCajaDiarios = new EntitySet<CierreCajaDiario>(new Action<CierreCajaDiario>(this.attach_CierreCajaDiarios), new Action<CierreCajaDiario>(this.detach_CierreCajaDiarios));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CierreCajaDiario")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class CierreCajaDiario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		private System.Nullable<int> _IdProfecional;
		
		private System.Nullable<decimal> _Coseguro;
		
		private System.Nullable<decimal> _Arancel;
		
		private System.Nullable<int> _IdTipoIngreso;
		
		private string _UserName;
		
		private EntityRef<CierreCajaDiario> _CierreCajaDiario2;
		
		private EntityRef<CierreCajaDiario> _CierreCajaDiario1;
		
		private EntityRef<Profecional> _Profecional;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFechaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaChanged();
    partial void OnIdProfecionalChanging(System.Nullable<int> value);
    partial void OnIdProfecionalChanged();
    partial void OnCoseguroChanging(System.Nullable<decimal> value);
    partial void OnCoseguroChanged();
    partial void OnArancelChanging(System.Nullable<decimal> value);
    partial void OnArancelChanged();
    partial void OnIdTipoIngresoChanging(System.Nullable<int> value);
    partial void OnIdTipoIngresoChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    #endregion
		
		public CierreCajaDiario()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._CierreCajaDiario1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProfecional", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.Nullable<int> IdProfecional
		{
			get
			{
				return this._IdProfecional;
			}
			set
			{
				if ((this._IdProfecional != value))
				{
					if (this._Profecional.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdProfecionalChanging(value);
					this.SendPropertyChanging();
					this._IdProfecional = value;
					this.SendPropertyChanged("IdProfecional");
					this.OnIdProfecionalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coseguro", DbType="Decimal(18,0)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Nullable<decimal> Coseguro
		{
			get
			{
				return this._Coseguro;
			}
			set
			{
				if ((this._Coseguro != value))
				{
					this.OnCoseguroChanging(value);
					this.SendPropertyChanging();
					this._Coseguro = value;
					this.SendPropertyChanged("Coseguro");
					this.OnCoseguroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Arancel", DbType="Decimal(18,0)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.Nullable<decimal> Arancel
		{
			get
			{
				return this._Arancel;
			}
			set
			{
				if ((this._Arancel != value))
				{
					this.OnArancelChanging(value);
					this.SendPropertyChanging();
					this._Arancel = value;
					this.SendPropertyChanged("Arancel");
					this.OnArancelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoIngreso", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public System.Nullable<int> IdTipoIngreso
		{
			get
			{
				return this._IdTipoIngreso;
			}
			set
			{
				if ((this._IdTipoIngreso != value))
				{
					this.OnIdTipoIngresoChanging(value);
					this.SendPropertyChanging();
					this._IdTipoIngreso = value;
					this.SendPropertyChanged("IdTipoIngreso");
					this.OnIdTipoIngresoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CierreCajaDiario_CierreCajaDiario", Storage="_CierreCajaDiario2", ThisKey="Id", OtherKey="Id", IsUnique=true, IsForeignKey=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8, EmitDefaultValue=false)]
		public CierreCajaDiario CierreCajaDiario2
		{
			get
			{
				if ((this.serializing 
							&& (this._CierreCajaDiario2.HasLoadedOrAssignedValue == false)))
				{
					return null;
				}
				return this._CierreCajaDiario2.Entity;
			}
			set
			{
				CierreCajaDiario previousValue = this._CierreCajaDiario2.Entity;
				if (((previousValue != value) 
							|| (this._CierreCajaDiario2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CierreCajaDiario2.Entity = null;
						previousValue.CierreCajaDiario1 = null;
					}
					this._CierreCajaDiario2.Entity = value;
					if ((value != null))
					{
						value.CierreCajaDiario1 = this;
					}
					this.SendPropertyChanged("CierreCajaDiario2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CierreCajaDiario_CierreCajaDiario", Storage="_CierreCajaDiario1", ThisKey="Id", OtherKey="Id", IsForeignKey=true)]
		public CierreCajaDiario CierreCajaDiario1
		{
			get
			{
				return this._CierreCajaDiario1.Entity;
			}
			set
			{
				CierreCajaDiario previousValue = this._CierreCajaDiario1.Entity;
				if (((previousValue != value) 
							|| (this._CierreCajaDiario1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CierreCajaDiario1.Entity = null;
						previousValue.CierreCajaDiario2 = null;
					}
					this._CierreCajaDiario1.Entity = value;
					if ((value != null))
					{
						value.CierreCajaDiario2 = this;
						this._Id = value.Id;
					}
					else
					{
						this._Id = default(int);
					}
					this.SendPropertyChanged("CierreCajaDiario1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Profecional_CierreCajaDiario", Storage="_Profecional", ThisKey="IdProfecional", OtherKey="IdProfecional", IsForeignKey=true)]
		public Profecional Profecional
		{
			get
			{
				return this._Profecional.Entity;
			}
			set
			{
				Profecional previousValue = this._Profecional.Entity;
				if (((previousValue != value) 
							|| (this._Profecional.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Profecional.Entity = null;
						previousValue.CierreCajaDiarios.Remove(this);
					}
					this._Profecional.Entity = value;
					if ((value != null))
					{
						value.CierreCajaDiarios.Add(this);
						this._IdProfecional = value.IdProfecional;
					}
					else
					{
						this._IdProfecional = default(Nullable<int>);
					}
					this.SendPropertyChanged("Profecional");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._CierreCajaDiario2 = default(EntityRef<CierreCajaDiario>);
			this._CierreCajaDiario1 = default(EntityRef<CierreCajaDiario>);
			this._Profecional = default(EntityRef<Profecional>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vw_ConsultaToCierreCajaDetails")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class vw_ConsultaToCierreCajaDetail
	{
		
		private System.Nullable<int> _IdTipoConsulta;
		
		private System.Nullable<int> _IdProfecional;
		
		private System.DateTime _Fecha;
		
		private string _NombreProfecional;
		
		private string _TipoProfecional;
		
		private string _NombreTipoConsulta;
		
		private System.Nullable<decimal> _Coseguro;
		
		private System.Nullable<decimal> _ArancelMutual;
		
		private System.Nullable<int> _IdIipoProfecional;
		
		private string _Descripcion;
		
		private string _NombreCliente;
		
		private System.Nullable<bool> _PresentaOrden;
		
		private string _UserName;
		
		private System.Nullable<bool> _ExigeCoseguro;
		
		public vw_ConsultaToCierreCajaDetail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoConsulta", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public System.Nullable<int> IdTipoConsulta
		{
			get
			{
				return this._IdTipoConsulta;
			}
			set
			{
				if ((this._IdTipoConsulta != value))
				{
					this._IdTipoConsulta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProfecional", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Nullable<int> IdProfecional
		{
			get
			{
				return this._IdProfecional;
			}
			set
			{
				if ((this._IdProfecional != value))
				{
					this._IdProfecional = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.DateTime Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreProfecional", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string NombreProfecional
		{
			get
			{
				return this._NombreProfecional;
			}
			set
			{
				if ((this._NombreProfecional != value))
				{
					this._NombreProfecional = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoProfecional", DbType="NChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string TipoProfecional
		{
			get
			{
				return this._TipoProfecional;
			}
			set
			{
				if ((this._TipoProfecional != value))
				{
					this._TipoProfecional = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreTipoConsulta", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string NombreTipoConsulta
		{
			get
			{
				return this._NombreTipoConsulta;
			}
			set
			{
				if ((this._NombreTipoConsulta != value))
				{
					this._NombreTipoConsulta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coseguro", DbType="Decimal(18,0)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public System.Nullable<decimal> Coseguro
		{
			get
			{
				return this._Coseguro;
			}
			set
			{
				if ((this._Coseguro != value))
				{
					this._Coseguro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArancelMutual", DbType="Decimal(18,0)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public System.Nullable<decimal> ArancelMutual
		{
			get
			{
				return this._ArancelMutual;
			}
			set
			{
				if ((this._ArancelMutual != value))
				{
					this._ArancelMutual = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdIipoProfecional", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public System.Nullable<int> IdIipoProfecional
		{
			get
			{
				return this._IdIipoProfecional;
			}
			set
			{
				if ((this._IdIipoProfecional != value))
				{
					this._IdIipoProfecional = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(1000)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCliente", DbType="VarChar(80)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=11)]
		public string NombreCliente
		{
			get
			{
				return this._NombreCliente;
			}
			set
			{
				if ((this._NombreCliente != value))
				{
					this._NombreCliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PresentaOrden", DbType="Bit")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=12)]
		public System.Nullable<bool> PresentaOrden
		{
			get
			{
				return this._PresentaOrden;
			}
			set
			{
				if ((this._PresentaOrden != value))
				{
					this._PresentaOrden = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=13)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExigeCoseguro", DbType="Bit")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=14)]
		public System.Nullable<bool> ExigeCoseguro
		{
			get
			{
				return this._ExigeCoseguro;
			}
			set
			{
				if ((this._ExigeCoseguro != value))
				{
					this._ExigeCoseguro = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
