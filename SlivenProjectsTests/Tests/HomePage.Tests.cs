using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class HomePage : BaseTests
    {
        
    }

    [Test]
    public void TopMenuTextsShouldBeProper()
    {
        HomePage homePage = new HomePage();
        var results = homePage.TopMenuTexts();
    }

    
}
