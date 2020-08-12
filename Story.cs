using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
   public class Story
    {
        public string m_title;
       public string m_body;
        public string m_visual_style;

        public override string ToString()
        {
            return $"Title: {m_title}, Body: {m_body}, Visual Style: {m_visual_style}";
        }
    }
}
