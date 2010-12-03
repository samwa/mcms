// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2010-11-23 21:03:48Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace CMSCore.Entities
{
	using System;
	using System.ComponentModel;
	using System.Data;
	using System.Data.Linq;
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
		
		public Main(IDbConnection connection) : 
				base(connection)
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
	}
	
	[Table(Name="main.document")]
	public partial class Document : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _documentID;
		
		private string _documentName;
		
		#region Extensibility Method Declarations
				partial void OnCreated();
		
				partial void OnDocumentIDChanged();
		
				partial void OnDocumentIDChanging(System.Nullable<int> value);
		
				partial void OnDocumentNameChanged();
		
				partial void OnDocumentNameChanging(string value);
		#endregion
		
		public Document()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_documentID", Name="document_Id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
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
