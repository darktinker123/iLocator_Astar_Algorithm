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

namespace iLocatorAstar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbiLocator")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::iLocatorAstar.Properties.Settings.Default.dbiLocatorConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblUserLog> tblUserLogs
		{
			get
			{
				return this.GetTable<tblUserLog>();
			}
		}
		
		public System.Data.Linq.Table<v_userlog> v_userlogs
		{
			get
			{
				return this.GetTable<v_userlog>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_AddUserLogs")]
		public int sp_AddUserLogs([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string utype, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string start, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string dest, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> logTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), utype, start, dest, logTime);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_SearchUserLogs")]
		public ISingleResult<sp_SearchUserLogsResult> sp_SearchUserLogs([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string searchkey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), searchkey);
			return ((ISingleResult<sp_SearchUserLogsResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUserLogs")]
	public partial class tblUserLog
	{
		
		private int _userLogID;
		
		private string _usertype;
		
		private string _currentLocation;
		
		private string _destination;
		
		private System.Nullable<System.DateTime> _userLogTime;
		
		public tblUserLog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int userLogID
		{
			get
			{
				return this._userLogID;
			}
			set
			{
				if ((this._userLogID != value))
				{
					this._userLogID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="VarChar(20)")]
		public string usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this._usertype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentLocation", DbType="VarChar(50)")]
		public string currentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				if ((this._currentLocation != value))
				{
					this._currentLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destination", DbType="VarChar(50)")]
		public string destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if ((this._destination != value))
				{
					this._destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> userLogTime
		{
			get
			{
				return this._userLogTime;
			}
			set
			{
				if ((this._userLogTime != value))
				{
					this._userLogTime = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.v_userlogs")]
	public partial class v_userlog
	{
		
		private int _userLogID;
		
		private string _usertype;
		
		private string _currentLocation;
		
		private string _destination;
		
		private System.Nullable<System.DateTime> _userLogTime;
		
		public v_userlog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int userLogID
		{
			get
			{
				return this._userLogID;
			}
			set
			{
				if ((this._userLogID != value))
				{
					this._userLogID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="VarChar(20)")]
		public string usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this._usertype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentLocation", DbType="VarChar(50)")]
		public string currentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				if ((this._currentLocation != value))
				{
					this._currentLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destination", DbType="VarChar(50)")]
		public string destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if ((this._destination != value))
				{
					this._destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> userLogTime
		{
			get
			{
				return this._userLogTime;
			}
			set
			{
				if ((this._userLogTime != value))
				{
					this._userLogTime = value;
				}
			}
		}
	}
	
	public partial class sp_SearchUserLogsResult
	{
		
		private int _userLogID;
		
		private string _usertype;
		
		private string _currentLocation;
		
		private string _destination;
		
		private System.Nullable<System.DateTime> _userLogTime;
		
		public sp_SearchUserLogsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogID", DbType="Int NOT NULL")]
		public int userLogID
		{
			get
			{
				return this._userLogID;
			}
			set
			{
				if ((this._userLogID != value))
				{
					this._userLogID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="VarChar(20)")]
		public string usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this._usertype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentLocation", DbType="VarChar(50)")]
		public string currentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				if ((this._currentLocation != value))
				{
					this._currentLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destination", DbType="VarChar(50)")]
		public string destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if ((this._destination != value))
				{
					this._destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> userLogTime
		{
			get
			{
				return this._userLogTime;
			}
			set
			{
				if ((this._userLogTime != value))
				{
					this._userLogTime = value;
				}
			}
		}
	}
}
#pragma warning restore 1591