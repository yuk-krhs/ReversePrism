using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Voices                                   ModelPrimitiveType int int int Int32
    public partial class WebGLWebAudioVoicePoolConfig : DataModel
    {
        public int                                      Voices                                  { get; set; }

        public static WebGLWebAudioVoicePoolConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebGLWebAudioVoicePoolConfig() { Pointer= p0 };

            value.Voices                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Voices                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
