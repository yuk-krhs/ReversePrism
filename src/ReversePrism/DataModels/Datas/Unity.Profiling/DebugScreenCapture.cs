using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <RawImageDataReference>k__BackingField   NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 020 ImageFormat                              000186652C20 ModelEnumType TextureFormat TextureFormat TextureFormat Int32
    // 024 Width                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Height                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class DebugScreenCapture
    {
        public TextureFormat                            ImageFormat                             { get; set; }
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }

        public static DebugScreenCapture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugScreenCapture();

            value.ImageFormat                               = (TextureFormat)GetInt32(new IntPtr(p + 0x020)); // 0270068A3E10 0x20 ImageFormat                 ( 000186652C20 ModelEnumType TextureFormat TextureFormat TextureFormat Int32 )
            value.Width                                     = GetInt32(new IntPtr(p + 0x024)); // 0270068A3E30 0x24 Width                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x028)); // 0270068A3E50 0x28 Height                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
