using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebTemplate.Code;

namespace XXXXX.Code.Bu
{
    public class AmpBangkokDb : DataAccess
    {
        public AmpBangkok _AmpBangkok; public const string DataText = "AmpBangkokIndex";
        public const string DataValue = "AmpText";

        public List<AmpBangkok> Select()
        {
            string _sql1 = "SELECT * FROM AmpBangkok";
            DataSet ds = Db.GetDataSet(_sql1);
            return DataSetToList(ds);
        }

        public List<AmpBangkok> GetWithFilter(bool sortAscending, string sortExpression)
        {
            throw new Exception("Not implement");
            string sql = "SELECT * FROM AmpBangkok ";
            sql += string.Format("  where ((''='{0}')or(AmpBangkokIndex='{0}'))", _AmpBangkok.AmpBangkokIndex);
            sql += string.Format("  and ((''='{0}')or(AmpText='{0}'))", _AmpBangkok.AmpText);
            sql += string.Format("  and ((''='{0}')or(ENGAmpText='{0}'))", _AmpBangkok.ENGAmpText);
            sql += string.Format("  and ((''='{0}')or(ZoneID='{0}'))", _AmpBangkok.ZoneID);
            sql += string.Format("  and ((''='{0}')or(rowguid='{0}'))", _AmpBangkok.rowguid);
            sql += string.Format("  and ((''='{0}')or(msrepl_tran_version='{0}'))", _AmpBangkok.msrepl_tran_version);
            if (sortExpression == null)
            {
                sql += string.Format(" order by AmpBangkokIndex ", sortExpression);
            }
            else
            {
                Db.SetSort(sortAscending, sortExpression);
            }

            DataSet ds = Db.GetDataSet(sql); return DataSetToList(ds);
        }

        //public List<AmpBangkok> GetPageWise(int pageIndex, int PageSize)
        //{
        //    string _sql1 = "Sp_GetCustomersPageWise";
        //    var prset = new List<IDataParameter>();
        //    prset.Add(Db.CreateParameterDb("@PageIndex", pageIndex));
        //    prset.Add(Db.CreateParameterDb("@PageSize", PageSize));
        //    DataSet ds = Db.GetDataSet(_sql1, prset, CommandType.StoredProcedure);
        //    return DataSetToList(ds);
        //}

        public List<AmpBangkok> GetPageWise(int pageIndex, int PageSize)
        {
            string _sql1 = "Sp_GetAmpBangkokPageWise";
            var prset = new List<IDataParameter>();
            prset.Add(Db.CreateParameterDb("@PageIndex", pageIndex));
            prset.Add(Db.CreateParameterDb("@PageSize", PageSize));
            DataSet ds = Db.GetDataSet(_sql1, prset, CommandType.StoredProcedure);
            return DataSetToList(ds);
        }

        private void Insert()
        {
            var prset = new List<IDataParameter>(); var sql = "INSERT INTO AmpBangkok(AmpBangkokIndex,AmpText,ENGAmpText,ZoneID,rowguid,msrepl_tran_version) VALUES (@AmpBangkokIndex,@AmpText,@ENGAmpText,@ZoneID,@rowguid,@msrepl_tran_version)returning  AmpBangkokIndex;";
            prset.Add(Db.CreateParameterDb("@AmpBangkokIndex", _AmpBangkok.AmpBangkokIndex)); prset.Add(Db.CreateParameterDb("@AmpText", _AmpBangkok.AmpText)); prset.Add(Db.CreateParameterDb("@ENGAmpText", _AmpBangkok.ENGAmpText)); prset.Add(Db.CreateParameterDb("@ZoneID", _AmpBangkok.ZoneID)); prset.Add(Db.CreateParameterDb("@rowguid", _AmpBangkok.rowguid)); prset.Add(Db.CreateParameterDb("@msrepl_tran_version", _AmpBangkok.msrepl_tran_version));

            int output = Db.FbExecuteNonQuery(sql, prset);
            if (output != 1)
            {
                throw new System.Exception("Insert" + this.ToString());
            }
        }

        private void Update()
        {
            var prset = new List<IDataParameter>();
            var sql = @"UPDATE   AmpBangkok SET  AmpBangkokIndex=@AmpBangkokIndex,AmpText=@AmpText,ENGAmpText=@ENGAmpText,ZoneID=@ZoneID,rowguid=@rowguid,msrepl_tran_version=@msrepl_tran_version where AmpBangkokIndex = @AmpBangkokIndex";

            int output = Db.FbExecuteNonQuery(sql, prset);
            if (output != 1)
            {
                throw new System.Exception("Update" + this.ToString());
            }
        }

        private void Delete()
        {
            var prset = new List<IDataParameter>();
            prset.Add(Db.CreateParameterDb("@AmpBangkokIndex", _AmpBangkok.AmpBangkokIndex));
            var sql = @"DELETE FROM AmpBangkok where AmpBangkokIndex=@AmpBangkokIndex";

            int output = Db.FbExecuteNonQuery(sql, prset);
            if (output != 1)
            {
                throw new System.Exception("Delete" + this.ToString());
            }
        }

        private List<AmpBangkok> DataSetToList(DataSet ds)
        {
            EnumerableRowCollection<AmpBangkok> q = (from temp in ds.Tables[0].AsEnumerable()
                                                     select new AmpBangkok
                                                     {
                                                         AmpBangkokIndex = temp.Field<Int32>("AmpBangkokIndex"),
                                                         AmpText = temp.Field<String>("AmpText"),
                                                         ENGAmpText = temp.Field<String>("ENGAmpText"),
                                                         //ZoneID = temp.Field<Int32>("ZoneID"),
                                                         rowguid = temp.Field<Guid>("rowguid"),
                                                         msrepl_tran_version = temp.Field<Guid>("msrepl_tran_version"),
                                                         RecordCount = temp.Field<Int32>("RecordCount"),
                                                     });
            return q.ToList();
        }
    }
}

//Trasaction User
//bool output = false;
//    try
//    {
//        Db.OpenFbData();
//        Db.BeginTransaction();
//        MPO_ORDERS o1 = new MPO_ORDERS();
//o1 = _MPO_ORDERS;
//        int orid = o1.Save();
//MPO_ODERDETAILS o2 = new MPO_ODERDETAILS();
//o2.Save(orid, ODERDETAILS);
//        Db.CommitTransaction();
//        OR_ID = orid;
//        output = true;
//    }
//    catch (System.Exception ex)
//    {
//        Db.RollBackTransaction();
//        ErrorLogging.LogErrorToLogFile(ex, "");
//        throw ex;
//    }
//    return output;