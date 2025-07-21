using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CostumeGridView                          ModelClassType CostumeGridView CostumeGridView CostumeGridView Pointer
    public partial class DressUpRoomCostumeListView : DataModel
    {
        public CostumeGridView?                         CostumeGridView                         { get; set; }

        public static DressUpRoomCostumeListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomCostumeListView() { Pointer= p0 };

            value.CostumeGridView                           = GetObject<CostumeGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeGridView.FromPointer); // 0x20 CostumeGridView             ( ModelClassType CostumeGridView CostumeGridView CostumeGridView Pointer )

            return value;
        }
    }
}
