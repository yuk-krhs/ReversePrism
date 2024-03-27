using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RowBase                                  0001866F1650 ModelClassType UIRotatedGridRowView UIRotatedGridRowView UIRotatedGridRowView Pointer
    // 028 PoolParent                               0001866AADB0 ModelClassType Transform Transform Transform Pointer
    public partial class RotatedGridViewRowPool
    {
        public UIRotatedGridRowView?                    RowBase                                 { get; set; }
        public Transform?                               PoolParent                              { get; set; }

        public static RotatedGridViewRowPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RotatedGridViewRowPool();

            value.RowBase                                   = GetObject<UIRotatedGridRowView>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRotatedGridRowView.FromPointer); // 0270D54AAF40 0x20 RowBase                     ( 0001866F1650 ModelClassType UIRotatedGridRowView UIRotatedGridRowView UIRotatedGridRowView Pointer )
            value.PoolParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270D54AAF60 0x28 PoolParent                  ( 0001866AADB0 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
