using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 typeMap                                  Dictionary`2<int, ArraySegment`1<sbyte>> IL2CPP_TYPE_GENERICINST
    // 018 groupMap                                 Dictionary`2<int, uint> IL2CPP_TYPE_GENERICINST
    // 020 groupRelations                           Dictionary`2<uint, List`1<int>> IL2CPP_TYPE_GENERICINST
    // 028 Entries                                  000185B737F0 ModelEnumListType CatalogBinaryEntry[] CatalogBinaryEntry[] List<CatalogBinaryEntry> Pointer
    public partial class CatalogBinaryParser
    {
        public List<CatalogBinaryEntry>?                Entries                                 { get; set; }

        public static CatalogBinaryParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogBinaryParser();

            value.Entries                                   = GetEnumList<CatalogBinaryEntry>(new IntPtr(p + 0x028)); // 0270DBCCC860 0x28 Entries                     ( 000185B737F0 ModelEnumListType CatalogBinaryEntry[] CatalogBinaryEntry[] List<CatalogBinaryEntry> Pointer )

            return value;
        }
    }
}
