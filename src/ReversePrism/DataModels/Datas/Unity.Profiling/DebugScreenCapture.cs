using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <RawImageDataReference>k__BackingField   NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 020 ImageFormat                              ModelEnumType TextureFormat TextureFormat TextureFormat Int32
    // 024 Width                                    ModelPrimitiveType int int int Int32
    // 028 Height                                   ModelPrimitiveType int int int Int32
    public partial class DebugScreenCapture : DataModel
    {
        public TextureFormat                            ImageFormat                             { get; set; }
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }

        public static DebugScreenCapture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugScreenCapture() { Pointer= p0 };

            value.ImageFormat                               = (TextureFormat)GetInt32(new IntPtr(p + 0x020)); // 0x20 ImageFormat                 ( ModelEnumType TextureFormat TextureFormat TextureFormat Int32 )
            value.Width                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Height                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
