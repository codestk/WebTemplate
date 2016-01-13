using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using XXXXX.Code.Bu;

namespace WebTemplate
{
    public partial class Repeater : System.Web.UI.Page
    {
        private int PageSize = 10;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GetPageWise(1);
            }
        }

        private void GetPageWise(int pageIndex)
        {
            AmpBangkokDb Db = new AmpBangkokDb();
            var result = Db.GetPageWise(pageIndex, PageSize);
            int recordCount = result[0].RecordCount;
            this.PopulatePager(recordCount, pageIndex);
            rptCustomers.DataSource = result;
            rptCustomers.DataBind();
        }

        private void PopulatePager(int recordCount, int currentPage)
        {
            double dblPageCount = (double)((decimal)recordCount / (PageSize));
            int pageCount = (int)Math.Ceiling(dblPageCount);
            List<ListItem> pages = new List<ListItem>();
            if (pageCount > 0)
            {
                ListItem First = new ListItem("<i class='material-icons'>chevron_left</i>", "1", currentPage > 1);
                //    First.Attributes.Add("class", "material-icons");

                pages.Add(First);
                for (int i = 1; i <= pageCount; i++)
                {
                    pages.Add(new ListItem(i.ToString(), i.ToString(), i != currentPage));
                }
                pages.Add(new ListItem("<i class='material-icons'>chevron_right</i>", pageCount.ToString(), currentPage < pageCount));
            }
            rptPager.DataSource = pages;
            rptPager.DataBind();
        }

        protected void Page_Changed(object sender, EventArgs e)
        {
            int pageIndex = int.Parse((sender as LinkButton).CommandArgument);
            this.GetPageWise(pageIndex);
        }

        public string LiPaggerClass(object Enabled, object Value)
        {
            string output = "";
            Boolean isfirst = Value.ToString().ToLower().Contains("chevron_left");
            Boolean isend = Value.ToString().ToLower().Contains("chevron_right");
            if ((isfirst == true) && (Enabled.ToString().ToLower() == "false"))
            {
                return "disabled";
            }

            if ((isend == true) && (Enabled.ToString().ToLower() == "false"))
            {
                return "disabled";
            }

            string classLidisabled = "active";
            string claapageitem = "waves-effect";

            if (Enabled.ToString().ToLower() == "false")
            {
                output = classLidisabled;
            }
            else
            { output = claapageitem; }
            return output;
        }
    }
}