using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsCompany;

namespace Store  
    
{
    class Seller 
    {
       
        private float m_Money_Earned;

        public void SellNewsPaper(NewsPaper news)
        {

            m_Money_Earned = m_Money_Earned + news.get_Price();
        }

        public override string ToString()
        {
            return $"money earned is ; {m_Money_Earned}";
        }
    }
}
