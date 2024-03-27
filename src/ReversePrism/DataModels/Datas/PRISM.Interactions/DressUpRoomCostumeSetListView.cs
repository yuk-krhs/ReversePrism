using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CostumeSetListView                       000186633EA0 ModelClassType CostumeSetListView CostumeSetListView CostumeSetListView Pointer
    public partial class DressUpRoomCostumeSetListView
    {
        public CostumeSetListView?                      CostumeSetListView                      { get; set; }

        public static DressUpRoomCostumeSetListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomCostumeSetListView();

            value.CostumeSetListView                        = GetObject<CostumeSetListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeSetListView.FromPointer); // 0270DBC0EA40 0x20 CostumeSetListView          ( 000186633EA0 ModelClassType CostumeSetListView CostumeSetListView CostumeSetListView Pointer )

            return value;
        }
    }
}
