using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Comp                                     00018651ACE0 ModelClassType LensFlareComponentSRP LensFlareComponentSRP LensFlareComponentSRP Pointer
    public partial class LensFlareCompInfo : DataModel
    {
        public int                                      Index                                   { get; set; }
        public LensFlareComponentSRP?                   Comp                                    { get; set; }

        public static LensFlareCompInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensFlareCompInfo() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0246692B5790 0x10 Index                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Comp                                      = GetObject<LensFlareComponentSRP>(new IntPtr(p + 0x018), ReversePrism.DataModels.LensFlareComponentSRP.FromPointer); // 0246692B57B0 0x18 Comp                        ( 00018651ACE0 ModelClassType LensFlareComponentSRP LensFlareComponentSRP LensFlareComponentSRP Pointer )

            return value;
        }
    }
}
