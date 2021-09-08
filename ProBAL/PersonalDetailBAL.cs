using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProBE;
using ProDAL;

namespace ProBAL
{
    public class PersonalDetailBAL
    {
        public DataView LoadAll(bool isAdult)
        {
            DataTable table = new PersonalDetailDAL().LoadAll();
            DataView view = new DataView(table);

            if (isAdult)
            {
                view.RowFilter = " Age >= 20";
            }
            else
            {
                view.RowFilter = " Age < 20";
            }
            return view;
        }

        public DataTable Search(string firstName)
        {
            return new PersonalDetailDAL().Search(firstName);
        }


        /// <summary>
        /// insert a record into the PersonalDetail table
        /// </summary>
        /// <param name="person">PersonalDetail object</param>
        /// <returns></returns>
        public int AddRecord(PersonalDetail person)
        {
            return new PersonalDetailDAL().AddRecord(person);
        }
    }
}
