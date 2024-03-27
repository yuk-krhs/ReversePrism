using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Format                                   000186540750 ModelEnumType Format Format Format Int32
    // 014 SamplingRate                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 NumSamples                               0001865F7E40 ModelPrimitiveType long long long Int64
    // 020 LoopOffset                               0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 LoopLength                               0001865F7E40 ModelPrimitiveType long long long Int64
    // 030 NumChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 Reserved                                 0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class FormatInfo
    {
        public Format                                   Format                                  { get; set; }
        public int                                      SamplingRate                            { get; set; }
        public long                                     NumSamples                              { get; set; }
        public long                                     LoopOffset                              { get; set; }
        public long                                     LoopLength                              { get; set; }
        public int                                      NumChannels                             { get; set; }
        public uint                                     Reserved                                { get; set; }

        public static FormatInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FormatInfo();

            value.Format                                    = (Format)GetInt32(new IntPtr(p + 0x010)); // 0270DAC6C440 0x10 Format                      ( 000186540750 ModelEnumType Format Format Format Int32 )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x014)); // 0270DAC6C460 0x14 SamplingRate                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumSamples                                = GetInt64(new IntPtr(p + 0x018)); // 0270DAC6C480 0x18 NumSamples                  ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.LoopOffset                                = GetInt64(new IntPtr(p + 0x020)); // 0270DAC6C4A0 0x20 LoopOffset                  ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.LoopLength                                = GetInt64(new IntPtr(p + 0x028)); // 0270DAC6C4C0 0x28 LoopLength                  ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.NumChannels                               = GetInt32(new IntPtr(p + 0x030)); // 0270DAC6C4E0 0x30 NumChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Reserved                                  = GetUInt32(new IntPtr(p + 0x034)); // 0270DAC6C500 0x34 Reserved                    ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
