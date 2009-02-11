namespace e_Cafe {
    
    
    public partial class ECAFEDataSetBEVETELEZES {
        partial class BEVETEL_SORDataTable
        {
        
    
        




            public BEVETEL_SORRow AddSORRow(int fej_id)
            {
                BEVETEL_SORRow rowSORRow = ((BEVETEL_SORRow)(NewRow()));
                rowSORRow.BEVETEL_FEJ_ID = fej_id;
                object[] columnValuesArray = new object[] {null,
                        fej_id
                        ,null,null,null,null,null,null,null,null,null};
                rowSORRow.ItemArray = columnValuesArray;
                
                Rows.Add(rowSORRow);
                return rowSORRow;
            }
        }
    }
}

namespace e_Cafe.ECAFEDataSetBEVETELEZESTableAdapters {
    
    
    public partial class BEVETEL_FEJTableAdapter {
    }
}
