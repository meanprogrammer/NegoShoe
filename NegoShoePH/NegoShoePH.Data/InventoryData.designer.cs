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

namespace NegoShoePH.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db9371b71c443a44449f49a75500a2e577")]
	public partial class InventoryDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItemBrand(ItemBrand instance);
    partial void UpdateItemBrand(ItemBrand instance);
    partial void DeleteItemBrand(ItemBrand instance);
    partial void InsertItemType(ItemType instance);
    partial void UpdateItemType(ItemType instance);
    partial void DeleteItemType(ItemType instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    #endregion
		
		public InventoryDataDataContext() : 
				base(global::NegoShoePH.Data.Properties.Settings.Default.NegoShoeInventoryConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ItemBrand> ItemBrands
		{
			get
			{
				return this.GetTable<ItemBrand>();
			}
		}
		
		public System.Data.Linq.Table<ItemType> ItemTypes
		{
			get
			{
				return this.GetTable<ItemType>();
			}
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemBrand")]
	public partial class ItemBrand : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecordID;
		
		private string _Brand;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecordIDChanging(int value);
    partial void OnRecordIDChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    #endregion
		
		public ItemBrand()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RecordID
		{
			get
			{
				return this._RecordID;
			}
			set
			{
				if ((this._RecordID != value))
				{
					this.OnRecordIDChanging(value);
					this.SendPropertyChanging();
					this._RecordID = value;
					this.SendPropertyChanged("RecordID");
					this.OnRecordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemType")]
	public partial class ItemType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecordID;
		
		private string _ProductType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecordIDChanging(int value);
    partial void OnRecordIDChanged();
    partial void OnProductTypeChanging(string value);
    partial void OnProductTypeChanged();
    #endregion
		
		public ItemType()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RecordID
		{
			get
			{
				return this._RecordID;
			}
			set
			{
				if ((this._RecordID != value))
				{
					this.OnRecordIDChanging(value);
					this.SendPropertyChanging();
					this._RecordID = value;
					this.SendPropertyChanged("RecordID");
					this.OnRecordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductType", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ProductType
		{
			get
			{
				return this._ProductType;
			}
			set
			{
				if ((this._ProductType != value))
				{
					this.OnProductTypeChanging(value);
					this.SendPropertyChanging();
					this._ProductType = value;
					this.SendPropertyChanged("ProductType");
					this.OnProductTypeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Items")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecordID;
		
		private string _ItemName;
		
		private int _Brand;
		
		private int _ProductType;
		
		private string _Description;
		
		private int _TotalQuantity;
		
		private int _OfficeQuantity;
		
		private int _HouseQuantity;
		
		private string _Filename;
		
		private string _ImageBase64;
		
		private string _Remarks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecordIDChanging(int value);
    partial void OnRecordIDChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    partial void OnBrandChanging(int value);
    partial void OnBrandChanged();
    partial void OnProductTypeChanging(int value);
    partial void OnProductTypeChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnTotalQuantityChanging(int value);
    partial void OnTotalQuantityChanged();
    partial void OnOfficeQuantityChanging(int value);
    partial void OnOfficeQuantityChanged();
    partial void OnHouseQuantityChanging(int value);
    partial void OnHouseQuantityChanged();
    partial void OnFilenameChanging(string value);
    partial void OnFilenameChanged();
    partial void OnImageBase64Changing(string value);
    partial void OnImageBase64Changed();
    partial void OnRemarksChanging(string value);
    partial void OnRemarksChanged();
    #endregion
		
		public Item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RecordID
		{
			get
			{
				return this._RecordID;
			}
			set
			{
				if ((this._RecordID != value))
				{
					this.OnRecordIDChanging(value);
					this.SendPropertyChanging();
					this._RecordID = value;
					this.SendPropertyChanged("RecordID");
					this.OnRecordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string ItemName
		{
			get
			{
				return this._ItemName;
			}
			set
			{
				if ((this._ItemName != value))
				{
					this.OnItemNameChanging(value);
					this.SendPropertyChanging();
					this._ItemName = value;
					this.SendPropertyChanged("ItemName");
					this.OnItemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="Int NOT NULL")]
		public int Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductType", DbType="Int NOT NULL")]
		public int ProductType
		{
			get
			{
				return this._ProductType;
			}
			set
			{
				if ((this._ProductType != value))
				{
					this.OnProductTypeChanging(value);
					this.SendPropertyChanging();
					this._ProductType = value;
					this.SendPropertyChanged("ProductType");
					this.OnProductTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalQuantity", DbType="Int NOT NULL")]
		public int TotalQuantity
		{
			get
			{
				return this._TotalQuantity;
			}
			set
			{
				if ((this._TotalQuantity != value))
				{
					this.OnTotalQuantityChanging(value);
					this.SendPropertyChanging();
					this._TotalQuantity = value;
					this.SendPropertyChanged("TotalQuantity");
					this.OnTotalQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OfficeQuantity", DbType="Int NOT NULL")]
		public int OfficeQuantity
		{
			get
			{
				return this._OfficeQuantity;
			}
			set
			{
				if ((this._OfficeQuantity != value))
				{
					this.OnOfficeQuantityChanging(value);
					this.SendPropertyChanging();
					this._OfficeQuantity = value;
					this.SendPropertyChanged("OfficeQuantity");
					this.OnOfficeQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HouseQuantity", DbType="Int NOT NULL")]
		public int HouseQuantity
		{
			get
			{
				return this._HouseQuantity;
			}
			set
			{
				if ((this._HouseQuantity != value))
				{
					this.OnHouseQuantityChanging(value);
					this.SendPropertyChanging();
					this._HouseQuantity = value;
					this.SendPropertyChanged("HouseQuantity");
					this.OnHouseQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Filename", DbType="NVarChar(50)")]
		public string Filename
		{
			get
			{
				return this._Filename;
			}
			set
			{
				if ((this._Filename != value))
				{
					this.OnFilenameChanging(value);
					this.SendPropertyChanging();
					this._Filename = value;
					this.SendPropertyChanged("Filename");
					this.OnFilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageBase64", DbType="NVarChar(MAX)")]
		public string ImageBase64
		{
			get
			{
				return this._ImageBase64;
			}
			set
			{
				if ((this._ImageBase64 != value))
				{
					this.OnImageBase64Changing(value);
					this.SendPropertyChanging();
					this._ImageBase64 = value;
					this.SendPropertyChanged("ImageBase64");
					this.OnImageBase64Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remarks", DbType="NVarChar(500)")]
		public string Remarks
		{
			get
			{
				return this._Remarks;
			}
			set
			{
				if ((this._Remarks != value))
				{
					this.OnRemarksChanging(value);
					this.SendPropertyChanging();
					this._Remarks = value;
					this.SendPropertyChanged("Remarks");
					this.OnRemarksChanged();
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
