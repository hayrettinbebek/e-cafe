using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace GridExtensions
{
	/// <summary>
	/// From <see cref="DataGrid"/> deriven class which provides some extra functionalities.
	/// </summary>
	    public class ExtendedDataGrid : DataGrid, IGridExtension
	{
		#region Fields

		private bool _autoCreateTableStyles = false;
		private Color _lastCaptionForeColor = Color.Empty;
		private Color _lastCaptionBackColor = Color.Empty;

		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		public ExtendedDataGrid() : base() {}

		#endregion

		#region Public interface

		/// <summary>
		/// Controls whether TableStyles are automatically generated.
		/// </summary>
		[Browsable(true)]
		[Description("Controls whether TableStyles are automatically generated.")]
		public bool AutoCreateTableStyles 
		{
			get { return _autoCreateTableStyles; }
			set { _autoCreateTableStyles = value; }
		}

		#endregion

		#region Implementation of IGridExtension

		/// <summary>
		/// Gets raised when either <see cref="DataGrid.CaptionBackColor"/> or
		/// <see cref="DataGrid.CaptionForeColor"/> has changed
		/// </summary>
		[Browsable(true)]
		[Description("Gets fired when the forecolor or the backcolor of the caption have changed.")]
		public event EventHandler CaptionColorsChanged;
		
		/// <summary>
		/// Returns the instance itself
		/// </summary>
		[Browsable(false)]
		public DataGrid Grid 
		{
			get { return this; }
		}

		/// <summary>
		/// Publishes the <see cref="DataGrid"/> class's property <see cref="DataGrid.HorizScrollBar"/>
		/// </summary>
		[Browsable(false)]
		public ScrollBar HorizontalScrollbar 
		{
			get { return base.HorizScrollBar; }
		}

		/// <summary>
		/// Publishes the <see cref="DataGrid"/> class's property <see cref="DataGrid.VertScrollBar"/>
		/// </summary>
		[Browsable(false)]
		public ScrollBar VerticalScrollbar 
		{
			get { return base.VertScrollBar; }
		}

		/// <summary>
		/// Gets the currently visible <see cref="DataView"/>.
		/// Returns null when no <see cref="DataView"/> is set.
		/// </summary>
		[Browsable(false)]
		public DataView CurrentView 
		{
			get 
			{
				if (base.ListManager == null)
					return null;
				else
					return base.ListManager.List as DataView; 
			}
		}

		#endregion

		#region Privates

		/// <summary>
		/// Method for automatically generating a <see cref="DataGridTableStyle"/> for
		/// a given table and adds it to the list of table styles.
		/// </summary>
		/// <param name="table">
		/// <see cref="DataTable"/> for which the <see cref="DataGridTableStyle"/> should be generated.
		/// </param>
		private void CreateDefaultTableStyle(DataTable table) 
		{
			DataGridStyleCreator.CreateTableStyle(table, this, true);
		}

		#endregion

		#region Overriden from DataGrid

		/// <summary>
		/// If <see cref="AutoCreateTableStyles"/> is set to true and no
		/// <see cref="DataGridTableStyle"/> is set for the current visible table
		/// then this method will automatically create a default style.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnDataSourceChanged(EventArgs e)
		{
			if (CurrentView != null && _autoCreateTableStyles) 
			{
				if (!base.TableStyles.Contains(CurrentView.Table.TableName))
				{
					CreateDefaultTableStyle(CurrentView.Table);
				}
			}
			base.OnDataSourceChanged(e);
		}

		/// <summary>
		/// Raises the <see cref="CaptionColorsChanged"/> event when
		/// <see cref="DataGrid.CaptionBackColor"/> or
		///  <see cref="DataGrid.CaptionForeColor"/> have changed 
		/// </summary>
		/// <param name="e">event arguments</param>
		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);

			if (_lastCaptionBackColor != base.CaptionBackColor ||
				_lastCaptionForeColor != base.CaptionForeColor) 
			{
				if (CaptionColorsChanged != null)
					CaptionColorsChanged(this, EventArgs.Empty);
			}
		}

		#endregion
	}
}
