// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2011-01-09 01:43:04Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace CMSWeb.Models
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class Main : DataContext
	{
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		#endregion
		
		public Main(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public Main(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Main(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<Document> Document
		{
			get
			{
				return this.GetTable <Document>();
			}
		}
		
		public Table<Structure> Structure
		{
			get
			{
				return this.GetTable <Structure>();
			}
		}
		
		public Table<StructureDocument> StructureDocument
		{
			get
			{
				return this.GetTable <StructureDocument>();
			}
		}
		
		public Table<User> User
		{
			get
			{
				return this.GetTable <User>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class Main
	{
		
		public Main(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class Main
	{
		
		public Main(IDbConnection connection) : 
				base(connection, new DbLinq.Sqlite.SqliteVendor())
		{
			this.OnCreated();
		}
		
		public Main(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public Main(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="main.document")]
	public partial class Document : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _documentCreated;
		
		private string _documentData;
		
		private System.Nullable<int> _documentID;
		
		private string _documentModified;
		
		private string _documentName;
		
		private System.Nullable<int> _documentRootID;
		
		private string _documentStatus;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnDocumentCreatedChanged();
		
				partial void OnDocumentCreatedChanging(string value);
		
				partial void OnDocumentDataChanged();
		
				partial void OnDocumentDataChanging(string value);
		
				partial void OnDocumentIDChanged();
		
				partial void OnDocumentIDChanging(System.Nullable<int> value);
		
				partial void OnDocumentModifiedChanged();
		
				partial void OnDocumentModifiedChanging(string value);
		
				partial void OnDocumentNameChanged();
		
				partial void OnDocumentNameChanging(string value);
		
				partial void OnDocumentRootIDChanged();
		
				partial void OnDocumentRootIDChanging(System.Nullable<int> value);
		
				partial void OnDocumentStatusChanged();
		
				partial void OnDocumentStatusChanging(string value);
		#endregion
		
		public Document()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_documentCreated", Name="document_created", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DocumentCreated
		{
			get
			{
				return this._documentCreated;
			}
			set
			{
				if (((_documentCreated == value) == false))
				{
					this.OnDocumentCreatedChanging(value);
					this.SendPropertyChanging();
					this._documentCreated = value;
					this.SendPropertyChanged("DocumentCreated");
					this.OnDocumentCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_documentData", Name="document_data", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DocumentData
		{
			get
			{
				return this._documentData;
			}
			set
			{
				if (((_documentData == value) == false))
				{
					this.OnDocumentDataChanging(value);
					this.SendPropertyChanging();
					this._documentData = value;
					this.SendPropertyChanged("DocumentData");
					this.OnDocumentDataChanged();
				}
			}
		}
		
		[Column(Storage="_documentID", Name="document_id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> DocumentID
		{
			get
			{
				return this._documentID;
			}
			set
			{
				if ((_documentID != value))
				{
					this.OnDocumentIDChanging(value);
					this.SendPropertyChanging();
					this._documentID = value;
					this.SendPropertyChanged("DocumentID");
					this.OnDocumentIDChanged();
				}
			}
		}
		
		[Column(Storage="_documentModified", Name="document_modified", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DocumentModified
		{
			get
			{
				return this._documentModified;
			}
			set
			{
				if (((_documentModified == value) == false))
				{
					this.OnDocumentModifiedChanging(value);
					this.SendPropertyChanging();
					this._documentModified = value;
					this.SendPropertyChanged("DocumentModified");
					this.OnDocumentModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_documentName", Name="document_name", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DocumentName
		{
			get
			{
				return this._documentName;
			}
			set
			{
				if (((_documentName == value) == false))
				{
					this.OnDocumentNameChanging(value);
					this.SendPropertyChanging();
					this._documentName = value;
					this.SendPropertyChanged("DocumentName");
					this.OnDocumentNameChanged();
				}
			}
		}
		
		[Column(Storage="_documentRootID", Name="document_root_id", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> DocumentRootID
		{
			get
			{
				return this._documentRootID;
			}
			set
			{
				if ((_documentRootID != value))
				{
					this.OnDocumentRootIDChanging(value);
					this.SendPropertyChanging();
					this._documentRootID = value;
					this.SendPropertyChanged("DocumentRootID");
					this.OnDocumentRootIDChanged();
				}
			}
		}
		
		[Column(Storage="_documentStatus", Name="document_status", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DocumentStatus
		{
			get
			{
				return this._documentStatus;
			}
			set
			{
				if (((_documentStatus == value) == false))
				{
					this.OnDocumentStatusChanging(value);
					this.SendPropertyChanging();
					this._documentStatus = value;
					this.SendPropertyChanged("DocumentStatus");
					this.OnDocumentStatusChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.structure")]
	public partial class Structure : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<decimal> _structureDocumentID;
		
		private System.Nullable<int> _structureID;
		
		private string _structureName;
		
		private System.Nullable<decimal> _structureParentID;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnStructureDocumentIDChanged();
		
				partial void OnStructureDocumentIDChanging(System.Nullable<decimal> value);
		
				partial void OnStructureIDChanged();
		
				partial void OnStructureIDChanging(System.Nullable<int> value);
		
				partial void OnStructureNameChanged();
		
				partial void OnStructureNameChanging(string value);
		
				partial void OnStructureParentIDChanged();
		
				partial void OnStructureParentIDChanging(System.Nullable<decimal> value);
		#endregion
		
		public Structure()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_structureDocumentID", Name="structure_document_id", DbType="NUMERIC", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> StructureDocumentID
		{
			get
			{
				return this._structureDocumentID;
			}
			set
			{
				if ((_structureDocumentID != value))
				{
					this.OnStructureDocumentIDChanging(value);
					this.SendPropertyChanging();
					this._structureDocumentID = value;
					this.SendPropertyChanged("StructureDocumentID");
					this.OnStructureDocumentIDChanged();
				}
			}
		}
		
		[Column(Storage="_structureID", Name="structure_id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StructureID
		{
			get
			{
				return this._structureID;
			}
			set
			{
				if ((_structureID != value))
				{
					this.OnStructureIDChanging(value);
					this.SendPropertyChanging();
					this._structureID = value;
					this.SendPropertyChanged("StructureID");
					this.OnStructureIDChanged();
				}
			}
		}
		
		[Column(Storage="_structureName", Name="structure_name", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string StructureName
		{
			get
			{
				return this._structureName;
			}
			set
			{
				if (((_structureName == value) == false))
				{
					this.OnStructureNameChanging(value);
					this.SendPropertyChanging();
					this._structureName = value;
					this.SendPropertyChanged("StructureName");
					this.OnStructureNameChanged();
				}
			}
		}
		
		[Column(Storage="_structureParentID", Name="structure_parent_id", DbType="NUMERIC", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> StructureParentID
		{
			get
			{
				return this._structureParentID;
			}
			set
			{
				if ((_structureParentID != value))
				{
					this.OnStructureParentIDChanging(value);
					this.SendPropertyChanging();
					this._structureParentID = value;
					this.SendPropertyChanged("StructureParentID");
					this.OnStructureParentIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.structure_document")]
	public partial class StructureDocument : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<decimal> _documentID;
		
		private System.Nullable<int> _structureDocumentID;
		
		private System.Nullable<decimal> _structureID;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnDocumentIDChanged();
		
				partial void OnDocumentIDChanging(System.Nullable<decimal> value);
		
				partial void OnStructureDocumentIDChanged();
		
				partial void OnStructureDocumentIDChanging(System.Nullable<int> value);
		
				partial void OnStructureIDChanged();
		
				partial void OnStructureIDChanging(System.Nullable<decimal> value);
		#endregion
		
		public StructureDocument()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_documentID", Name="document_id", DbType="NUMERIC", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> DocumentID
		{
			get
			{
				return this._documentID;
			}
			set
			{
				if ((_documentID != value))
				{
					this.OnDocumentIDChanging(value);
					this.SendPropertyChanging();
					this._documentID = value;
					this.SendPropertyChanged("DocumentID");
					this.OnDocumentIDChanged();
				}
			}
		}
		
		[Column(Storage="_structureDocumentID", Name="structure_document_id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StructureDocumentID
		{
			get
			{
				return this._structureDocumentID;
			}
			set
			{
				if ((_structureDocumentID != value))
				{
					this.OnStructureDocumentIDChanging(value);
					this.SendPropertyChanging();
					this._structureDocumentID = value;
					this.SendPropertyChanged("StructureDocumentID");
					this.OnStructureDocumentIDChanged();
				}
			}
		}
		
		[Column(Storage="_structureID", Name="structure_id", DbType="NUMERIC", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> StructureID
		{
			get
			{
				return this._structureID;
			}
			set
			{
				if ((_structureID != value))
				{
					this.OnStructureIDChanging(value);
					this.SendPropertyChanging();
					this._structureID = value;
					this.SendPropertyChanged("StructureID");
					this.OnStructureIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.user")]
	public partial class User : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _userEmail;
		
		private string _userFirstname;
		
		private System.Nullable<int> _userID;
		
		private string _userLogin;
		
		private string _userPassword;
		
		private string _userSurname;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnUserEmailChanged();
		
				partial void OnUserEmailChanging(string value);
		
				partial void OnUserFirstnameChanged();
		
				partial void OnUserFirstnameChanging(string value);
		
				partial void OnUserIDChanged();
		
				partial void OnUserIDChanging(System.Nullable<int> value);
		
				partial void OnUserLoginChanged();
		
				partial void OnUserLoginChanging(string value);
		
				partial void OnUserPasswordChanged();
		
				partial void OnUserPasswordChanging(string value);
		
				partial void OnUserSurnameChanged();
		
				partial void OnUserSurnameChanging(string value);
		#endregion
		
		public User()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_userEmail", Name="user_email", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UserEmail
		{
			get
			{
				return this._userEmail;
			}
			set
			{
				if (((_userEmail == value) == false))
				{
					this.OnUserEmailChanging(value);
					this.SendPropertyChanging();
					this._userEmail = value;
					this.SendPropertyChanged("UserEmail");
					this.OnUserEmailChanged();
				}
			}
		}
		
		[Column(Storage="_userFirstname", Name="user_firstname", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UserFirstname
		{
			get
			{
				return this._userFirstname;
			}
			set
			{
				if (((_userFirstname == value) == false))
				{
					this.OnUserFirstnameChanging(value);
					this.SendPropertyChanging();
					this._userFirstname = value;
					this.SendPropertyChanged("UserFirstname");
					this.OnUserFirstnameChanged();
				}
			}
		}
		
		[Column(Storage="_userID", Name="user_id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_userLogin", Name="user_login", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UserLogin
		{
			get
			{
				return this._userLogin;
			}
			set
			{
				if (((_userLogin == value) == false))
				{
					this.OnUserLoginChanging(value);
					this.SendPropertyChanging();
					this._userLogin = value;
					this.SendPropertyChanged("UserLogin");
					this.OnUserLoginChanged();
				}
			}
		}
		
		[Column(Storage="_userPassword", Name="user_password", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UserPassword
		{
			get
			{
				return this._userPassword;
			}
			set
			{
				if (((_userPassword == value) == false))
				{
					this.OnUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._userPassword = value;
					this.SendPropertyChanged("UserPassword");
					this.OnUserPasswordChanged();
				}
			}
		}
		
		[Column(Storage="_userSurname", Name="user_surname", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UserSurname
		{
			get
			{
				return this._userSurname;
			}
			set
			{
				if (((_userSurname == value) == false))
				{
					this.OnUserSurnameChanging(value);
					this.SendPropertyChanging();
					this._userSurname = value;
					this.SendPropertyChanged("UserSurname");
					this.OnUserSurnameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
