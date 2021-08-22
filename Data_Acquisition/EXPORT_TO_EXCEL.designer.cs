﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Acquisition1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DAQ")]
	public partial class EXPORT_TO_EXCELDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertVARIABLE_DAQ(VARIABLE_DAQ instance);
    partial void UpdateVARIABLE_DAQ(VARIABLE_DAQ instance);
    partial void DeleteVARIABLE_DAQ(VARIABLE_DAQ instance);
    partial void InsertDAILY(DAILY instance);
    partial void UpdateDAILY(DAILY instance);
    partial void DeleteDAILY(DAILY instance);
    #endregion
		
		public EXPORT_TO_EXCELDataContext() : 
				base(global::Data_Acquisition1.Properties.Settings.Default.DAQConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EXPORT_TO_EXCELDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EXPORT_TO_EXCELDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EXPORT_TO_EXCELDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EXPORT_TO_EXCELDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VARIABLE_DAQ> VARIABLE_DAQs
		{
			get
			{
				return this.GetTable<VARIABLE_DAQ>();
			}
		}
		
		public System.Data.Linq.Table<DAILY> DAILies
		{
			get
			{
				return this.GetTable<DAILY>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VARIABLE_DAQ")]
	public partial class VARIABLE_DAQ : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _DATE_TIME;
		
		private string _FREQUENCY_RICH;
		
		private string _CURRENT_RICH;
		
		private string _FREQUENCY_DELTA;
		
		private string _CURRENT_DELTA;
		
		private string _TYPE_OF_PRODUCT;
		
		private string _QUALITY_PRODUCT;
		
		private string _ERROR_PRODUCT;
		
		private string _CHIEU_DAI_SPLOI;
		
		private string _DUONG_KINH_ONG;
		
		private string _BE_DAY;
		
		private string _CHIEU_DAI_CAT;
		
		private string _MOTOR_SPEED;
		
		private string _DC_VOLT;
		
		private string _DC_AMPE;
		
		private string _HEATER_9;
		
		private string _HEATER_1_3;
		
		private string _HEATER_2;
		
		private string _HEATER_8_10;
		
		private string _ZONE_1B_2B;
		
		private string _ZONE_3B_4B;
		
		private string _ZONE_1A_2A;
		
		private string _ZONE_3A_4A;
		
		private string _LOSAY_CAO_TREN;
		
		private string _LOSAY_CAO_DUOI;
		
		private string _LOSAY_THAP_TREN;
		
		private string _LOSAY_THAP_DUOI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDATE_TIMEChanging(string value);
    partial void OnDATE_TIMEChanged();
    partial void OnFREQUENCY_RICHChanging(string value);
    partial void OnFREQUENCY_RICHChanged();
    partial void OnCURRENT_RICHChanging(string value);
    partial void OnCURRENT_RICHChanged();
    partial void OnFREQUENCY_DELTAChanging(string value);
    partial void OnFREQUENCY_DELTAChanged();
    partial void OnCURRENT_DELTAChanging(string value);
    partial void OnCURRENT_DELTAChanged();
    partial void OnTYPE_OF_PRODUCTChanging(string value);
    partial void OnTYPE_OF_PRODUCTChanged();
    partial void OnQUALITY_PRODUCTChanging(string value);
    partial void OnQUALITY_PRODUCTChanged();
    partial void OnERROR_PRODUCTChanging(string value);
    partial void OnERROR_PRODUCTChanged();
    partial void OnCHIEU_DAI_SPLOIChanging(string value);
    partial void OnCHIEU_DAI_SPLOIChanged();
    partial void OnDUONG_KINH_ONGChanging(string value);
    partial void OnDUONG_KINH_ONGChanged();
    partial void OnBE_DAYChanging(string value);
    partial void OnBE_DAYChanged();
    partial void OnCHIEU_DAI_CATChanging(string value);
    partial void OnCHIEU_DAI_CATChanged();
    partial void OnMOTOR_SPEEDChanging(string value);
    partial void OnMOTOR_SPEEDChanged();
    partial void OnDC_VOLTChanging(string value);
    partial void OnDC_VOLTChanged();
    partial void OnDC_AMPEChanging(string value);
    partial void OnDC_AMPEChanged();
    partial void OnHEATER_9Changing(string value);
    partial void OnHEATER_9Changed();
    partial void OnHEATER_1_3Changing(string value);
    partial void OnHEATER_1_3Changed();
    partial void OnHEATER_2Changing(string value);
    partial void OnHEATER_2Changed();
    partial void OnHEATER_8_10Changing(string value);
    partial void OnHEATER_8_10Changed();
    partial void OnZONE_1B_2BChanging(string value);
    partial void OnZONE_1B_2BChanged();
    partial void OnZONE_3B_4BChanging(string value);
    partial void OnZONE_3B_4BChanged();
    partial void OnZONE_1A_2AChanging(string value);
    partial void OnZONE_1A_2AChanged();
    partial void OnZONE_3A_4AChanging(string value);
    partial void OnZONE_3A_4AChanged();
    partial void OnLOSAY_CAO_TRENChanging(string value);
    partial void OnLOSAY_CAO_TRENChanged();
    partial void OnLOSAY_CAO_DUOIChanging(string value);
    partial void OnLOSAY_CAO_DUOIChanged();
    partial void OnLOSAY_THAP_TRENChanging(string value);
    partial void OnLOSAY_THAP_TRENChanged();
    partial void OnLOSAY_THAP_DUOIChanging(string value);
    partial void OnLOSAY_THAP_DUOIChanged();
    #endregion
		
		public VARIABLE_DAQ()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE_TIME", DbType="VarChar(50)")]
		public string DATE_TIME
		{
			get
			{
				return this._DATE_TIME;
			}
			set
			{
				if ((this._DATE_TIME != value))
				{
					this.OnDATE_TIMEChanging(value);
					this.SendPropertyChanging();
					this._DATE_TIME = value;
					this.SendPropertyChanged("DATE_TIME");
					this.OnDATE_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FREQUENCY_RICH", DbType="VarChar(20)")]
		public string FREQUENCY_RICH
		{
			get
			{
				return this._FREQUENCY_RICH;
			}
			set
			{
				if ((this._FREQUENCY_RICH != value))
				{
					this.OnFREQUENCY_RICHChanging(value);
					this.SendPropertyChanging();
					this._FREQUENCY_RICH = value;
					this.SendPropertyChanged("FREQUENCY_RICH");
					this.OnFREQUENCY_RICHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENT_RICH", DbType="VarChar(20)")]
		public string CURRENT_RICH
		{
			get
			{
				return this._CURRENT_RICH;
			}
			set
			{
				if ((this._CURRENT_RICH != value))
				{
					this.OnCURRENT_RICHChanging(value);
					this.SendPropertyChanging();
					this._CURRENT_RICH = value;
					this.SendPropertyChanged("CURRENT_RICH");
					this.OnCURRENT_RICHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FREQUENCY_DELTA", DbType="VarChar(20)")]
		public string FREQUENCY_DELTA
		{
			get
			{
				return this._FREQUENCY_DELTA;
			}
			set
			{
				if ((this._FREQUENCY_DELTA != value))
				{
					this.OnFREQUENCY_DELTAChanging(value);
					this.SendPropertyChanging();
					this._FREQUENCY_DELTA = value;
					this.SendPropertyChanged("FREQUENCY_DELTA");
					this.OnFREQUENCY_DELTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENT_DELTA", DbType="VarChar(20)")]
		public string CURRENT_DELTA
		{
			get
			{
				return this._CURRENT_DELTA;
			}
			set
			{
				if ((this._CURRENT_DELTA != value))
				{
					this.OnCURRENT_DELTAChanging(value);
					this.SendPropertyChanging();
					this._CURRENT_DELTA = value;
					this.SendPropertyChanged("CURRENT_DELTA");
					this.OnCURRENT_DELTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPE_OF_PRODUCT", DbType="VarChar(20)")]
		public string TYPE_OF_PRODUCT
		{
			get
			{
				return this._TYPE_OF_PRODUCT;
			}
			set
			{
				if ((this._TYPE_OF_PRODUCT != value))
				{
					this.OnTYPE_OF_PRODUCTChanging(value);
					this.SendPropertyChanging();
					this._TYPE_OF_PRODUCT = value;
					this.SendPropertyChanged("TYPE_OF_PRODUCT");
					this.OnTYPE_OF_PRODUCTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUALITY_PRODUCT", DbType="VarChar(20)")]
		public string QUALITY_PRODUCT
		{
			get
			{
				return this._QUALITY_PRODUCT;
			}
			set
			{
				if ((this._QUALITY_PRODUCT != value))
				{
					this.OnQUALITY_PRODUCTChanging(value);
					this.SendPropertyChanging();
					this._QUALITY_PRODUCT = value;
					this.SendPropertyChanged("QUALITY_PRODUCT");
					this.OnQUALITY_PRODUCTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERROR_PRODUCT", DbType="VarChar(20)")]
		public string ERROR_PRODUCT
		{
			get
			{
				return this._ERROR_PRODUCT;
			}
			set
			{
				if ((this._ERROR_PRODUCT != value))
				{
					this.OnERROR_PRODUCTChanging(value);
					this.SendPropertyChanging();
					this._ERROR_PRODUCT = value;
					this.SendPropertyChanged("ERROR_PRODUCT");
					this.OnERROR_PRODUCTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHIEU_DAI_SPLOI", DbType="VarChar(20)")]
		public string CHIEU_DAI_SPLOI
		{
			get
			{
				return this._CHIEU_DAI_SPLOI;
			}
			set
			{
				if ((this._CHIEU_DAI_SPLOI != value))
				{
					this.OnCHIEU_DAI_SPLOIChanging(value);
					this.SendPropertyChanging();
					this._CHIEU_DAI_SPLOI = value;
					this.SendPropertyChanged("CHIEU_DAI_SPLOI");
					this.OnCHIEU_DAI_SPLOIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DUONG_KINH_ONG", DbType="VarChar(20)")]
		public string DUONG_KINH_ONG
		{
			get
			{
				return this._DUONG_KINH_ONG;
			}
			set
			{
				if ((this._DUONG_KINH_ONG != value))
				{
					this.OnDUONG_KINH_ONGChanging(value);
					this.SendPropertyChanging();
					this._DUONG_KINH_ONG = value;
					this.SendPropertyChanged("DUONG_KINH_ONG");
					this.OnDUONG_KINH_ONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BE_DAY", DbType="VarChar(20)")]
		public string BE_DAY
		{
			get
			{
				return this._BE_DAY;
			}
			set
			{
				if ((this._BE_DAY != value))
				{
					this.OnBE_DAYChanging(value);
					this.SendPropertyChanging();
					this._BE_DAY = value;
					this.SendPropertyChanged("BE_DAY");
					this.OnBE_DAYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHIEU_DAI_CAT", DbType="VarChar(20)")]
		public string CHIEU_DAI_CAT
		{
			get
			{
				return this._CHIEU_DAI_CAT;
			}
			set
			{
				if ((this._CHIEU_DAI_CAT != value))
				{
					this.OnCHIEU_DAI_CATChanging(value);
					this.SendPropertyChanging();
					this._CHIEU_DAI_CAT = value;
					this.SendPropertyChanged("CHIEU_DAI_CAT");
					this.OnCHIEU_DAI_CATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTOR_SPEED", DbType="VarChar(20)")]
		public string MOTOR_SPEED
		{
			get
			{
				return this._MOTOR_SPEED;
			}
			set
			{
				if ((this._MOTOR_SPEED != value))
				{
					this.OnMOTOR_SPEEDChanging(value);
					this.SendPropertyChanging();
					this._MOTOR_SPEED = value;
					this.SendPropertyChanged("MOTOR_SPEED");
					this.OnMOTOR_SPEEDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DC_VOLT", DbType="VarChar(20)")]
		public string DC_VOLT
		{
			get
			{
				return this._DC_VOLT;
			}
			set
			{
				if ((this._DC_VOLT != value))
				{
					this.OnDC_VOLTChanging(value);
					this.SendPropertyChanging();
					this._DC_VOLT = value;
					this.SendPropertyChanged("DC_VOLT");
					this.OnDC_VOLTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DC_AMPE", DbType="VarChar(20)")]
		public string DC_AMPE
		{
			get
			{
				return this._DC_AMPE;
			}
			set
			{
				if ((this._DC_AMPE != value))
				{
					this.OnDC_AMPEChanging(value);
					this.SendPropertyChanging();
					this._DC_AMPE = value;
					this.SendPropertyChanged("DC_AMPE");
					this.OnDC_AMPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_9", DbType="VarChar(20)")]
		public string HEATER_9
		{
			get
			{
				return this._HEATER_9;
			}
			set
			{
				if ((this._HEATER_9 != value))
				{
					this.OnHEATER_9Changing(value);
					this.SendPropertyChanging();
					this._HEATER_9 = value;
					this.SendPropertyChanged("HEATER_9");
					this.OnHEATER_9Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_1_3", DbType="VarChar(20)")]
		public string HEATER_1_3
		{
			get
			{
				return this._HEATER_1_3;
			}
			set
			{
				if ((this._HEATER_1_3 != value))
				{
					this.OnHEATER_1_3Changing(value);
					this.SendPropertyChanging();
					this._HEATER_1_3 = value;
					this.SendPropertyChanged("HEATER_1_3");
					this.OnHEATER_1_3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_2", DbType="VarChar(20)")]
		public string HEATER_2
		{
			get
			{
				return this._HEATER_2;
			}
			set
			{
				if ((this._HEATER_2 != value))
				{
					this.OnHEATER_2Changing(value);
					this.SendPropertyChanging();
					this._HEATER_2 = value;
					this.SendPropertyChanged("HEATER_2");
					this.OnHEATER_2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_8_10", DbType="VarChar(20)")]
		public string HEATER_8_10
		{
			get
			{
				return this._HEATER_8_10;
			}
			set
			{
				if ((this._HEATER_8_10 != value))
				{
					this.OnHEATER_8_10Changing(value);
					this.SendPropertyChanging();
					this._HEATER_8_10 = value;
					this.SendPropertyChanged("HEATER_8_10");
					this.OnHEATER_8_10Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_1B_2B", DbType="VarChar(20)")]
		public string ZONE_1B_2B
		{
			get
			{
				return this._ZONE_1B_2B;
			}
			set
			{
				if ((this._ZONE_1B_2B != value))
				{
					this.OnZONE_1B_2BChanging(value);
					this.SendPropertyChanging();
					this._ZONE_1B_2B = value;
					this.SendPropertyChanged("ZONE_1B_2B");
					this.OnZONE_1B_2BChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_3B_4B", DbType="VarChar(20)")]
		public string ZONE_3B_4B
		{
			get
			{
				return this._ZONE_3B_4B;
			}
			set
			{
				if ((this._ZONE_3B_4B != value))
				{
					this.OnZONE_3B_4BChanging(value);
					this.SendPropertyChanging();
					this._ZONE_3B_4B = value;
					this.SendPropertyChanged("ZONE_3B_4B");
					this.OnZONE_3B_4BChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_1A_2A", DbType="VarChar(20)")]
		public string ZONE_1A_2A
		{
			get
			{
				return this._ZONE_1A_2A;
			}
			set
			{
				if ((this._ZONE_1A_2A != value))
				{
					this.OnZONE_1A_2AChanging(value);
					this.SendPropertyChanging();
					this._ZONE_1A_2A = value;
					this.SendPropertyChanged("ZONE_1A_2A");
					this.OnZONE_1A_2AChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_3A_4A", DbType="VarChar(20)")]
		public string ZONE_3A_4A
		{
			get
			{
				return this._ZONE_3A_4A;
			}
			set
			{
				if ((this._ZONE_3A_4A != value))
				{
					this.OnZONE_3A_4AChanging(value);
					this.SendPropertyChanging();
					this._ZONE_3A_4A = value;
					this.SendPropertyChanged("ZONE_3A_4A");
					this.OnZONE_3A_4AChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_CAO_TREN", DbType="VarChar(20)")]
		public string LOSAY_CAO_TREN
		{
			get
			{
				return this._LOSAY_CAO_TREN;
			}
			set
			{
				if ((this._LOSAY_CAO_TREN != value))
				{
					this.OnLOSAY_CAO_TRENChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_CAO_TREN = value;
					this.SendPropertyChanged("LOSAY_CAO_TREN");
					this.OnLOSAY_CAO_TRENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_CAO_DUOI", DbType="VarChar(20)")]
		public string LOSAY_CAO_DUOI
		{
			get
			{
				return this._LOSAY_CAO_DUOI;
			}
			set
			{
				if ((this._LOSAY_CAO_DUOI != value))
				{
					this.OnLOSAY_CAO_DUOIChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_CAO_DUOI = value;
					this.SendPropertyChanged("LOSAY_CAO_DUOI");
					this.OnLOSAY_CAO_DUOIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_THAP_TREN", DbType="VarChar(20)")]
		public string LOSAY_THAP_TREN
		{
			get
			{
				return this._LOSAY_THAP_TREN;
			}
			set
			{
				if ((this._LOSAY_THAP_TREN != value))
				{
					this.OnLOSAY_THAP_TRENChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_THAP_TREN = value;
					this.SendPropertyChanged("LOSAY_THAP_TREN");
					this.OnLOSAY_THAP_TRENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_THAP_DUOI", DbType="VarChar(20)")]
		public string LOSAY_THAP_DUOI
		{
			get
			{
				return this._LOSAY_THAP_DUOI;
			}
			set
			{
				if ((this._LOSAY_THAP_DUOI != value))
				{
					this.OnLOSAY_THAP_DUOIChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_THAP_DUOI = value;
					this.SendPropertyChanged("LOSAY_THAP_DUOI");
					this.OnLOSAY_THAP_DUOIChanged();
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DAILY")]
	public partial class DAILY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _DATE_TIME;
		
		private string _FREQUENCY_RICH;
		
		private string _CURRENT_RICH;
		
		private string _FREQUENCY_DELTA;
		
		private string _CURRENT_DELTA;
		
		private string _TYPE_OF_PRODUCT;
		
		private string _QUALITY_PRODUCT;
		
		private string _ERROR_PRODUCT;
		
		private string _CHIEU_DAI_SPLOI;
		
		private string _DUONG_KINH_ONG;
		
		private string _BE_DAY;
		
		private string _CHIEU_DAI_CAT;
		
		private string _MOTOR_SPEED;
		
		private string _DC_VOLT;
		
		private string _DC_AMPE;
		
		private string _HEATER_9;
		
		private string _HEATER_1_3;
		
		private string _HEATER_2;
		
		private string _HEATER_8_10;
		
		private string _ZONE_1B_2B;
		
		private string _ZONE_3B_4B;
		
		private string _ZONE_1A_2A;
		
		private string _ZONE_3A_4A;
		
		private string _LOSAY_CAO_TREN;
		
		private string _LOSAY_CAO_DUOI;
		
		private string _LOSAY_THAP_TREN;
		
		private string _LOSAY_THAP_DUOI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDATE_TIMEChanging(string value);
    partial void OnDATE_TIMEChanged();
    partial void OnFREQUENCY_RICHChanging(string value);
    partial void OnFREQUENCY_RICHChanged();
    partial void OnCURRENT_RICHChanging(string value);
    partial void OnCURRENT_RICHChanged();
    partial void OnFREQUENCY_DELTAChanging(string value);
    partial void OnFREQUENCY_DELTAChanged();
    partial void OnCURRENT_DELTAChanging(string value);
    partial void OnCURRENT_DELTAChanged();
    partial void OnTYPE_OF_PRODUCTChanging(string value);
    partial void OnTYPE_OF_PRODUCTChanged();
    partial void OnQUALITY_PRODUCTChanging(string value);
    partial void OnQUALITY_PRODUCTChanged();
    partial void OnERROR_PRODUCTChanging(string value);
    partial void OnERROR_PRODUCTChanged();
    partial void OnCHIEU_DAI_SPLOIChanging(string value);
    partial void OnCHIEU_DAI_SPLOIChanged();
    partial void OnDUONG_KINH_ONGChanging(string value);
    partial void OnDUONG_KINH_ONGChanged();
    partial void OnBE_DAYChanging(string value);
    partial void OnBE_DAYChanged();
    partial void OnCHIEU_DAI_CATChanging(string value);
    partial void OnCHIEU_DAI_CATChanged();
    partial void OnMOTOR_SPEEDChanging(string value);
    partial void OnMOTOR_SPEEDChanged();
    partial void OnDC_VOLTChanging(string value);
    partial void OnDC_VOLTChanged();
    partial void OnDC_AMPEChanging(string value);
    partial void OnDC_AMPEChanged();
    partial void OnHEATER_9Changing(string value);
    partial void OnHEATER_9Changed();
    partial void OnHEATER_1_3Changing(string value);
    partial void OnHEATER_1_3Changed();
    partial void OnHEATER_2Changing(string value);
    partial void OnHEATER_2Changed();
    partial void OnHEATER_8_10Changing(string value);
    partial void OnHEATER_8_10Changed();
    partial void OnZONE_1B_2BChanging(string value);
    partial void OnZONE_1B_2BChanged();
    partial void OnZONE_3B_4BChanging(string value);
    partial void OnZONE_3B_4BChanged();
    partial void OnZONE_1A_2AChanging(string value);
    partial void OnZONE_1A_2AChanged();
    partial void OnZONE_3A_4AChanging(string value);
    partial void OnZONE_3A_4AChanged();
    partial void OnLOSAY_CAO_TRENChanging(string value);
    partial void OnLOSAY_CAO_TRENChanged();
    partial void OnLOSAY_CAO_DUOIChanging(string value);
    partial void OnLOSAY_CAO_DUOIChanged();
    partial void OnLOSAY_THAP_TRENChanging(string value);
    partial void OnLOSAY_THAP_TRENChanged();
    partial void OnLOSAY_THAP_DUOIChanging(string value);
    partial void OnLOSAY_THAP_DUOIChanged();
    #endregion
		
		public DAILY()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE_TIME", DbType="VarChar(50)")]
		public string DATE_TIME
		{
			get
			{
				return this._DATE_TIME;
			}
			set
			{
				if ((this._DATE_TIME != value))
				{
					this.OnDATE_TIMEChanging(value);
					this.SendPropertyChanging();
					this._DATE_TIME = value;
					this.SendPropertyChanged("DATE_TIME");
					this.OnDATE_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FREQUENCY_RICH", DbType="VarChar(20)")]
		public string FREQUENCY_RICH
		{
			get
			{
				return this._FREQUENCY_RICH;
			}
			set
			{
				if ((this._FREQUENCY_RICH != value))
				{
					this.OnFREQUENCY_RICHChanging(value);
					this.SendPropertyChanging();
					this._FREQUENCY_RICH = value;
					this.SendPropertyChanged("FREQUENCY_RICH");
					this.OnFREQUENCY_RICHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENT_RICH", DbType="VarChar(20)")]
		public string CURRENT_RICH
		{
			get
			{
				return this._CURRENT_RICH;
			}
			set
			{
				if ((this._CURRENT_RICH != value))
				{
					this.OnCURRENT_RICHChanging(value);
					this.SendPropertyChanging();
					this._CURRENT_RICH = value;
					this.SendPropertyChanged("CURRENT_RICH");
					this.OnCURRENT_RICHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FREQUENCY_DELTA", DbType="VarChar(20)")]
		public string FREQUENCY_DELTA
		{
			get
			{
				return this._FREQUENCY_DELTA;
			}
			set
			{
				if ((this._FREQUENCY_DELTA != value))
				{
					this.OnFREQUENCY_DELTAChanging(value);
					this.SendPropertyChanging();
					this._FREQUENCY_DELTA = value;
					this.SendPropertyChanged("FREQUENCY_DELTA");
					this.OnFREQUENCY_DELTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENT_DELTA", DbType="VarChar(20)")]
		public string CURRENT_DELTA
		{
			get
			{
				return this._CURRENT_DELTA;
			}
			set
			{
				if ((this._CURRENT_DELTA != value))
				{
					this.OnCURRENT_DELTAChanging(value);
					this.SendPropertyChanging();
					this._CURRENT_DELTA = value;
					this.SendPropertyChanged("CURRENT_DELTA");
					this.OnCURRENT_DELTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPE_OF_PRODUCT", DbType="VarChar(20)")]
		public string TYPE_OF_PRODUCT
		{
			get
			{
				return this._TYPE_OF_PRODUCT;
			}
			set
			{
				if ((this._TYPE_OF_PRODUCT != value))
				{
					this.OnTYPE_OF_PRODUCTChanging(value);
					this.SendPropertyChanging();
					this._TYPE_OF_PRODUCT = value;
					this.SendPropertyChanged("TYPE_OF_PRODUCT");
					this.OnTYPE_OF_PRODUCTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUALITY_PRODUCT", DbType="VarChar(20)")]
		public string QUALITY_PRODUCT
		{
			get
			{
				return this._QUALITY_PRODUCT;
			}
			set
			{
				if ((this._QUALITY_PRODUCT != value))
				{
					this.OnQUALITY_PRODUCTChanging(value);
					this.SendPropertyChanging();
					this._QUALITY_PRODUCT = value;
					this.SendPropertyChanged("QUALITY_PRODUCT");
					this.OnQUALITY_PRODUCTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERROR_PRODUCT", DbType="VarChar(20)")]
		public string ERROR_PRODUCT
		{
			get
			{
				return this._ERROR_PRODUCT;
			}
			set
			{
				if ((this._ERROR_PRODUCT != value))
				{
					this.OnERROR_PRODUCTChanging(value);
					this.SendPropertyChanging();
					this._ERROR_PRODUCT = value;
					this.SendPropertyChanged("ERROR_PRODUCT");
					this.OnERROR_PRODUCTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHIEU_DAI_SPLOI", DbType="VarChar(20)")]
		public string CHIEU_DAI_SPLOI
		{
			get
			{
				return this._CHIEU_DAI_SPLOI;
			}
			set
			{
				if ((this._CHIEU_DAI_SPLOI != value))
				{
					this.OnCHIEU_DAI_SPLOIChanging(value);
					this.SendPropertyChanging();
					this._CHIEU_DAI_SPLOI = value;
					this.SendPropertyChanged("CHIEU_DAI_SPLOI");
					this.OnCHIEU_DAI_SPLOIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DUONG_KINH_ONG", DbType="VarChar(20)")]
		public string DUONG_KINH_ONG
		{
			get
			{
				return this._DUONG_KINH_ONG;
			}
			set
			{
				if ((this._DUONG_KINH_ONG != value))
				{
					this.OnDUONG_KINH_ONGChanging(value);
					this.SendPropertyChanging();
					this._DUONG_KINH_ONG = value;
					this.SendPropertyChanged("DUONG_KINH_ONG");
					this.OnDUONG_KINH_ONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BE_DAY", DbType="VarChar(20)")]
		public string BE_DAY
		{
			get
			{
				return this._BE_DAY;
			}
			set
			{
				if ((this._BE_DAY != value))
				{
					this.OnBE_DAYChanging(value);
					this.SendPropertyChanging();
					this._BE_DAY = value;
					this.SendPropertyChanged("BE_DAY");
					this.OnBE_DAYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHIEU_DAI_CAT", DbType="VarChar(20)")]
		public string CHIEU_DAI_CAT
		{
			get
			{
				return this._CHIEU_DAI_CAT;
			}
			set
			{
				if ((this._CHIEU_DAI_CAT != value))
				{
					this.OnCHIEU_DAI_CATChanging(value);
					this.SendPropertyChanging();
					this._CHIEU_DAI_CAT = value;
					this.SendPropertyChanged("CHIEU_DAI_CAT");
					this.OnCHIEU_DAI_CATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTOR_SPEED", DbType="VarChar(20)")]
		public string MOTOR_SPEED
		{
			get
			{
				return this._MOTOR_SPEED;
			}
			set
			{
				if ((this._MOTOR_SPEED != value))
				{
					this.OnMOTOR_SPEEDChanging(value);
					this.SendPropertyChanging();
					this._MOTOR_SPEED = value;
					this.SendPropertyChanged("MOTOR_SPEED");
					this.OnMOTOR_SPEEDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DC_VOLT", DbType="VarChar(20)")]
		public string DC_VOLT
		{
			get
			{
				return this._DC_VOLT;
			}
			set
			{
				if ((this._DC_VOLT != value))
				{
					this.OnDC_VOLTChanging(value);
					this.SendPropertyChanging();
					this._DC_VOLT = value;
					this.SendPropertyChanged("DC_VOLT");
					this.OnDC_VOLTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DC_AMPE", DbType="VarChar(20)")]
		public string DC_AMPE
		{
			get
			{
				return this._DC_AMPE;
			}
			set
			{
				if ((this._DC_AMPE != value))
				{
					this.OnDC_AMPEChanging(value);
					this.SendPropertyChanging();
					this._DC_AMPE = value;
					this.SendPropertyChanged("DC_AMPE");
					this.OnDC_AMPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_9", DbType="VarChar(20)")]
		public string HEATER_9
		{
			get
			{
				return this._HEATER_9;
			}
			set
			{
				if ((this._HEATER_9 != value))
				{
					this.OnHEATER_9Changing(value);
					this.SendPropertyChanging();
					this._HEATER_9 = value;
					this.SendPropertyChanged("HEATER_9");
					this.OnHEATER_9Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_1_3", DbType="VarChar(20)")]
		public string HEATER_1_3
		{
			get
			{
				return this._HEATER_1_3;
			}
			set
			{
				if ((this._HEATER_1_3 != value))
				{
					this.OnHEATER_1_3Changing(value);
					this.SendPropertyChanging();
					this._HEATER_1_3 = value;
					this.SendPropertyChanged("HEATER_1_3");
					this.OnHEATER_1_3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_2", DbType="VarChar(20)")]
		public string HEATER_2
		{
			get
			{
				return this._HEATER_2;
			}
			set
			{
				if ((this._HEATER_2 != value))
				{
					this.OnHEATER_2Changing(value);
					this.SendPropertyChanging();
					this._HEATER_2 = value;
					this.SendPropertyChanged("HEATER_2");
					this.OnHEATER_2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEATER_8_10", DbType="VarChar(20)")]
		public string HEATER_8_10
		{
			get
			{
				return this._HEATER_8_10;
			}
			set
			{
				if ((this._HEATER_8_10 != value))
				{
					this.OnHEATER_8_10Changing(value);
					this.SendPropertyChanging();
					this._HEATER_8_10 = value;
					this.SendPropertyChanged("HEATER_8_10");
					this.OnHEATER_8_10Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_1B_2B", DbType="VarChar(20)")]
		public string ZONE_1B_2B
		{
			get
			{
				return this._ZONE_1B_2B;
			}
			set
			{
				if ((this._ZONE_1B_2B != value))
				{
					this.OnZONE_1B_2BChanging(value);
					this.SendPropertyChanging();
					this._ZONE_1B_2B = value;
					this.SendPropertyChanged("ZONE_1B_2B");
					this.OnZONE_1B_2BChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_3B_4B", DbType="VarChar(20)")]
		public string ZONE_3B_4B
		{
			get
			{
				return this._ZONE_3B_4B;
			}
			set
			{
				if ((this._ZONE_3B_4B != value))
				{
					this.OnZONE_3B_4BChanging(value);
					this.SendPropertyChanging();
					this._ZONE_3B_4B = value;
					this.SendPropertyChanged("ZONE_3B_4B");
					this.OnZONE_3B_4BChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_1A_2A", DbType="VarChar(20)")]
		public string ZONE_1A_2A
		{
			get
			{
				return this._ZONE_1A_2A;
			}
			set
			{
				if ((this._ZONE_1A_2A != value))
				{
					this.OnZONE_1A_2AChanging(value);
					this.SendPropertyChanging();
					this._ZONE_1A_2A = value;
					this.SendPropertyChanged("ZONE_1A_2A");
					this.OnZONE_1A_2AChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZONE_3A_4A", DbType="VarChar(20)")]
		public string ZONE_3A_4A
		{
			get
			{
				return this._ZONE_3A_4A;
			}
			set
			{
				if ((this._ZONE_3A_4A != value))
				{
					this.OnZONE_3A_4AChanging(value);
					this.SendPropertyChanging();
					this._ZONE_3A_4A = value;
					this.SendPropertyChanged("ZONE_3A_4A");
					this.OnZONE_3A_4AChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_CAO_TREN", DbType="VarChar(20)")]
		public string LOSAY_CAO_TREN
		{
			get
			{
				return this._LOSAY_CAO_TREN;
			}
			set
			{
				if ((this._LOSAY_CAO_TREN != value))
				{
					this.OnLOSAY_CAO_TRENChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_CAO_TREN = value;
					this.SendPropertyChanged("LOSAY_CAO_TREN");
					this.OnLOSAY_CAO_TRENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_CAO_DUOI", DbType="VarChar(20)")]
		public string LOSAY_CAO_DUOI
		{
			get
			{
				return this._LOSAY_CAO_DUOI;
			}
			set
			{
				if ((this._LOSAY_CAO_DUOI != value))
				{
					this.OnLOSAY_CAO_DUOIChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_CAO_DUOI = value;
					this.SendPropertyChanged("LOSAY_CAO_DUOI");
					this.OnLOSAY_CAO_DUOIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_THAP_TREN", DbType="VarChar(20)")]
		public string LOSAY_THAP_TREN
		{
			get
			{
				return this._LOSAY_THAP_TREN;
			}
			set
			{
				if ((this._LOSAY_THAP_TREN != value))
				{
					this.OnLOSAY_THAP_TRENChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_THAP_TREN = value;
					this.SendPropertyChanged("LOSAY_THAP_TREN");
					this.OnLOSAY_THAP_TRENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOSAY_THAP_DUOI", DbType="VarChar(20)")]
		public string LOSAY_THAP_DUOI
		{
			get
			{
				return this._LOSAY_THAP_DUOI;
			}
			set
			{
				if ((this._LOSAY_THAP_DUOI != value))
				{
					this.OnLOSAY_THAP_DUOIChanging(value);
					this.SendPropertyChanging();
					this._LOSAY_THAP_DUOI = value;
					this.SendPropertyChanged("LOSAY_THAP_DUOI");
					this.OnLOSAY_THAP_DUOIChanged();
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
	}
}
#pragma warning restore 1591
