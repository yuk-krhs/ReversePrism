using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NeedAnimationOnShow                      ModelPrimitiveType bool bool bool Bool
    // 018 InitScreenParameter                      ModelClassType IMobileScreenParameter IMobileScreenParameter IMobileScreenParameter Pointer
    // 020 <PrevScreenParameters>k__BackingField    IEnumerable`1<IMobileScreenParameter> IL2CPP_TYPE_GENERICINST
    public partial class MobileOverlaySequencerParameter : DataModel
    {
        public bool                                     NeedAnimationOnShow                     { get; set; }
        public IMobileScreenParameter?                  InitScreenParameter                     { get; set; }

        public static MobileOverlaySequencerParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileOverlaySequencerParameter() { Pointer= p0 };

            value.NeedAnimationOnShow                       = GetBool(new IntPtr(p + 0x010)); // 0x10 NeedAnimationOnShow         ( ModelPrimitiveType bool bool bool Bool )
            value.InitScreenParameter                       = GetObject<IMobileScreenParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMobileScreenParameter.FromPointer); // 0x18 InitScreenParameter         ( ModelClassType IMobileScreenParameter IMobileScreenParameter IMobileScreenParameter Pointer )

            return value;
        }
    }
}
