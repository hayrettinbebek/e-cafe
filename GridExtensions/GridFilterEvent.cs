using System;
using System.Data;
using System.Windows.Forms;

namespace GridExtensions
{
	/// <summary>
	/// Delegate for use with <see cref="GridFilterEventArgs"/>.
	/// </summary>
	public delegate void GridFilterEventHandler(object sender, GridFilterEventArgs args);

	/// <summary>
	/// Argumentsclass for events needing extended informations about <see cref="IGridFilter"/>s.
	/// </summary>
	public class GridFilterEventArgs : EventArgs
	{
		#region Fields

		private DataColumn _column;
		private DataGridColumnStyle _columnStyle;
		private IGridFilter _gridFilter;

		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new instance
		/// </summary>
		/// <param name="column">Column the <see cref="IGridFilter"/> is created for.</param>
		/// <param name="columnStyle">Column style the <see cref="IGridFilter"/> is created for.</param>
		/// <param name="gridFilter">Default <see cref="IGridFilter"/> instance.</param>
		public GridFilterEventArgs(DataColumn column, DataGridColumnStyle columnStyle, IGridFilter gridFilter)
		{
			_column = column;
			_columnStyle = columnStyle;
			_gridFilter = gridFilter;
		}

		#endregion

		#region Public Interface

		/// <summary>
		/// Type of the column the <see cref="IGridFilter"/> is created for.
		/// </summary>
		public Type DataType 
		{
			get { return _column.DataType; }
		}

		/// <summary>
		/// Name of the column the <see cref="IGridFilter"/> is created for.
		/// </summary>
		public string ColumnName 
		{
			get { return _column.ColumnName; }
		}

		/// <summary>
		/// Name of the table the <see cref="IGridFilter"/> is created for.
		/// </summary>
		public string TableName 
		{
			get { return Table.TableName; }
		}

		/// <summary>
		/// The column the <see cref="IGridFilter"/> is created for.
		/// </summary>
		public DataColumn Column 
		{
			get { return _column; }
		}

		/// <summary>
		/// The column style the <see cref="IGridFilter"/> is created for.
		/// </summary>
		public DataGridColumnStyle ColumnStyle
		{
			get { return _columnStyle; }
		}

		/// <summary>
		/// Text of the header of the column the <see cref="IGridFilter"/> is created for.
		/// </summary>
		public string HeaderText 
		{
			get { return _columnStyle.HeaderText; }
		}

		/// <summary>
		/// The table the <see cref="IGridFilter"/> is created for.
		/// </summary>
		public DataTable Table
		{
			get { return _column.Table; }
		}

		/// <summary>
		/// Gets/sets the <see cref="IGridFilter"/> which should be used.
		/// </summary>
		public IGridFilter GridFilter 
		{
			get { return _gridFilter; }
			set { _gridFilter = value; }
		}

		#endregion
	}
}
