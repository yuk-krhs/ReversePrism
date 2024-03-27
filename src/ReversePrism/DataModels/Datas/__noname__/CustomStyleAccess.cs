using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_CustomProperties                       Dictionary`2<string, StylePropertyValue> IL2CPP_TYPE_GENERICINST
    // 018 M_DpiScaling                             0001866656B0 ModelPrimitiveType float float float Single
    public partial class CustomStyleAccess
    {
        public float                                    M_DpiScaling                            { get; set; }

        public static CustomStyleAccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomStyleAccess();

            value.M_DpiScaling                              = GetSingle(new IntPtr(p + 0x018)); // 0270067F4A50 0x18 M_DpiScaling                ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
