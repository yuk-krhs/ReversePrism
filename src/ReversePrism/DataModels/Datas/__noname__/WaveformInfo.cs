using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WaveId                                   ModelPrimitiveType int int int Int32
    // 014 Format                                   ModelPrimitiveType uint uint uint UInt32
    // 018 SamplingRate                             ModelPrimitiveType int int int Int32
    // 01C NumChannels                              ModelPrimitiveType int int int Int32
    // 020 NumSamples                               ModelPrimitiveType long long long Int64
    // 028 StreamingFlag                            ModelPrimitiveType bool bool bool Bool
    // 030 Reserved                                 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class WaveformInfo : DataModel
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
            var value   = new WaveformInfo() { Pointer= p0 };

            value.WaveId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 WaveId                      ( ModelPrimitiveType int int int Int32 )
            value.Format                                    = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Format                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 SamplingRate                ( ModelPrimitiveType int int int Int32 )
            value.NumChannels                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NumChannels                 ( ModelPrimitiveType int int int Int32 )
            value.NumSamples                                = GetInt64(new IntPtr(p + 0x020)); // 0x20 NumSamples                  ( ModelPrimitiveType long long long Int64 )
            value.StreamingFlag                             = GetBool(new IntPtr(p + 0x028)); // 0x28 StreamingFlag               ( ModelPrimitiveType bool bool bool Bool )
            value.Reserved                                  = GetUInt32List(new IntPtr(p + 0x030)); // 0x30 Reserved                    ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
