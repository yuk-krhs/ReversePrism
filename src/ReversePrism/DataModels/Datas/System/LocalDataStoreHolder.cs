using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Store                                  ModelClassType LocalDataStore LocalDataStore LocalDataStore Pointer
    public partial class LocalDataStoreHolder : DataModel
    {
        public LocalDataStore?                          M_Store                                 { get; set; }

        public static LocalDataStoreHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalDataStoreHolder() { Pointer= p0 };

            value.M_Store                                   = GetObject<LocalDataStore>(new IntPtr(p + 0x010), ReversePrism.DataModels.LocalDataStore.FromPointer); // 0x10 M_Store                     ( ModelClassType LocalDataStore LocalDataStore LocalDataStore Pointer )

            return value;
        }
    }
}
