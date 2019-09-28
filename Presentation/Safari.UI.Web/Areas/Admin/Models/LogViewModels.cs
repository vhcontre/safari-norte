
using Safari.Framework.Logging;
using System.Collections.Generic;

namespace Safari.UI.Web.Areas.Admin.Models
{
    public class ListLogViewModel
    {
        public IList<LogEntry> LogFiles { get; set; }
    }
}