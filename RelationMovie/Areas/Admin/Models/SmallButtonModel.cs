using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RelationMovie.Areas.Admin.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }

        public string Text { get; set; }

        public string Glyph { get; set; }

        public string ButtonType { get; set; }

        public int? Id { get; set; }

        public int? ItemId { get; set; }

        public int? ProductId { get; set; }

        public int? SubscriptionId { get; set; }

        public string ActionParameter {
            get
            {
                var parame = new StringBuilder("?");
                if (Id != null && Id > 0)
                    parame.Append(String.Format("{0}={1}&", "id", Id));

                if (Id != null && ItemId > 0)
                    parame.Append(String.Format("{0}={1}&", "itemid", ItemId));

                if (Id != null && ProductId > 0)
                    parame.Append(String.Format("{0}={1}&", "productid", ProductId));

                if (Id != null && SubscriptionId > 0)
                    parame.Append(String.Format("{0}={1}&", "subscriptionid", SubscriptionId));

                return parame.ToString().Substring(0, parame.Length - 1);
            }
        }
        
    }
}