using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgrammaticFiltering.Models;

namespace ProgrammaticFiltering
{
    public class ProgrammaticFilteringService : IProgrammaticFilteringService
    {
        private Dictionary<string, ProgrammaticFilter> filters = new Dictionary<string, ProgrammaticFilter>();

        public ProgrammaticFilteringService() {
            filters.Add("mike@test.com",
                new ProgrammaticFilter
                    {
                    ClientId = "360656ef-bc83-49af-af96-4b66c8995598",
                    ClientSecret = "8d9bb0164ff977e289fab4d47a1d2f72671e9d9640cd842a23c2625cea03b9aa",
                    Filter = "[{\"column\":\"Dealer Code\",\"operator\":\"IN\",\"values\":[\"corning\"]},{\"column\":\"Reporting Date\",\"operator\":\"BETWEEN\",\"values\":[\"08/01/2019\",\"08/31/2020\"]}]",
                    EmbedId = "311Q4",/* 311Q4 Dev - Dealer Inventory Counts(Monthly Reporting)*/
                    EmbedId2 = "QWWkM", /* QWWkM Dev - Work Truck Movement Trend */
                    EmbedId3 = "jRR7l", /* jRR7l Dev - Top Work Truck Body Type Searches(Test Monthly Data)*/                    
                    EmbedId4 = "lYYjr" /* lYYjr Dev - Leads by Source and Type (Combined Leads - Dealer) */
                });
            filters.Add("susan@test.com",
                    new ProgrammaticFilter
                    {
                        ClientId = "360656ef-bc83-49af-af96-4b66c8995598",
                        ClientSecret = "8d9bb0164ff977e289fab4d47a1d2f72671e9d9640cd842a23c2625cea03b9aa",
                        Filter = "[{\"column\":\"Dealer Code\",\"operator\":\"IN\",\"values\":[\"paradiseautos\"]},{\"column\":\"Reporting Date\",\"operator\":\"BETWEEN\",\"values\":[\"08/01/2019\",\"08/31/2020\"]}]",
                        EmbedId = "rkkq4",
                        EmbedId2 = "QWWkM",
                        EmbedId3 = "jRR7l", /* jRR7l Dev - Top Work Truck Body Type Searches(Test Monthly Data)*/
                        EmbedId4 = "lYYjr" /* lYYjr Dev - Leads by Source and Type (Combined Leads - Dealer) */
                    });
            filters.Add("tom@test.com",
                    new ProgrammaticFilter
                    {
                        ClientId = "360656ef-bc83-49af-af96-4b66c8995598",
                        ClientSecret = "8d9bb0164ff977e289fab4d47a1d2f72671e9d9640cd842a23c2625cea03b9aa",
                        Filter = "[{\"column\":\"Dealer Code\",\"operator\":\"IN\",\"values\":[\"ryder\"]},{\"column\":\"Reporting Date\",\"operator\":\"BETWEEN\",\"values\":[\"08/01/2019\",\"08/31/2020\"]}]",
                        EmbedId = "311Q4",/* 311Q4 Dev - Dealer Inventory Counts(Monthly Reporting)*/
                        EmbedId2 = "QWWkM", /* QWWkM Dev - Work Truck Movement Trend */
                        EmbedId3 = "jRR7l", /* jRR7l Dev - Top Work Truck Body Type Searches(Test Monthly Data)*/
                        EmbedId4 = "lYYjr" /* lYYjr Dev - Leads by Source and Type (Combined Leads - Dealer) */
                    });
        }

        public ProgrammaticFilter getProgrammaticFilter(string username)
        {
            if (!filters.TryGetValue(username, out ProgrammaticFilter filter))
            {
                return new ProgrammaticFilter();
            }
            return filters[username];
        }
    }
}