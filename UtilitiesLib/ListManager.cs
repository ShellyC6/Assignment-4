using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCardLib
{
    public class ListManager<T> : IListManager<T>
    {
        protected List<T> m_list;

        public ListManager()
        {
            m_list = new List<T>();
        }

        public List<T> M_list
        {
            get { return m_list; }
            set { m_list = value;  }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < Count(); i++)
            {
                int k = rnd.Next(0, i);
                T value = m_list[k];
                m_list[k] = m_list[i];
                m_list[i] = value;
            }
        }

        public int Count()
        {
            return m_list.Count;
        }

        public bool Add(T aType)
        {
            try
            {
                m_list.Add(aType);
            }
            catch(Exception)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message, "Error"); 
                return false;
            }
            return true;
        }

        public bool DeleteAt(int anIndex)
        {
            try
            {
                m_list.RemoveAt(anIndex);
            }
            catch(Exception)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return false;
            }
            return true;
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            try
            {
                m_list.RemoveAt(anIndex);
                m_list.Insert(anIndex, aType);
            }
            catch(Exception)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return false;
            }
            return true;
        }

        public T GetAt(int anIndex)
        {
            if(anIndex>=0 && anIndex<Count())
                return m_list[anIndex];

            return default(T);
        }

        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < m_list.Count)
                return true;
            else return false;

        }
        public void DeleteAll()
        {
            if(m_list!=null)
                m_list.Clear();
            //m_list = null;
        }
        
        public List<string> ToStringList()
        {
            var aList = new List<String>();
            foreach (var it in m_list)
            {
                aList.Add(it.ToString());
            }
            return aList;
        }

        public string[] ToStringArray()
        {
            string[] anArray = new string[Count()];
            for (int i=0; i<Count(); i++)
            {
                anArray[i] = m_list[i].ToString();
            }
            return anArray;
        }
    }
}