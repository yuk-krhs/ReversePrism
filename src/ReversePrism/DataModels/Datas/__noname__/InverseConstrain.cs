using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseTransform                            ModelClassType Transform Transform Transform Pointer
    // 028 X_inv                                    ModelPrimitiveType float float float Single
    public partial class InverseConstrain : DataModel
    {
        public Transform?                               BaseTransform                           { get; set; }
        public float                                    X_inv                                   { get; set; }

        public static InverseConstrain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InverseConstrain() { Pointer= p0 };

            value.BaseTransform                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 BaseTransform               ( ModelClassType Transform Transform Transform Pointer )
            value.X_inv                                     = GetSingle(new IntPtr(p + 0x028)); // 0x28 X_inv                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
