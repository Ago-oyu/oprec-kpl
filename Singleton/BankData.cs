using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class BankData
    {
        private static BankData _instance;

        private BankData() { }

        public static BankData GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BankData();
            }
            return _instance;
        }
    }
}
