using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WaveId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Format                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 SamplingRate                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C NumChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 NumSamples                               0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 StreamingFlag                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 Reserved                                 000185B840E0 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class WaveformInfo
    {
        public int                                      WaveId                                  { get; set; }
        public uint                                     Format                                  { get; set; }
        public int                                      SamplingRate                            { get; set; }
        public int                                      NumChannels                             { get; set; }
        public long                                     NumSamples                              { get; set; }
        public bool                                     StreamingFlag                           { get; set; }
        public List<uint>?                              Reserved                                { get; set; }

        public static WaveformInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaveformInfo();

            value.WaveId                                    = GetInt32(new IntPtr(p + 0x010)); // 0270DAC6C740 0x10 WaveId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Format                                    = GetUInt32(new IntPtr(p + 0x014)); // 0270DAC6C760 0x14 Format                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x018)); // 0270DAC6C780 0x18 SamplingRate                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumChannels                               = GetInt32(new IntPtr(p + 0x01C)); // 0270DAC6C7A0 0x1C NumChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumSamples                                = GetInt64(new IntPtr(p + 0x020)); // 0270DAC6C7C0 0x20 NumSamples                  ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.StreamingFlag                             = GetBool(new IntPtr(p + 0x028)); // 0270DAC6C7E0 0x28 StreamingFlag               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Reserved                                  = GetUInt32List(new IntPtr(p + 0x030)); // 0270DAC6C800 0x30 Reserved                    ( 000185B840E0 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
