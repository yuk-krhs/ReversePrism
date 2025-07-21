using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseTransform                            ModelClassType Transform Transform Transform Pointer
    // 028 Rate                                     ModelPrimitiveType float float float Single
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

            value.BaseTransform                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 BaseTransform               ( ModelClassType Transform Transform Transform Pointer )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x028)); // 0x28 Rate                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
