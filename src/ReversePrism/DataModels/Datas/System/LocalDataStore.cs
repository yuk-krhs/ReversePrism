using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DataTable                              000185B92140 ModelClassListType LocalDataStoreElement[] LocalDataStoreElement[] List<LocalDataStoreElement> Pointer
    // 018 M_Manager                                0001865A43A0 ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer
    public partial class LocalDataStore : DataModel
    {
        public List<LocalDataStoreElement>?             M_DataTable                             { get; set; }
        public LocalDataStoreMgr?                       M_Manager                               { get; set; }

        public static LocalDataStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalDataStore() { Pointer= p0 };

            value.M_DataTable                               = GetObjectList<LocalDataStoreElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.LocalDataStoreElement.FromPointer); // 0245A153F1D8 0x10 M_DataTable                 ( 000185B92140 ModelClassListType LocalDataStoreElement[] LocalDataStoreElement[] List<LocalDataStoreElement> Pointer )
            value.M_Manager                                 = GetObject<LocalDataStoreMgr>(new IntPtr(p + 0x018), ReversePrism.DataModels.LocalDataStoreMgr.FromPointer); // 0245A153F1F8 0x18 M_Manager                   ( 0001865A43A0 ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer )

            return value;
        }
    }
}
