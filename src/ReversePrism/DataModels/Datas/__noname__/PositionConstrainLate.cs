using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseTransform                            ModelClassType Transform Transform Transform Pointer
    public partial class PositionConstrainLate : DataModel
    {
        public Transform?                               BaseTransform                           { get; set; }

        public static PositionConstrainLate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PositionConstrainLate() { Pointer= p0 };

            value.BaseTransform                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 BaseTransform               ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
