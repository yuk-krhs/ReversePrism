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
    // 020 M_VfxAsset                               000186528690 ModelClassType VisualEffectAsset VisualEffectAsset VisualEffectAsset Pointer
    public partial class VFXEventAttribute
    {
        public bool                                     M_Owner                                 { get; set; }
        public VisualEffectAsset?                       M_VfxAsset                              { get; set; }

        public static VFXEventAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXEventAttribute();

            value.M_Owner                                   = GetBool(new IntPtr(p + 0x018)); // 027002198F10 0x18 M_Owner                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_VfxAsset                                = GetObject<VisualEffectAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualEffectAsset.FromPointer); // 027002198F30 0x20 M_VfxAsset                  ( 000186528690 ModelClassType VisualEffectAsset VisualEffectAsset VisualEffectAsset Pointer )

            return value;
        }
    }
}
