using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxFullFrameToneMapLuminance             ModelPrimitiveType int int int Int32
    // 014 MaxToneMapLuminance                      ModelPrimitiveType int int int Int32
    // 018 MinToneMapLuminance                      ModelPrimitiveType int int int Int32
    // 01C PaperWhiteNits                           ModelPrimitiveType float float float Single
    public partial class HDRDisplayInformation : DataModel
    {
        public int                                      MaxFullFrameToneMapLuminance            { get; set; }
        public int                                      MaxToneMapLuminance                     { get; set; }
        public int                                      MinToneMapLuminance                     { get; set; }
        public float                                    PaperWhiteNits                          { get; set; }

        public static HDRDisplayInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HDRDisplayInformation() { Pointer= p0 };

            value.MaxFullFrameToneMapLuminance              = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxFullFrameToneMapLuminance ( ModelPrimitiveType int int int Int32 )
            value.MaxToneMapLuminance                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxToneMapLuminance         ( ModelPrimitiveType int int int Int32 )
            value.MinToneMapLuminance                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 MinToneMapLuminance         ( ModelPrimitiveType int int int Int32 )
            value.PaperWhiteNits                            = GetSingle(new IntPtr(p + 0x01C)); // 0x1C PaperWhiteNits              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
