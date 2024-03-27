using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_Owner                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 M_WrapEventAttribute                     000186762990 ModelClassType VFXEventAttribute VFXEventAttribute VFXEventAttribute Pointer
    public partial class VFXSpawnerState
    {
        public bool                                     M_Owner                                 { get; set; }
        public VFXEventAttribute?                       M_WrapEventAttribute                    { get; set; }

        public static VFXSpawnerState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXSpawnerState();

            value.M_Owner                                   = GetBool(new IntPtr(p + 0x018)); // 0270021A2980 0x18 M_Owner                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_WrapEventAttribute                      = GetObject<VFXEventAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.VFXEventAttribute.FromPointer); // 0270021A29A0 0x20 M_WrapEventAttribute        ( 000186762990 ModelClassType VFXEventAttribute VFXEventAttribute VFXEventAttribute Pointer )

            return value;
        }
    }
}
