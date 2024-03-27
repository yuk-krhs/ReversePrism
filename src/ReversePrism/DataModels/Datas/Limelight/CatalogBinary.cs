using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <GroupRelations>k__BackingField          Dictionary`2<uint, List`1<int>> IL2CPP_TYPE_GENERICINST
    // 018 Entries                                  000185B739E0 ModelEnumListType CatalogBinaryEntry[] CatalogBinaryEntry[] List<CatalogBinaryEntry> Pointer
    public partial class CatalogBinary
    {
        public List<CatalogBinaryEntry>?                Entries                                 { get; set; }

        public static CatalogBinary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogBinary();

            value.Entries                                   = GetEnumList<CatalogBinaryEntry>(new IntPtr(p + 0x018)); // 0270DB4DE040 0x18 Entries                     ( 000185B739E0 ModelEnumListType CatalogBinaryEntry[] CatalogBinaryEntry[] List<CatalogBinaryEntry> Pointer )

            return value;
        }
    }
}
