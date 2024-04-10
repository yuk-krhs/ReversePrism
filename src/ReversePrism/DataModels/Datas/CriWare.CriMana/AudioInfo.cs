using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SamplingRate                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 NumChannels                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 TotalSamples                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class AudioInfo : DataModel
    {
        public uint                                     SamplingRate                            { get; set; }
        public uint                                     NumChannels                             { get; set; }
        public uint                                     TotalSamples                            { get; set; }

        public static AudioInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioInfo() { Pointer= p0 };

            value.SamplingRate                              = GetUInt32(new IntPtr(p + 0x010)); // 0245A4ACD488 0x10 SamplingRate                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.NumChannels                               = GetUInt32(new IntPtr(p + 0x014)); // 0245A4ACD4A8 0x14 NumChannels                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.TotalSamples                              = GetUInt32(new IntPtr(p + 0x018)); // 0245A4ACD4C8 0x18 TotalSamples                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
