﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xmlToSql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string DirPath;
        Utility utility;

        protected void Page_Load(object sender, EventArgs e)
        {
            utility = new Utility();

            DirPath = Server.MapPath("~/resources/");
        }

        protected void ButtonAddXMLFiles_Click(object sender, EventArgs e)
        {
            ValidateXMLFIles();
            string statusValidation = "";
            utility.InsertXmlDataToDB(DirPath, ref statusValidation);
         //   TextBoxValidationStatus.Text += statusValidation;
            UpdateTablesData();
        }

        // Updates the grid veiw after adding the new data
        protected void UpdateTablesData()
        {
            GridView1.DataBind();
            GridView2.DataBind();
            GridView3.DataBind();
            GridView4.DataBind();
            GridView5.DataBind();
            GridView6.DataBind();
            GridView7.DataBind();
            GridView8.DataBind();
        }

        protected void ButtonDeleteAllData_Click(object sender, EventArgs e)
        {
            utility.DeleteDatabaseRecords();
            TextBoxValidationStatus.Text = "";
            UpdateTablesData();
        }

        protected void ButtonChangeTablesPaging_Click(object sender, EventArgs e)
        {
            GridView1.AllowPaging = !GridView1.AllowPaging;
            GridView2.AllowPaging = !GridView2.AllowPaging;
            GridView3.AllowPaging = !GridView3.AllowPaging;
            GridView4.AllowPaging = !GridView4.AllowPaging;
            GridView5.AllowPaging = !GridView5.AllowPaging;
            GridView6.AllowPaging = !GridView6.AllowPaging;
            GridView7.AllowPaging = !GridView7.AllowPaging;
            GridView8.AllowPaging = !GridView8.AllowPaging;
        }

        protected void ButtonValidate_Click(object sender, EventArgs e)
        {
            ValidateXMLFIles();
        }

        void ValidateXMLFIles()
        {
            string statusValidation = "";
            utility.ValidateXMLFiles(DirPath, ref statusValidation);
            TextBoxValidationStatus.Text = statusValidation;
        }
    }


}