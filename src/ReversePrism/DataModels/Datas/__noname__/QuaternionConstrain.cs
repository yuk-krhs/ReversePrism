using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseTransform                            0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 028 Rate                                     000186666050 ModelPrimitiveType float float float Single
    public partial class QuaternionConstrain : DataModel
    {
        public Transform?                               BaseTransform                           { get; set; }
        public float                                    Rate                                    { get; set; }

        public static QuaternionConstrain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuaternionConstrain() { Pointer= p0 };

            value.BaseTransform                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0245A69E5340 0x20 BaseTransform               ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x028)); // 0245A69E5360 0x28 Rate                        ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
