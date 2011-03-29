using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gramps.Core.Domain;

namespace Gramps.Tests.Core.Helpers
{
    public static class CreateValidEntities
    {
        #region Helper Extension

        private static string Extra(this int? counter)
        {
            var extraString = "";
            if (counter != null)
            {
                extraString = counter.ToString();
            }
            return extraString;
        }

        #endregion Helper Extension

        public static Example Example(int? counter, bool populateAllFields = false)
        {
            var rtValue = new Example();
            rtValue.Name = "Name" + counter.Extra();
            rtValue.EndDate = DateTime.Now.Date.AddDays(30);
            rtValue.IsActive = true;
            rtValue.ProposalMaximum = 0.01m;

            return rtValue;
        }

    }
}
