using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GridExtensions
{
	/// <summary>
	/// Control which embeds an <see cref="ExtendedDataGrid"/> and a
	/// <see cref="DataGridFilterExtender"/> for providing automatic 
	/// filtering on all visible columns.
	/// </summary>
	public class FilterableDataGrid : System.Windows.Forms.UserControl
	{
		#region Events

		/// <summary>
		/// Event, which gets fired whenever the filter criteria has been changed.
		/// </summary>
		public event EventHandler AfterFiltersChanged;

		/// <summary>
		/// Event, which gets fired whenever the filter criteria are going to be changed.
		/// </summary>
		public event EventHandler BeforeFiltersChanging;

		/// <summary>
		/// Event, which gets fired whenever an <see cref="IGridFilter"/> has been bound
		/// and thus added to this instance.
		/// </summary>
		public event GridFilterEventHandler GridFilterBound;

		/// <summary>
		/// Event, which gets fired whenever an <see cref="IGridFilter"/> has been unbound
		/// and thus removed to this instance.
		/// </summary>
		public event GridFilterEventHandler GridFilterUnbound;

		#endregion

		#region Fields

		private ExtendedDataGrid _grid;
		private GridExtensions.DataGridFilterExtender _extender;
		private System.ComponentModel.IContainer components;

		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		public FilterableDataGrid()
		{
			InitializeComponent();

			RepositionGrid();
		}

		#endregion

		#region Designer generated code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._grid = new GridExtensions.ExtendedDataGrid();
			this._extender = new GridExtensions.DataGridFilterExtender(this.components);
			((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._extender)).BeginInit();
			this.SuspendLayout();
			// 
			// _grid
			// 
			this._grid.AutoCreateTableStyles = false;
			this._grid.DataMember = "";
			this._grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this._grid.Location = new System.Drawing.Point(0, 24);
			this._grid.Name = "_grid";
			this._grid.Size = new System.Drawing.Size(496, 352);
			this._grid.TabIndex = 0;
			this._grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
			this._grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
			this._grid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
			this._grid.MouseEnter += new System.EventHandler(this.OnMouseEnter);
			this._grid.MouseHover += new System.EventHandler(this.OnMouseHover);
			this._grid.MouseLeave += new System.EventHandler(this.OnMouseLeave);
			this._grid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
			this._grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
			this._grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			this._grid.DoubleClick += new EventHandler(this.OnDoubleClick);
			// 
			// _extender
			// 
			this._extender.AutoAdjustGridPosition = false;
			this._extender.ConsoleErrorMode = GridExtensions.FilterErrorModes.Off;
			this._extender.DataGrid = this._grid;
			this._extender.FilterBoxPosition = GridExtensions.FilterPosition.Top;
			this._extender.FilterText = "Filter";
			this._extender.FilterTextVisible = true;
			this._extender.MessageErrorMode = GridExtensions.FilterErrorModes.General;
			this._extender.Operator = GridExtensions.LogicalOperators.And;
			this._extender.GridFilterBound += new GridExtensions.GridFilterEventHandler(this.OnGridFilterBound);
			this._extender.GridFilterUnbound += new GridExtensions.GridFilterEventHandler(this.OnGridFilterUnbound);
			this._extender.AfterFiltersChanged += new System.EventHandler(this.OnAfterFiltersChanged);
			this._extender.BeforeFiltersChanging += new System.EventHandler(this.OnBeforeFiltersChanging);
			// 
			// FilterableDataGrid
			// 
			this.Controls.Add(this._grid);
			this.Name = "FilterableDataGrid";
			this.Size = new System.Drawing.Size(496, 376);
			((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._extender)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		#region Public interface

		/// <summary>
		/// Gets and sets the mode for the grid.
		/// </summary>
		[Browsable(true), DefaultValue(false)]
		[Description("Specifies whether the table gets filtered or matching rows get highlighted.")]
		public GridMode GridMode
		{
			get { return _extender.GridMode; }
			set { _extender.GridMode = value; }
		}

		/// <summary>
		/// Gets and sets whether the filter criteria is automatically refreshed when
		/// changes are made to the filter controls. If set to false then a call to
		/// <see cref="RefreshFilters"/> is needed to manually refresh the criteria.
		/// </summary>
		[Browsable(true), DefaultValue(RefreshMode.OnInput)]
		[Description("Specifies if the view automatically refreshes to reflect "
			 + "changes in the grid filter controls.")]
		public RefreshMode AutoRefreshMode
		{
			get { return _extender.AutoRefreshMode; }
			set { _extender.AutoRefreshMode = value; }
		}

		/// <summary>
		/// Gets and sets whether filters are kept while switching between different tables.
		/// </summary>
		[Browsable(true), DefaultValue(false)]
		[Description("Specifies whether filters are kept while switching between different tables.")]
		public bool KeepFilters
		{
			get { return _extender.KeepFilters; }
			set { _extender.KeepFilters = value; }
		}

		/// <summary>
		/// Publishes the embedded <see cref="ExtendedDataGrid"/> to allow
		/// full control over its settings.
		/// </summary>
		[Browsable(false)]
		public ExtendedDataGrid EmbeddedDataGrid 
		{
			get { return _grid; }
		}

		/// <summary>
		/// Gets and sets the poisiton of the filter GUI elements.
		/// </summary>
		[Browsable(true), DefaultValue(FilterPosition.Top)]
		[Description("Gets and sets the position of the filter GUI elements.")]
		public FilterPosition FilterBoxPosition 
		{
			get { return _extender.FilterBoxPosition; }
			set 
			{
				_extender.FilterBoxPosition = value;
				RepositionGrid();
			}
		}

		/// <summary>
		/// Gets and sets the text for the filter label.
		/// </summary>
		[Browsable(true), DefaultValue("Filter")]
		[Description("Gets and sets the text for the filter label.")]
		public string FilterText 
		{
			get { return _extender.FilterText; }
			set { _extender.FilterText = value; }
		}

		/// <summary>
		/// Gets and sets the <see cref="IGridFilterFactory"/> used to generate the filter GUI.
		/// </summary>
		[Browsable(true), DefaultValue(null)]
		[Description("Gets and sets factory instance which should be "
			 + "used to create grid filters.")]
		public IGridFilterFactory FilterFactory 
		{
			get { return _extender.FilterFactory; }
			set { _extender.FilterFactory = value; }
		}

		/// <summary>
		/// Gets and sets whether the filter label should be visible.
		/// </summary>
		[Browsable(true), DefaultValue(true)]
		[Description("Gets and sets whether the filter label should be visible.")]
		public bool FilterTextVisible 
		{
			get { return _extender.FilterTextVisible; }
			set { _extender.FilterTextVisible = value; }
		}

		/// <summary>
		/// The selected operator to combine the filter criterias.
		/// </summary>
		[Browsable(true), DefaultValue(LogicalOperators.And)]
		[Description("The selected operator to combine the filter criterias.")]
		public LogicalOperators Operator 
		{
			get { return _extender.Operator; }
			set { _extender.Operator = value; }
		}

		/// <summary>
		/// Gets and sets the <see cref="DataView"/> which should be displayed in the grid.
		/// This is needed because only <see cref="DataView"/>s provide in built mechanisms
		/// to filter their content.
		/// </summary>
		[Browsable(true), DefaultValue(null)]
		[Description("The DataView which should be initially displayed.")]
		public DataView DataSource 
		{
			get { return _grid.DataSource as DataView; }
			set { _grid.DataSource = value; }
		}

		/// <summary>
		/// Controls whether TableStyles are automatically generated.
		/// </summary>
		[Browsable(true), DefaultValue(false)]
		[Description("Controls whether TableStyles are automatically generated.")]
		public bool AutoCreateTableStyles 
		{
			get { return _grid.AutoCreateTableStyles; }
			set { _grid.AutoCreateTableStyles = value; }
		}

		/// <summary>
		/// Gets and sets what information is shown to the user
		/// if an error in the builded filter criterias occurs.
		/// </summary>
		[Browsable(true), DefaultValue(FilterErrorModes.General)]
		[Description("Specifies what information is shown to the user "
			+ "if an error in the builded filter criterias occurs.")]
		public FilterErrorModes MessageErrorMode 
		{
			get { return _extender.MessageErrorMode; }
			set { _extender.MessageErrorMode = value; }
		}

		/// <summary>
		/// Gets and sets what information is printed to the console
		/// if an error in the builded filter criterias occurs.
		/// </summary>
		[Browsable(true), DefaultValue(FilterErrorModes.Off)]
		[Description("Specifies what information is printed to the console "
			 + "if an error in the builded filter criterias occurs.")]
		public FilterErrorModes ConsoleErrorMode 
		{
			get { return _extender.ConsoleErrorMode; }
			set { _extender.ConsoleErrorMode = value; }
		}

		/// <summary>
		/// Gets a modifyable collection which maps <see cref="DataTable.TableName"/>s
		/// to base filter strings which are applied in front of the automatically
		/// created filter.
		/// </summary>
		/// <remarks>
		/// The grid contents is not automatically refreshed when modifying this 
		/// collection. A call to <see cref="RefreshFilters"/> is needed for this.
		/// </remarks>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public StringDictionary BaseFilters
		{
			get { return _extender.BaseFilters; }
		}

		/// <summary>
		/// Gets or sets which operator should be used to combine the base filter
		/// with the automatically created filters.
		/// </summary>
		[Browsable(true), DefaultValue(LogicalOperators.And)]
		[Description("Operator which should be used to combine the base filter "
			 + "with the automatically created filters.")]
		public LogicalOperators BaseFilterOperator
		{
			get { return _extender.BaseFilterOperator; }
			set { _extender.BaseFilterOperator = value; }
		}

		/// <summary>
		/// Gets or sets whether base filters should be used when refreshing
		/// the filter criteria. Setting it to false will disable the functionality
		/// while still keeping the base filter strings in the <see cref="BaseFilters"/>
		/// collection intact.
		/// </summary>
		[Browsable(true), DefaultValue(true)]
		[Description("Gets or sets whether base filters should be used when "
			 + "refreshing the filter criteria.")]
		public bool BaseFilterEnabled
		{
			get { return _extender.BaseFilterEnabled; }
			set { _extender.BaseFilterEnabled = value; }
		}

		/// <summary>
		/// Gets or sets the currently used base filter. Internally it adjusts the
		/// <see cref="BaseFilters"/> collection with the given value and the current
		/// <see cref="DataTable.TableName"/> and also initiates a refresh.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string CurrentTableBaseFilter
		{
			get { return _extender.CurrentTableBaseFilter; }
			set { _extender.CurrentTableBaseFilter = value; }
		}

		/// <summary>
		/// Gets all currently set <see cref="IGridFilter"/>s.
		/// </summary>
		/// <returns>Collection of <see cref="IGridFilter"/>s.</returns>
		public GridFilterCollection GetGridFilters()
		{
			return _extender.GetGridFilters();
		}
	
		/// <summary>
		/// Clears all filters to initial state.
		/// </summary>
		public void ClearFilters() 
		{
			_extender.ClearFilters();
		}
	
		/// <summary>
		/// Gets all filters currently set
		/// </summary>
		/// <returns></returns>
		public string[] GetFilters() 
		{
			return _extender.GetFilters();
		}
	
		/// <summary>
		/// Sets all filters to the specified values.
		/// The values must be in order of the column styles in the current view.
		/// This function should normally be used with data previously coming
		/// from the <see cref="GetFilters"/> function.
		/// </summary>
		/// <param name="filters">filters to set</param>
		public void SetFilters(string[] filters) 
		{
			_extender.SetFilters(filters);
		}

		/// <summary>
		/// Refreshes the filter criteria to match the current contents of the associated
		/// filter controls.
		/// </summary>
		public void RefreshFilters()
		{
			_extender.RefreshFilters();
		}

		#endregion

		#region Protected interface

		/// <summary>
		/// Raises the <see cref="BeforeFiltersChanging"/> event.
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected virtual void OnBeforeFiltersChanging(EventArgs e)
		{
			if (BeforeFiltersChanging != null)
				BeforeFiltersChanging(this, e);
		}

		/// <summary>
		/// Raises the <see cref="AfterFiltersChanged"/> event.
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected virtual void OnAfterFiltersChanged(EventArgs e)
		{
			if (AfterFiltersChanged != null)
				AfterFiltersChanged(this, e);
		}

		/// <summary>
		/// Raises the <see cref="GridFilterBound"/> event.
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected virtual void OnGridFilterBound(GridFilterEventArgs e)
		{
			if (GridFilterBound != null)
				GridFilterBound(this, e);
		}

		/// <summary>
		/// Raises the <see cref="GridFilterUnbound"/> event.
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected virtual void OnGridFilterUnbound(GridFilterEventArgs e)
		{
			if (GridFilterUnbound != null)
				GridFilterUnbound(this, e);
		}

		#endregion

		#region Privates

		private void RepositionGrid() 
		{
			int newTop = _grid.Top;
			int newHeight = _grid.Height;
			int newLeft = 0;
			int newWidth = this.Width;
			switch (_extender.FilterBoxPosition) 
			{
				case FilterPosition.Caption:
				case FilterPosition.Off:
					newTop = 0;
					newHeight = this.Height;
					break;
				case FilterPosition.Top:
					newTop = _extender.NeededControlHeight + 1;
					newHeight = this.Height - newTop - 1;
					break;
				case FilterPosition.Bottom:
					newTop = 0;
					newHeight = this.Height - _extender.NeededControlHeight - 1;
					break;
			}
			
			_grid.SetBounds(newLeft, newTop, newWidth, newHeight, BoundsSpecified.All);
		}

		private void OnAfterFiltersChanged(object sender, EventArgs e)
		{
			OnAfterFiltersChanged(e);
		}

		private void OnBeforeFiltersChanging(object sender, EventArgs e)
		{
			OnBeforeFiltersChanging(e);
		}

		private void OnGridFilterBound(object sender, GridFilterEventArgs e)
		{
			OnGridFilterBound(e);
		}

		private void OnGridFilterUnbound(object sender, GridFilterEventArgs e)
		{
			OnGridFilterUnbound(e);
		}

		#region Event redirectors

		private void OnMouseDown(object sender, MouseEventArgs e)
		{
			base.OnMouseDown(e);
		}

		private void OnMouseEnter(object sender, EventArgs e)
		{
			base.OnMouseEnter(e);
		}

		private void OnMouseHover(object sender, EventArgs e)
		{
			base.OnMouseHover(e);
		}

		private void OnMouseLeave(object sender, EventArgs e)
		{
			base.OnMouseLeave(e);
		}

		private void OnMouseMove(object sender, MouseEventArgs e)
		{
			base.OnMouseMove(e);
		}

		private void OnMouseUp(object sender, MouseEventArgs e)
		{
			base.OnMouseUp(e);
		}

		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			base.OnKeyDown(e);
		}

		private void OnKeyPress(object sender, KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
		}

		private void OnKeyUp(object sender, KeyEventArgs e)
		{
			base.OnKeyUp(e);
		}

		private void OnDoubleClick(object sender, EventArgs e)
		{
			base.OnDoubleClick(e);
		}

		#endregion

		#endregion

		#region Overriden from UserControl

		/// <summary> 
		/// Cleans up.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Repositions the grid to match the new size
		/// </summary>
		/// <param name="e">event arguments</param>
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			RepositionGrid();
		}

		#endregion
	}
}
