using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemoryVoices                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 StreamingVoices                          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class VoicePoolConfig : DataModel
    {
        public int                                      MemoryVoices                            { get; set; }
        public int                                      StreamingVoices                         { get; set; }

        public static VoicePoolConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePoolConfig() { Pointer= p0 };

            value.MemoryVoices                              = GetInt32(new IntPtr(p + 0x010)); // 024660F63570 0x10 MemoryVoices                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StreamingVoices                           = GetInt32(new IntPtr(p + 0x014)); // 024660F63590 0x14 StreamingVoices             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
