using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 UseCount                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 FirstGradientRemap                       00018668F220 ModelClassType GradientRemap GradientRemap GradientRemap Pointer
    // 028 GradientSettingsAlloc                    0001865866A0 ModelEnumType Alloc Alloc Alloc Int32
    public partial class VectorImageRenderInfo : DataModel
    {
        public int                                      UseCount                                { get; set; }
        public GradientRemap?                           FirstGradientRemap                      { get; set; }
        public Alloc                                    GradientSettingsAlloc                   { get; set; }

        public static VectorImageRenderInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VectorImageRenderInfo() { Pointer= p0 };

            value.UseCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0245A683D080 0x18 UseCount                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstGradientRemap                        = GetObject<GradientRemap>(new IntPtr(p + 0x020), ReversePrism.DataModels.GradientRemap.FromPointer); // 0245A683D0A0 0x20 FirstGradientRemap          ( 00018668F220 ModelClassType GradientRemap GradientRemap GradientRemap Pointer )
            value.GradientSettingsAlloc                     = (Alloc)GetInt32(new IntPtr(p + 0x028)); // 0245A683D0C0 0x28 GradientSettingsAlloc       ( 0001865866A0 ModelEnumType Alloc Alloc Alloc Int32 )

            return value;
        }
    }
}
