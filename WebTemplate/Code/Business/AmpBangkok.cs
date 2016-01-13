using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebTemplate.Code.Business;

namespace XXXXX.Code.Bu
{
    public class AmpBangkok : BaseProperties
    {
        private Int32 _AmpBangkokIndex;
        public Int32 AmpBangkokIndex { get { return _AmpBangkokIndex; } set { _AmpBangkokIndex = value; } }

        private String _AmpText;
        public String AmpText { get { return _AmpText; } set { _AmpText = value; } }

        private String _ENGAmpText;
        public String ENGAmpText { get { return _ENGAmpText; } set { _ENGAmpText = value; } }

        private Int32 _ZoneID;
        public Int32 ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

        private Guid _rowguid;
        public Guid rowguid { get { return _rowguid; } set { _rowguid = value; } }

        private Guid _msrepl_tran_version;
        public Guid msrepl_tran_version { get { return _msrepl_tran_version; } set { _msrepl_tran_version = value; } }
    }
}