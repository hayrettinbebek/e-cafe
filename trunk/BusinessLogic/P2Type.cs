using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class P2Type
    {
        
    }

    /*********************************************
    * 
    *   userrights
    * 
    * *******************************************/

    public class clUserRights
    {
        private List<int> fRights = new List<int>();
        private SqlConnection sc;
        private int pUser;

        public clUserRights(SqlConnection iSC, int iUserID)
        {
            pUser = iUserID;
            sc = iSC;
           // FillRightsList();
        }

        private void FillRightsList()
        {
            fRights.Clear();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            if (pUser == -666)
            {
                cmd.CommandText = "select distinct RGH_ID   from _RIGHT_KIND inner join _RIGHTS on _RIGHTS.RGS_RGH_ID=_RIGHT_KIND.RGH_ID  ";
            }

            else
            {
                cmd.CommandText = "select * from _RIGHT_KIND inner join _RIGHTS on _RIGHTS.RGS_RGH_ID=_RIGHT_KIND.RGH_ID " +
                                  "where _RIGHTS.RGS_USR_ID=" + pUser.ToString() + " and _RIGHTS.RGS_RIGHT=1";
            }
            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                fRights.Add(Convert.ToInt32(rdr["RGH_ID"]));
            }
            rdr.Close();
        }

        public bool GetRight(int iRightID)
        {
            return fRights.Contains(iRightID);
        }

        public void RefreshRights(int iUserID)
        {
            pUser = iUserID;
            FillRightsList();
        }
    }


    /*********************************************
    * 
    *   filter
    * 
    * *******************************************/

    public class clFilter
    {
        public string FieldName;
        public string Value;

        public clFilter(string iFieldName, string iValue)
        {
            FieldName = iFieldName;
            Value = iValue;
        }
    }

    /*********************************************
    * 
    *   DayObject
    * 
    * *******************************************/

    public class clDayObject
    {
        public object ListBox;
        public object Button;
        public DateTime Day;
        public List<string> Text = new List<string>();
        public object Cell;
        public int X;
        public int Y;

        public clDayObject()
        {
            ListBox = null;
            Day = DateTime.Now;
            X = 0;
            Y = 0;
        }

        public clDayObject(int iX, int iY, DateTime iDay, object iLB, object iB, object iCell)
        {
            ListBox = iLB;
            Day = iDay;
            Button = iB;
            Cell = iCell;
            X = iX;
            Y = iY;
        }
    }

    public class clDayObjectList
    {
        public List<clDayObject> DayObjects = new List<clDayObject>();

        public clDayObject GetDay(DateTime iDay)
        {
            var L = from O in DayObjects
                    where O.Day.Date.ToString("yyyy.MM.dd") == iDay.ToString("yyyy.MM.dd")
                    select O;
            clDayObject RetD = null;
            if (L.Count() > 0)
            {
                RetD = L.ElementAt(0);
            }
            return RetD;
        }

        public clDayObject GetObject(int iX,int iY)
        {
            var L = from O in DayObjects
                    where O.X==iX && O.Y==iY
                    select O;
            clDayObject RetD = null;
            if (L.Count() > 0)
            {
                RetD = L.ElementAt(0);
            }
            return RetD;
        }

        public List<clDayObject> GetMonth(int iMonth)
        {
            var L = from O in DayObjects
                    where O.Day.Month == iMonth
                    select O;            
            return L.ToList();
        }

        public void SetDay(int iX, int iY, DateTime iD, object iL)
        {
            clDayObject O = GetObject(iX, iY);
            if (O != null)
            {
                O.Day = iD;
                O.ListBox = iL;
            }
        }

        public void SetDay(int iX, int iY, DateTime iD)
        {
            clDayObject O = GetObject(iX, iY);
            if (O != null)
            {
                O.Day = iD;               
            }
        }     
    }

    /*********************************************
     * 
     *   Fieldinfo
     * 
     * *******************************************/
    
    public class clComboListItem
    {
        public string Text;
        public string Value; 
    }

    public class clFIELDINFO
    {
        public string TableName;
        public string FieldName;
        public string DisplayText;
        public bool IsID;
        public bool IsVisible;
        public object Edit;
        public object Edit2;
        public object Edit3;
        public object Edit4;
        public object lEdit;
        public object Devider;
        public List<clComboListItem> ComboList = new List<clComboListItem>();
        public bool IsCombo;
        public bool IsReadOnly;
        public string DefaultValue="";
        public Type DataType;
        public bool IsFileUpLoad;
        
        public clFIELDINFO()
        {
            TableName = "";
            FieldName = "";
            DisplayText = "";
            IsID = false;
            IsVisible = false;
            IsCombo = false;
            ComboList.Clear();
        }

        public clFIELDINFO(string iTableName, string iFieldName, string iDisplayText, bool iIsID, bool iIsVisible)
        {
            TableName = iTableName;
            FieldName = iFieldName;
            DisplayText = iDisplayText;
            IsID = iIsID;
            IsVisible = iIsVisible;
            IsCombo = false;
            ComboList.Clear();
        }
    }

    public class clFIELDINFO_LIST
    {
        public List<clFIELDINFO> lFIELDINFO = new List<clFIELDINFO>();

        public clFIELDINFO_LIST(string iConSTR)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection =  new SqlConnection(iConSTR);
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM DB_FIELDS ORDER BY DF_TABLENAME, DF_INDEX";
            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                clFIELDINFO o = new clFIELDINFO();
                o.TableName = rdr["DF_TABLENAME"].ToString();
                o.FieldName = rdr["DF_FIELDNAME"].ToString();
                o.DisplayText = rdr["DF_DISPLAYTEXT"].ToString();
                o.IsID = Convert.ToInt32(rdr["DF_ISID"]) == 1;
                o.IsVisible = Convert.ToInt32(rdr["DF_ISVISIBLE"]) == 1;
                o.IsCombo = Convert.ToInt32(rdr["DF_ISCOMBO"]) == 1;
                o.IsReadOnly = Convert.ToInt32(rdr["DF_ISREADONLY"]) == 1;
                o.IsFileUpLoad = Convert.ToInt32(rdr["DF_ISFILEUPLOAD"]) == 1;
                lFIELDINFO.Add(o);
            }
            rdr.Close();

            foreach (clFIELDINFO Fi in lFIELDINFO)
            {
                if (Fi.IsCombo)
                {
                    string TableName = "";
                    string DispFieldName = "";
                    string IDFieldName = "";

                    cmd.CommandText = "SELECT * FROM DB_COMBOS WHERE DBC_TABLENAME='"+Fi.TableName+"' AND "+
                        "DBC_FIELDNAME='"+Fi.FieldName+"'";
                     rdr = cmd.ExecuteReader();
                     while (rdr.Read())
                     {
                         TableName = rdr["DBC_CON_TABLENAME"].ToString();
                         DispFieldName = rdr["DBC_CON_DISP_FIELDNAME"].ToString();
                         IDFieldName = rdr["DBC_CON_ID_FIELDNAME"].ToString();
                     }
                     rdr.Close();

                     if (TableName != "" && DispFieldName != "" && IDFieldName != "")
                     {
                         cmd.CommandText = "SELECT " + IDFieldName + ", " + DispFieldName + " FROM " + TableName;
                         clComboListItem LI;
                         rdr = cmd.ExecuteReader();
                         while (rdr.Read())
                         {
                             LI = new clComboListItem();
                             LI.Text = rdr[DispFieldName].ToString();
                             LI.Value = rdr[IDFieldName].ToString();
                             Fi.ComboList.Add(LI);
                         }
                         rdr.Close();
                     }
                }
            }
            cmd.Connection.Close();
        }

        public clFIELDINFO GetIDField(string iTableName)
        {
            foreach (clFIELDINFO FI in lFIELDINFO)
            {
                if (FI.TableName == iTableName && FI.IsID)
                    return FI;
            }
            return null;
        }

        public string GetIDFieldName(string iTableName)
        {
            clFIELDINFO FI = GetIDField(iTableName);
            if (FI != null)
            {
                return FI.FieldName;
            }
            else
            {
                return "";
            }
        }

        public List<clFIELDINFO> GetVisibleFields(string iTableName)
        {
            var L = from m in lFIELDINFO
                    where m.TableName == iTableName && (m.IsVisible || m.DefaultValue!="")
                    select m;
            return L.ToList();            
        }

        public List<clFIELDINFO> GetFields(string iTableName)
        {
            var L = from m in lFIELDINFO
                    where m.TableName == iTableName
                    select m;
            return L.ToList();            
        }

        public clFIELDINFO GetField(string iTableName, string iFieldName)
        {
            var FI = from F in lFIELDINFO
                    where F.TableName == iTableName && F.FieldName == iFieldName
                    select F;
            clFIELDINFO FF=null;
            if (FI.Count() > 0)
            {
                 FF= FI.ElementAt(0);
            }
            return FF;            
        }

        public clFIELDINFO GetField(string iFieldName)
        {
            var FI = from F in lFIELDINFO
                     where F.FieldName == iFieldName
                     select F;
            clFIELDINFO FF = null;
            if (FI.Count() > 0)
            {
                FF = FI.ElementAt(0);
            }
            return FF;
        }


        public clFIELDINFO GetCreatedByField(string iTableName)
        {
            var FI = from F in lFIELDINFO
                     where F.TableName == iTableName && F.FieldName.Contains("_CREATED_BY")
                     select F;
            clFIELDINFO FF = null;
            if (FI.Count() > 0)
            {
                FF = FI.ElementAt(0);
            }
            return FF;
        }     
   
        public clFIELDINFO GetModifiedByField(string iTableName)
        {
            var FI = from F in lFIELDINFO
                     where F.TableName == iTableName && F.FieldName.Contains("_MODIFIED_BY")
                     select F;
            clFIELDINFO FF=null;
            if (FI.Count() > 0)
            {
                FF = FI.ElementAt(0);
            }
            return FF;
        }  
    }

    /*********************************************
     * 
     *   Bussines Logic obj
     * 
     * *******************************************/
    public class TBLObj
    {
        private int fUSR_ID;
        public string User;
        public string strConnectionString;
        public SqlConnection sqlConnection;       
        public TParamList ParamList;
        public clFIELDINFO_LIST FieldInfo;
        public clUserRights UserRights;
        
        public TBLObj()
        {
            this.User = "";
            this.strConnectionString = "";
        }

        public TBLObj(int iUSR_ID, string istrConnectionString, clFIELDINFO_LIST iFieldInfo)
        {
            this.fUSR_ID = iUSR_ID;
            this.strConnectionString = istrConnectionString;
            this.sqlConnection = new SqlConnection(istrConnectionString);
            this.sqlConnection.Open();
            this.FieldInfo = iFieldInfo;
            this.UserRights = new clUserRights(sqlConnection,fUSR_ID);
        }

        public int USR_ID
        {
            get { return fUSR_ID; }
            set
            {
                if (value != fUSR_ID)
                {
                    fUSR_ID = value;
                    UserRights.RefreshRights(fUSR_ID);
                }
            }
        }
    }

    

    /*********************************************
     * 
     *   moduls
     * 
     * *******************************************/
    public class TModule
    {
        public int fModid;
        public int fFirmaid;
        public string fModName;
        public int fModVal;

        public TModule(int iModid, int iFirmaid, string iModName, int iModVal)
        {
            this.fModid = iModid;
            this.fFirmaid = iFirmaid;
            this.fModName = iModName;
            this.fModVal = iModVal;
        }
    }
    public class TModuleList
    {
        public List<TModule> Modules = new List<TModule>();

        public void AddModule(int iModid, int iFirmaid, string iModName, int iModVal)
        {
            TModule Item = new TModule(iModid, iFirmaid, iModName, iModVal);
           
            Modules.Add(Item);
        }
        public void LoadModules(SqlConnection iSqlConnection)
        {
            //SqlConnection sc = new SqlConnection(iConnectionString);
            SqlConnection sc = iSqlConnection;

            SqlCommand cmd = new SqlCommand();

            Modules.Clear ();

            //sc.Open();
            cmd.Connection = sc;
            cmd.CommandText = "SELECT * FROM MOD";
            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                AddModule(Convert.ToInt32(rdr["MODID"].ToString()) , Convert.ToInt32(rdr["FIRMAID"].ToString()) , rdr["MODNAME"].ToString(), Convert.ToInt32(rdr["MODVAL"].ToString()));
            }
            rdr.Close();
        }
        public bool IsModuleSet(string iModuleName)
        {
            bool ItIs = false;
            for (int i = 0 ; (( i <= Modules.Count - 1 ) && (!(ItIs))); ++i)
            {
                ItIs = (Modules[i].fModName == iModuleName);
            }
            return ItIs;
        }
    }

    /*********************************************
     * 
     *   PARAMS
     * 
     * *******************************************/
    public class TParam
    {
        public string fPRM_CODE;
        public string fPRM_TYPE; //S:STRING,I:INTEGER,F:FLOAT,D:DATETIME,B:BOOLEAN (0 or 1)
        public string fPRM_NAME;
        public string fPRM_DESC;
        public string fPRM_VALUE;
        public string fPRM_DEFVALUE;

        public TParam(string iPRM_CODE,string iPRM_TYPE , string iPRM_NAME, string iPRM_DESC, string iPRM_VALUE, string iPRM_DEFVALUE)
        {
            this.fPRM_CODE = iPRM_CODE;
            this.fPRM_TYPE = iPRM_TYPE;
            this.fPRM_NAME = iPRM_NAME;
            this.fPRM_DESC = iPRM_DESC;
            this.fPRM_VALUE = iPRM_VALUE;
            this.fPRM_DEFVALUE = iPRM_DEFVALUE;
        }
    }

    /*********************************************
     * 
     *   ERRORS
     * 
     * *******************************************/
    public class TError
    {
        public string User;
        public Exception Ex; 
        public string Form;
        public string Message;
        public string LongMessage;
        //public string strConnectionString;
        public SqlConnection sqlConnection;
        public bool ShowForm = true;

        //error with user form
        public TError(TBLObj iBLObj, Exception iEx, string iForm, string iMessage)
        {
            this.User = iBLObj.User;
            this.Ex = iEx;
            this.Form = iForm;
            this.Message = iMessage;
            //this.strConnectionString = iBLObj.strConnectionString;
            this.sqlConnection = iBLObj.sqlConnection;
            this.ShowForm = true;
        }
        
        public TError(TBLObj iBLObj, Exception iEx, string iForm, string iMessage, bool iShowForm)
        {
            this.User = iBLObj.User;
            this.Ex = iEx;
            this.Form = iForm;
            this.Message = iMessage;
            this.LongMessage = "";
            //this.strConnectionString = iBLObj.strConnectionString;
            this.sqlConnection = iBLObj.sqlConnection;
            this.ShowForm = iShowForm;
        }

        public TError(string iUser, Exception iEx, string iForm, string iMessage)
        {
            this.User = iUser;
            this.Ex = iEx;
            this.Form = iForm;
            this.Message = iMessage;
            this.LongMessage = "";
            this.ShowForm = true;
        }

        public TError(TBLObj iBLObj, Exception iEx, string iForm, string iMessage, string iLongMessage, bool iShowForm)
        {
            this.User = iBLObj.User; ;
            this.Ex = iEx;
            this.Form = iForm;
            this.Message = iMessage;
            this.LongMessage = iLongMessage;
            this.sqlConnection = iBLObj.sqlConnection;
            this.ShowForm = iShowForm;
        }
    }

    public class TParamList
    {
        public List<TParam> Params = new List<TParam>();

        public void AddParam(string iPRM_CODE,string iPRM_TYPE, string iPRM_NAME, string iPRM_DESC, string iPRM_VALUE, string iPRM_DEFVALUE)
        {
            TParam Item = new TParam(iPRM_CODE, iPRM_TYPE, iPRM_NAME, iPRM_DESC, iPRM_VALUE, iPRM_DEFVALUE);

            Params.Add(Item);
        }
        public void LoadParams(SqlConnection iSqlConnection)
        {
            //SqlConnection sc = new SqlConnection(iConnectionString);
            SqlConnection sc = iSqlConnection;
            SqlCommand cmd = new SqlCommand();

            Params.Clear();

            //sc.Open();
            cmd.Connection = sc;
            cmd.CommandText = "SELECT PRM_CODE, PRM_TYPE, PRM_NAME, PRM_DESC, PRM_VALUE, PRM_DEFVALUE FROM _PARAMS";
            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                AddParam(rdr["PRM_CODE"].ToString(), rdr["PRM_TYPE"].ToString(), rdr["PRM_NAME"].ToString(), rdr["PRM_DESC"].ToString(), rdr["PRM_VALUE"].ToString(), rdr["PRM_DEFVALUE"].ToString());
            }
            rdr.Close();
        }
        public bool GetValueBool(string iParam)
        {
            int i=0;
            bool r = false;
            while ((i <= Params.Count - 1) && (Params[i].fPRM_CODE != iParam))
            {
                ++i;
            }
            if (i != Params.Count)
                r = (Params[i].fPRM_VALUE == "1");
            return  r;        
        }
        public string GetValueStr(string iParam)
        {
            int i=0;
            string s="";
            while ((i <= Params.Count - 1) && (Params[i].fPRM_CODE != iParam))
            {
                ++i;
            }   
            if (i != Params.Count)
                s = Params[i].fPRM_VALUE ;            
            return s;
        }

    }

    /*********************************************
     * 
     *   this object contain the saved fields setting
     * 
     * *******************************************/
    public class TGridColumn
    {
        public string IdentityName; //form + grid  or  different
        public string FieldName;
        public bool Visible;
        public int Width;


        public TGridColumn(string iIdentityName, string iFieldName, bool iVisible, int iWidth)
        {
            this.IdentityName = iIdentityName;
            this.FieldName = iFieldName;
            this.Visible = iVisible;
            this.Width = iWidth;
        }
    }
    public class TGridColumnList
    {
        public List<TGridColumn> Columns = new List<TGridColumn>();

        public void AddColumn(string iIdentityName, string iFieldName, bool iVisible, int iWidth)
        {
            //if it include the field then edit it
            int i;
            bool ItIs = false;
            for (i = 0; i < this.Columns.Count; i++)
            {
                if ((this.Columns[i].IdentityName == iIdentityName) && (this.Columns[i].FieldName == iFieldName))
                {
                    ItIs = true;
                  /*  if (iVisible)
                        MessageBox.Show(iFieldName);*/
                        
                    this.Columns[i].Visible = iVisible;
                    if (iWidth != 0)
                        this.Columns[i].Width = iWidth;
                }
            }
            if (!(ItIs))
            {
                if (iVisible)
                {
                    if (iWidth == 0)
                        iWidth = 100;
                    Columns.Add(new TGridColumn(iIdentityName, iFieldName, iVisible, iWidth));
                }
            }
        }
        //return with false if doesnt exist settings for this grid
        public bool ExistsSettings(string iIdentityName)
        {
            int i = 0;
            bool ItIs = false;
            for (i = 0; i < this.Columns.Count; i++)
            {
                if (this.Columns[i].IdentityName == iIdentityName)
                {
                    ItIs = true;
                }
            }
            return ItIs;
        }
 
        /*********************************************************************
        * return with 1 TGridColumn where IdentityName and FieldName agree  *
        *********************************************************************/
        public bool GetGridColumn(string iIdentityName, string iFieldName, ref TGridColumn gc)
        {
            int i = 0;
            bool ItIs = false;
            for (i = 0; i < this.Columns.Count; i++)
            {
                if ((this.Columns[i].IdentityName == iIdentityName) && (this.Columns[i].FieldName == iFieldName))
                {
                    ItIs = true;
                    gc = new TGridColumn(this.Columns[i].IdentityName, this.Columns[i].FieldName, this.Columns[i].Visible, this.Columns[i].Width);
                }
            }
            return ItIs;
        }
    }
}
