using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SourceTransform                        0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 018 M_Weight                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class ConstraintSource
    {
        public Transform?                               M_SourceTransform                       { get; set; }
        public float                                    M_Weight                                { get; set; }

        public static ConstraintSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstraintSource();

            value.M_SourceTransform                         = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 02700224AA30 0x10 M_SourceTransform           ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.M_Weight                                  = GetSingle(new IntPtr(p + 0x018)); // 02700224AA50 0x18 M_Weight                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
