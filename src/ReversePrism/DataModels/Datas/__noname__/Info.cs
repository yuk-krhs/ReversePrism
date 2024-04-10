using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LipWidth                                 000186666050 ModelPrimitiveType float float float Single
    // 014 LipHeight                                000186666050 ModelPrimitiveType float float float Single
    // 018 TonguePosition                           000186666050 ModelPrimitiveType float float float Single
    // 01C IsLipWidthReleased                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01D IsLipHeightReleased                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01E IsLipToungueReleased                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Info : DataModel
    {
        public float                                    LipWidth                                { get; set; }
        public float                                    LipHeight                               { get; set; }
        public float                                    TonguePosition                          { get; set; }
        public bool                                     IsLipWidthReleased                      { get; set; }
        public bool                                     IsLipHeightReleased                     { get; set; }
        public bool                                     IsLipToungueReleased                    { get; set; }

        public static Info? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Info() { Pointer= p0 };

            value.LipWidth                                  = GetSingle(new IntPtr(p + 0x010)); // 02466BC253D0 0x10 LipWidth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.LipHeight                                 = GetSingle(new IntPtr(p + 0x014)); // 02466BC253F0 0x14 LipHeight                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.TonguePosition                            = GetSingle(new IntPtr(p + 0x018)); // 02466BC25410 0x18 TonguePosition              ( 000186666050 ModelPrimitiveType float float float Single )
            value.IsLipWidthReleased                        = GetBool(new IntPtr(p + 0x01C)); // 02466BC25430 0x1C IsLipWidthReleased          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLipHeightReleased                       = GetBool(new IntPtr(p + 0x01D)); // 02466BC25450 0x1D IsLipHeightReleased         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLipToungueReleased                      = GetBool(new IntPtr(p + 0x01E)); // 02466BC25470 0x1E IsLipToungueReleased        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
