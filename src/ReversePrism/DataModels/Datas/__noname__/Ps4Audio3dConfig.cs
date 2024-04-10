using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAudio3D                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 VoicePoolConfig                          000186770FD0 ModelClassType VoicePoolConfig VoicePoolConfig VoicePoolConfig Pointer
    public partial class Ps4Audio3dConfig : DataModel
    {
        public bool                                     UseAudio3D                              { get; set; }
        public VoicePoolConfig?                         VoicePoolConfig                         { get; set; }

        public static Ps4Audio3dConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ps4Audio3dConfig() { Pointer= p0 };

            value.UseAudio3D                                = GetBool(new IntPtr(p + 0x010)); // 024660F5D170 0x10 UseAudio3D                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.VoicePoolConfig                           = GetObject<VoicePoolConfig>(new IntPtr(p + 0x018), ReversePrism.DataModels.VoicePoolConfig.FromPointer); // 024660F5D190 0x18 VoicePoolConfig             ( 000186770FD0 ModelClassType VoicePoolConfig VoicePoolConfig VoicePoolConfig Pointer )

            return value;
        }
    }
}
