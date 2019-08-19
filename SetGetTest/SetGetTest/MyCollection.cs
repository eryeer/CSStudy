using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGetTest
{
    class AddressInfo
    {
        public string Add;
        public string Tel;
    }
    class MyCollection : KeyedCollection<string, AddressInfo>
    {
        protected override string GetKeyForItem(AddressInfo item)
        {
            return item.Add;
        }
    }


}
