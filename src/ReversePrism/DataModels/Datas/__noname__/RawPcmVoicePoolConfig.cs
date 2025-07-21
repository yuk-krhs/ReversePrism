using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Identifier                               ModelPrimitiveType uint uint uint UInt32
    // 014 NumVoices                                ModelPrimitiveType int int int Int32
    // 018 PlayerConfig                             ModelEnumType RawPcmPlayerConfig RawPcmPlayerConfig RawPcmPlayerConfig Int32
    public partial class RawPcmVoicePoolConfig : DataModel
    {
        public uint                                     Identifier                              { get; set; }
        public int                                      NumVoices                               { get; set; }
        public RawPcmPlayerConfig                       PlayerConfig                            { get; set; }

        public static RawPcmVoicePoolConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawPcmVoicePoolConfig() { Pointer= p0 };

            value.Identifier                                = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Identifier                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.NumVoices                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 NumVoices                   ( ModelPrimitiveType int int int Int32 )
            value.PlayerConfig                              = (RawPcmPlayerConfig)GetInt32(new IntPtr(p + 0x018)); // 0x18 PlayerConfig                ( ModelEnumType RawPcmPlayerConfig RawPcmPlayerConfig RawPcmPlayerConfig Int32 )

            return value;
        }
    }
}
