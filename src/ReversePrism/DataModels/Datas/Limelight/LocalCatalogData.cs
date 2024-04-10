using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Entries                                  LocalCatalogEntry[] IL2CPP_TYPE_SZARRAY
    // 008 AddressMap                               Dictionary`2<ulong, ulong> IL2CPP_TYPE_GENERICINST
    // 010 IndexMap                                 Dictionary`2<ulong, int> IL2CPP_TYPE_GENERICINST
    public partial class LocalCatalogData : DataModel
    {

        public static LocalCatalogData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalCatalogData() { Pointer= p0 };


            return value;
        }
    }
}
