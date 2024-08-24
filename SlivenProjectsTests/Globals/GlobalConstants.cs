using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Globals
{
    public class GlobalConstants
    {
        //The base URL of the target site/app
        public const string BASE_URL = "https://projects.sliven.bg/";
        //The default timeout for the explicit waits in seconds
        public const int DEFAULT_TIMEOUT = 10;
        //The title of the project for the Exceptions' message
        //handlings description messages
        public const string PR_TITLE = "SLIVEN_PROJECTS_TESTS";
    }
}
