using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DebuggerDisplay                        string IL2CPP_TYPE_STRING
    // 010 M_OverrideState                          ModelPrimitiveType bool bool bool Bool
    public partial class VolumeParameter : DataModel
    {
        public bool                                     M_OverrideState                         { get; set; }

        public static VolumeParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolumeParameter() { Pointer= p0 };

            value.M_OverrideState                           = GetBool(new IntPtr(p + 0x010)); // 0x10 M_OverrideState             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
