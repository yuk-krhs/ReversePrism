using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseTransform                            0001866AA650 ModelClassType Transform Transform Transform Pointer
    public partial class PositionConstrainLate
    {
        public Transform?                               BaseTransform                           { get; set; }

        public static PositionConstrainLate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PositionConstrainLate();

            value.BaseTransform                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270072CFC28 0x20 BaseTransform               ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
