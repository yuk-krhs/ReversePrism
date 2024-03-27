using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 StandardMemoryAsrVoicePoolId             int IL2CPP_TYPE_I4
    // 000 StandardStreamingAsrVoicePoolId          int IL2CPP_TYPE_I4
    // 000 StandardMemoryNsrVoicePoolId             int IL2CPP_TYPE_I4
    // 000 StandardStreamingNsrVoicePoolId          int IL2CPP_TYPE_I4
    // 020 _handle                                  <int> IL2CPP_TYPE_I
    // 028 Identifier                               000186699040 ModelPrimitiveType uint uint uint UInt32
    // 02C NumVoices                                0001865F3220 ModelPrimitiveType int int int Int32
    // 030 MaxChannels                              0001865F3220 ModelPrimitiveType int int int Int32
    // 034 MaxSamplingRate                          0001865F3220 ModelPrimitiveType int int int Int32
    public partial class CriAtomExVoicePool
    {
        public uint                                     Identifier                              { get; set; }
        public int                                      NumVoices                               { get; set; }
        public int                                      MaxChannels                             { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }

        public static CriAtomExVoicePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExVoicePool();

            value.Identifier                                = GetUInt32(new IntPtr(p + 0x028)); // 0270D4F5B558 0x28 Identifier                  ( 000186699040 ModelPrimitiveType uint uint uint UInt32 )
            value.NumVoices                                 = GetInt32(new IntPtr(p + 0x02C)); // 0270D4F5B578 0x2C NumVoices                   ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.MaxChannels                               = GetInt32(new IntPtr(p + 0x030)); // 0270D4F5B598 0x30 MaxChannels                 ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x034)); // 0270D4F5B5B8 0x34 MaxSamplingRate             ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
