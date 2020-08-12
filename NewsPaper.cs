using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class NewsPaper
    {
       private Story[] m_stories;
       private float m_price;

        public Story[] GetStories()
        {
            return m_stories;
        }

        public void set_Stories(Story[] stories)
        {
            m_stories = stories;
        }

        public float get_Price()
        {
            return m_price;
        }
            
        public void set_Price(float f)
        {
            m_price = f;
        }
        public NewsPaper(Story[] m_stories, float m_price)
        {
            this.m_stories = m_stories;
            this.m_price = m_price;
            

        }

        public override string ToString()
        {
            return $"stories {m_stories}, price : {m_price}, {get_Price()}";
        }
    }
}
