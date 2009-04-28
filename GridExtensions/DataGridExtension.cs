using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace GridExtensions
{
	/// <summary>
	/// Implementation of <see cref="IGridExtension"/> to extend a foreign
	/// instance of <see cref="DataGrid"/>. This is done by calling
	/// protected properties of the grid by using reflection.
	/// </summary>
	internal class DataGridExtension : IGridExtension
	{
		#region Fields

		private DataGrid _grid;
		private Color _lastCaptionForeColor = Color.Empty;
		private Color _lastCaptionBackColor = Color.Empty;

		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new instance
		/// </summary>
		/// <param name="grid">The instance to be enhanced</param>
		internal DataGridExtension(DataGrid grid) 
		{
			_grid = grid;
			_grid.Invalidated += new InvalidateEventHandler(OnGridInvalidated);
		}

		#endregion

		#region IGridExtension Member

		/// <summary>
		/// Gets raised when either <see cref="DataGrid.CaptionBackColor"/> or
		/// <see cref="DataGrid.CaptionForeColor"/> has changed
		/// </summary>
		public event System.EventHandler CaptionColorsChanged;

		/// <summary>
		/// Publishes the <see cref="DataGrid"/> class's property <see cref="DataGrid.HorizScrollBar"/>
		/// </summary>
		public ScrollBar HorizontalScrollbar
		{
			get
			{
				BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase;
				PropertyInfo info = typeof(DataGrid).GetProperty("HorizScrollBar", flags);
				object result = info.GetValue(_grid, null);
				return result as ScrollBar;
			}
		}

		/// <summary>
		/// Publishes the <see cref="DataGrid"/> class's property <see cref="DataGrid.VertScrollBar"/>
		/// </summary>
		public ScrollBar VerticalScrollbar
		{
			get
			{
				BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase;
				PropertyInfo info = typeof(DataGrid).GetProperty("VertScrollBar", flags);
				object result = info.GetValue(_grid, null);
				return result as ScrollBar;
			}
		}

		/// <summary>
		/// Gets the currently visible <see cref="DataView"/>.
		/// Returns null when no <see cref="DataView"/> is set.
		/// </summary>
		public System.Data.DataView CurrentView
		{
			get
			{
				BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase;
				PropertyInfo info = typeof(DataGrid).GetProperty("ListManager", flags);
				CurrencyManager manager = info.GetValue(_grid, null) as CurrencyManager;
				
				if (manager == null)
					return null;
				else
					return manager.List as DataView; 
			}
		}

		/// <summary>
		/// Gets the extended <see cref="DataGrid"/>.
		/// </summary>
		public DataGrid Grid
		{
			get { return _grid; }
		}

		#endregion

		#region Privates

		private void OnGridInvalidated(object sender, InvalidateEventArgs e)
		{
			if (_lastCaptionBackColor != _grid.CaptionBackColor ||
				_lastCaptionForeColor != _grid.CaptionForeColor) 
			{
				if (CaptionColorsChanged != null)
					CaptionColorsChanged(this, EventArgs.Empty);
			}
		}

		#endregion
	}
}
