using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Active                                   ModelPrimitiveType bool bool bool Bool
    // 020 Enabled                                  ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 028 parameters                               ReadOnlyCollection`1<ParameterOverride> IL2CPP_TYPE_GENERICINST
    public partial class PostProcessEffectSettings : DataModel
    {
        public bool                                     Active                                  { get; set; }
        public BoolParameter?                           Enabled                                 { get; set; }

        public static PostProcessEffectSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessEffectSettings() { Pointer= p0 };

            value.Active                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 Active                      ( ModelPrimitiveType bool bool bool Bool )
            value.Enabled                                   = GetObject<BoolParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.BoolParameter.FromPointer); // 0x20 Enabled                     ( ModelClassType BoolParameter BoolParameter BoolParameter Pointer )

            return value;
        }
    }
}
