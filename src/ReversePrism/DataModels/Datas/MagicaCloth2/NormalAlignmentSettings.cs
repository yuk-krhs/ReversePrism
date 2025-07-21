using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlignmentMode                            ModelEnumType AlignmentMode AlignmentMode AlignmentMode Int32
    // 018 AdjustmentTransform                      ModelClassType Transform Transform Transform Pointer
    public partial class NormalAlignmentSettings : DataModel
    {
        public AlignmentMode                            AlignmentMode                           { get; set; }
        public Transform?                               AdjustmentTransform                     { get; set; }

        public static NormalAlignmentSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NormalAlignmentSettings() { Pointer= p0 };

            value.AlignmentMode                             = (AlignmentMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 AlignmentMode               ( ModelEnumType AlignmentMode AlignmentMode AlignmentMode Int32 )
            value.AdjustmentTransform                       = GetObject<Transform>(new IntPtr(p + 0x018), ReversePrism.DataModels.Transform.FromPointer); // 0x18 AdjustmentTransform         ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
