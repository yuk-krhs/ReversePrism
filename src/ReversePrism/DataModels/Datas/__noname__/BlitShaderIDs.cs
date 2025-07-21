using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _BlitTexture                             int IL2CPP_TYPE_I4
    // 004 _BlitCubeTexture                         int IL2CPP_TYPE_I4
    // 008 _BlitScaleBias                           int IL2CPP_TYPE_I4
    // 00C _BlitScaleBiasRt                         int IL2CPP_TYPE_I4
    // 010 BlitMipLevel                             ModelPrimitiveType int int int Int32
    // 014 BlitTextureSize                          ModelPrimitiveType int int int Int32
    // 018 BlitPaddingSize                          ModelPrimitiveType int int int Int32
    // 01C BlitDecodeInstructions                   ModelPrimitiveType int int int Int32
    // 020 InputDepth                               ModelPrimitiveType int int int Int32
    public partial class BlitShaderIDs : DataModel
    {
        public int                                      BlitMipLevel                            { get; set; }
        public int                                      BlitTextureSize                         { get; set; }
        public int                                      BlitPaddingSize                         { get; set; }
        public int                                      BlitDecodeInstructions                  { get; set; }
        public int                                      InputDepth                              { get; set; }

        public static BlitShaderIDs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlitShaderIDs() { Pointer= p0 };

            value.BlitMipLevel                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 BlitMipLevel                ( ModelPrimitiveType int int int Int32 )
            value.BlitTextureSize                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 BlitTextureSize             ( ModelPrimitiveType int int int Int32 )
            value.BlitPaddingSize                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 BlitPaddingSize             ( ModelPrimitiveType int int int Int32 )
            value.BlitDecodeInstructions                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C BlitDecodeInstructions      ( ModelPrimitiveType int int int Int32 )
            value.InputDepth                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 InputDepth                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
