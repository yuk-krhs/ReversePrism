using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseTransform                            0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 028 X_rot                                    000186666050 ModelPrimitiveType float float float Single
    // 02C Rot_scale                                0001866656B0 ModelPrimitiveType float float float Single
    // 030 Center_rot                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class XRotConstrain : DataModel
    {
        public Transform?                               BaseTransform                           { get; set; }
        public float                                    X_rot                                   { get; set; }
        public float                                    Rot_scale                               { get; set; }
        public float                                    Center_rot                              { get; set; }

        public static XRotConstrain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRotConstrain() { Pointer= p0 };

            value.BaseTransform                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0245A69CE418 0x20 BaseTransform               ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.X_rot                                     = GetSingle(new IntPtr(p + 0x028)); // 0245A69CE438 0x28 X_rot                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Rot_scale                                 = GetSingle(new IntPtr(p + 0x02C)); // 0245A69CE458 0x2C Rot_scale                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Center_rot                                = GetSingle(new IntPtr(p + 0x030)); // 0245A69CE478 0x30 Center_rot                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
