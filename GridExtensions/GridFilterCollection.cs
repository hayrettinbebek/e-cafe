using System;
using System.Collections;
using System.Windows.Forms;

namespace GridExtensions
{
	/// <summary>
	/// Typesafe collection of <see cref="IGridFilter"/>s.
	/// </summary>
	public class GridFilterCollection : ReadOnlyCollectionBase
	{
		#region Fields

		private Hashtable _columnStylesToGridFiltersHash;

		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="columnStyles">List of <see cref="DataGridColumnStyle"/> which are associated with <see cref="IGridFilter"/>s.</param>
		/// <param name="columnStylesToGridFiltersHash">Mapping between <see cref="DataGridColumnStyle"/> and <see cref="IGridFilter"/>s.</param>
		internal GridFilterCollection(IList columnStyles, Hashtable columnStylesToGridFiltersHash) 
		{
			_columnStylesToGridFiltersHash = (Hashtable)columnStylesToGridFiltersHash.Clone();
			
			foreach (DataGridColumnStyle columnStyle in columnStyles)
			{
				IGridFilter gridFilter = (IGridFilter)_columnStylesToGridFiltersHash[columnStyle];
				if (gridFilter != null)
					base.InnerList.Add(gridFilter);
			}
		}

		#endregion

		#region Public interface

		/// <summary>
		/// Determines whether a given <see cref="IGridFilter"/> is contained in this instance.
		/// </summary>
		/// <param name="gridFilter"><see cref="IGridFilter"/> to be checked.</param>
		/// <returns>True if <see cref="IGridFilter"/> is contained in this instance otherwise False.</returns>
		public bool Contains(IGridFilter gridFilter)
		{
			return base.InnerList.Contains(gridFilter);
		}

		/// <summary>
		/// Gets the element at the specified index.
		/// </summary>
		public IGridFilter this[int index]
		{
			get { return (IGridFilter)base.InnerList[index]; }
		}

		/// <summary>
		/// Gets the <see cref="IGridFilter"/> which is associated with the given <see cref="DataGridColumnStyle"/>.
		/// </summary>
		public IGridFilter this[DataGridColumnStyle columnStyle]
		{
			get 
			{
				if (base.InnerList.Contains(_columnStylesToGridFiltersHash[columnStyle]))
					return (IGridFilter)_columnStylesToGridFiltersHash[columnStyle];
				else
					return null;
			}
		}

		/// <summary>
		/// Gets a <see cref="IGridFilter"/> which is associated with a <see cref="DataGridColumnStyle"/>
		/// with the specified <see cref="DataGridColumnStyle.MappingName"/>.
		/// </summary>
		/// <param name="mappingName"><see cref="DataGridColumnStyle.MappingName"/></param>
		/// <returns>An <see cref="IGridFilter"/> or null if no appropriate was found.</returns>
		public IGridFilter GetByMappingName(string mappingName)
		{
			foreach (DataGridColumnStyle columnStyle in _columnStylesToGridFiltersHash.Keys)
				if (columnStyle.MappingName == mappingName)
					return this[columnStyle];
			return null;
		}

		/// <summary>
		/// Gets a <see cref="IGridFilter"/> which is associated with a <see cref="DataGridColumnStyle"/>
		/// with the specified <see cref="DataGridColumnStyle.HeaderText"/>.
		/// </summary>
		/// <param name="headerText"><see cref="DataGridColumnStyle.HeaderText"/></param>
		/// <returns>An <see cref="IGridFilter"/> or null if no appropriate was found.</returns>
		public IGridFilter GetByHeaderText(string headerText)
		{
			foreach (DataGridColumnStyle columnStyle in _columnStylesToGridFiltersHash.Keys)
				if (columnStyle.HeaderText == headerText)
					return this[columnStyle];
			return null;
		}

		/// <summary>
		/// Creates a filtered list which only contains <see cref="IGridFilter"/>s of the specified type.
		/// </summary>
		/// <param name="dataType">Type by which should be filtered.</param>
		/// <param name="exactMatch">Defines whether the types must match exactly
		/// (otherwise inheriting types will also be returned).</param>
		/// <returns>Collection of matching <see cref="IGridFilter"/>s.</returns>
		public GridFilterCollection FilterByGridFilterType(Type dataType, bool exactMatch)
		{
			if (!typeof(IGridFilter).IsAssignableFrom(dataType))
				throw new ArgumentException("Given type must implement IGridFilter.", "dataType");
			ArrayList filtered = new ArrayList();
			foreach (DataGridColumnStyle columnStyle in _columnStylesToGridFiltersHash.Keys)
				if (this[columnStyle] != null && (this[columnStyle].GetType().Equals(dataType) 
					|| (!exactMatch && dataType.IsAssignableFrom(this[columnStyle].GetType()))))
				{
					filtered.Add(columnStyle);
				}
			return new GridFilterCollection(filtered, _columnStylesToGridFiltersHash);
		}

		#endregion
	}
}
