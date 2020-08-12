using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller seller = new Seller();
            NewsCompany.Story story1 = new NewsCompany.Story();
            NewsCompany.Story story2 = new NewsCompany.Story();
            NewsCompany.Story story3 = new NewsCompany.Story();
            NewsCompany.Story[] stories = { story1, story2 , story3};

            NewsCompany.NewsPaper paper = new NewsCompany.NewsPaper(stories, 50);
        }
    }
}
