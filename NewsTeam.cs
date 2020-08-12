using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
   internal abstract class NewsTeam
    {
        protected Story m_Story;

       internal abstract void CreatStory();
        internal Story GetStory()
        {
            return m_Story;
        }

        internal virtual void AddStyle()
        {
            m_Story.m_body = "News";
            m_Story.m_title = "News ";
        }

        public override string ToString()
        {
            return $"the story is : {m_Story}";
        }

    }
}
