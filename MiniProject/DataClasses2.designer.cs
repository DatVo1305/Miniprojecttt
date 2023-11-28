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

namespace MiniProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Thu3")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQuanLyCuaHang(QuanLyCuaHang instance);
    partial void UpdateQuanLyCuaHang(QuanLyCuaHang instance);
    partial void DeleteQuanLyCuaHang(QuanLyCuaHang instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::MiniProject.Properties.Settings.Default.Thu3ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<QuanLyCuaHang> QuanLyCuaHangs
		{
			get
			{
				return this.GetTable<QuanLyCuaHang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuanLyCuaHang")]
	public partial class QuanLyCuaHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Seri;
		
		private System.Nullable<int> _Number;
		
		private System.Nullable<double> _Price;
		
		private string _Producer;
		
		private string _Color;
		
		private System.Nullable<System.DateTime> _DTProduct;
		
		private System.Nullable<System.DateTime> _DTBought;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSeriChanging(string value);
    partial void OnSeriChanged();
    partial void OnNumberChanging(System.Nullable<int> value);
    partial void OnNumberChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    partial void OnProducerChanging(string value);
    partial void OnProducerChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnDTProductChanging(System.Nullable<System.DateTime> value);
    partial void OnDTProductChanged();
    partial void OnDTBoughtChanging(System.Nullable<System.DateTime> value);
    partial void OnDTBoughtChanged();
    #endregion
		
		public QuanLyCuaHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seri", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Seri
		{
			get
			{
				return this._Seri;
			}
			set
			{
				if ((this._Seri != value))
				{
					this.OnSeriChanging(value);
					this.SendPropertyChanging();
					this._Seri = value;
					this.SendPropertyChanged("Seri");
					this.OnSeriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number", DbType="Int")]
		public System.Nullable<int> Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				if ((this._Number != value))
				{
					this.OnNumberChanging(value);
					this.SendPropertyChanging();
					this._Number = value;
					this.SendPropertyChanged("Number");
					this.OnNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producer", DbType="NChar(10)")]
		public string Producer
		{
			get
			{
				return this._Producer;
			}
			set
			{
				if ((this._Producer != value))
				{
					this.OnProducerChanging(value);
					this.SendPropertyChanging();
					this._Producer = value;
					this.SendPropertyChanged("Producer");
					this.OnProducerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NChar(10)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTProduct", DbType="DateTime")]
		public System.Nullable<System.DateTime> DTProduct
		{
			get
			{
				return this._DTProduct;
			}
			set
			{
				if ((this._DTProduct != value))
				{
					this.OnDTProductChanging(value);
					this.SendPropertyChanging();
					this._DTProduct = value;
					this.SendPropertyChanged("DTProduct");
					this.OnDTProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTBought", DbType="DateTime")]
		public System.Nullable<System.DateTime> DTBought
		{
			get
			{
				return this._DTBought;
			}
			set
			{
				if ((this._DTBought != value))
				{
					this.OnDTBoughtChanging(value);
					this.SendPropertyChanging();
					this._DTBought = value;
					this.SendPropertyChanged("DTBought");
					this.OnDTBoughtChanged();
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