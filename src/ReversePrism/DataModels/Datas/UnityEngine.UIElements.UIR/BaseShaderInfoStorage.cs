using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_TextureCounter                         int IL2CPP_TYPE_I4
    // 008 s_MarkerCopyTexture                      ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 S_MarkerGetTextureData                   0001865C99C0 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 S_MarkerUpdateTexture                    0001865C99C0 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 010 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BaseShaderInfoStorage : DataModel
    {
        public ProfilerMarker                           S_MarkerGetTextureData                  { get; set; }
        public ProfilerMarker                           S_MarkerUpdateTexture                   { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static BaseShaderInfoStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseShaderInfoStorage() { Pointer= p0 };

            value.S_MarkerGetTextureData                    = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0245A68357B0 0x10 S_MarkerGetTextureData      ( 0001865C99C0 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MarkerUpdateTexture                     = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0245A68357D0 0x18 S_MarkerUpdateTexture       ( 0001865C99C0 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0245A68357F0 0x10 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
