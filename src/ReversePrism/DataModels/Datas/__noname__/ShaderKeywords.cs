using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HDR_COLORSPACE_CONVERSION                string IL2CPP_TYPE_STRING
    // 000 HDR_ENCODING                             string IL2CPP_TYPE_STRING
    // 000 HDR_COLORSPACE_CONVERSION_AND_ENCODING   string IL2CPP_TYPE_STRING
    // 000 HDR_INPUT                                string IL2CPP_TYPE_STRING
    // 000 HDRColorSpaceConversion                  ShaderKeyword IL2CPP_TYPE_VALUETYPE
    // 010 HDREncoding                              ModelEnumType ShaderKeyword ShaderKeyword ShaderKeyword Int32
    // 020 HDRColorSpaceConversionAndEncoding       ModelEnumType ShaderKeyword ShaderKeyword ShaderKeyword Int32
    // 030 HDRInput                                 ModelEnumType ShaderKeyword ShaderKeyword ShaderKeyword Int32
    public partial class ShaderKeywords : DataModel
    {
        public ShaderKeyword                            HDREncoding                             { get; set; }
        public ShaderKeyword                            HDRColorSpaceConversionAndEncoding      { get; set; }
        public ShaderKeyword                            HDRInput                                { get; set; }

        public static ShaderKeywords? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderKeywords() { Pointer= p0 };

            value.HDREncoding                               = (ShaderKeyword)GetInt32(new IntPtr(p + 0x010)); // 0x10 HDREncoding                 ( ModelEnumType ShaderKeyword ShaderKeyword ShaderKeyword Int32 )
            value.HDRColorSpaceConversionAndEncoding        = (ShaderKeyword)GetInt32(new IntPtr(p + 0x020)); // 0x20 HDRColorSpaceConversionAndEncoding ( ModelEnumType ShaderKeyword ShaderKeyword ShaderKeyword Int32 )
            value.HDRInput                                  = (ShaderKeyword)GetInt32(new IntPtr(p + 0x030)); // 0x30 HDRInput                    ( ModelEnumType ShaderKeyword ShaderKeyword ShaderKeyword Int32 )

            return value;
        }
    }
}
