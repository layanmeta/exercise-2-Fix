using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal static class NewsPaperCalculator
    {
        internal static int Calc_Number_Of_Chars(NewsPaper paper)
        {
           int  m = 0;
           foreach(Story story in paper.GetStories())
            {
             m+=  story.m_body.Split().Length;
            }
            return m;
        }

        
    }

}
