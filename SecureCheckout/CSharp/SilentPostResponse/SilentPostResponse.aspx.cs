using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace SilentPostResponse
{
    public partial class SilentPostResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.RequestType == "POST")
                {
                    using (StreamReader reader = new StreamReader(Request.InputStream))
                    {
                        string rawpost = reader.ReadToEnd();
                        string paramslist = Server.UrlDecode(rawpost);

                        ParseAndSaveParamList(paramslist.Replace("parmList=", ""));
                    }
                }

            }// if it blows up we want to save the exception to view
            catch (Exception ex) { SaveException(ex); }

        }

        /// <summary>
        /// Saves the exeption as a in a post object message field.
        /// </summary>
        /// <param name="e">The exception we want to save </param>
        private void SaveException(Exception e)
        {
            Post ex_post = new Post();
            ex_post.Message = e.Message;
            ex_post.Date = DateTime.Now;

            PostModelEntities PostModel = new PostModelEntities();
            PostModel.AddToPosts(ex_post);

            PostModel.SaveChanges();
        }


        /// <summary>
        /// Parse parameter list to post object and save to database
        /// </summary>
        /// <param name="ParameterString"></param>
        private void ParseAndSaveParamList(string ParameterString)
        {
            var parameters = ParameterString.Split('|');
            Dictionary<string, string> ParameterList = new Dictionary<string, string>();

            foreach (var KeyValuePair in parameters)
            {
                var pair = KeyValuePair.Split('~');
                if (pair != null && pair.Length > 1)
                {
                    if (pair[0] != null && pair[1] != null)
                    {
                        ParameterList.Add(pair[0], pair[1]);
                    }
                }
            }

            // create a post object and save
            Post new_post = new Post();
            new_post.OrderID = ParameterList["ORDERID"];
            new_post.TransactionID = ParameterList["TRANSACTIONID"];
            new_post.AppCode = ParameterList["APPCODE"];
            new_post.Message = ParameterList["APPMSG"];
            new_post.Date = DateTime.Now;

            PostModelEntities PostModel = new PostModelEntities();
            PostModel.AddToPosts(new_post);

            PostModel.SaveChanges();
        }


    }
}