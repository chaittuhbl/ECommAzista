using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class CategoriesReference
    {
        public double? GroupId { get; set; }
        public string GroupName { get; set; }
        public double? SubCategoryId { get; set; }
        public string Subcategory { get; set; }
        public string HealthIssuesId { get; set; }
        public string HealthIssues { get; set; }
    }
}
