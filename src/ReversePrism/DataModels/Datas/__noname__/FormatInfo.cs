using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Format                                   ModelEnumType Format Format Format Int32
    // 014 SamplingRate                             ModelPrimitiveType int int int Int32
    // 018 NumSamples                               ModelPrimitiveType long long long Int64
    // 020 LoopOffset                               ModelPrimitiveType long long long Int64
    // 028 LoopLength                               ModelPrimitiveType long long long Int64
    // 030 NumChannels                              ModelPrimitiveType int int int Int32
    // 034 Reserved                                 ModelPrimitiveType uint uint uint UInt32
    public partial class FormatInfo : DataModel
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
            var value   = new FormatInfo() { Pointer= p0 };

            value.Format                                    = (Format)GetInt32(new IntPtr(p + 0x010)); // 0x10 Format                      ( ModelEnumType Format Format Format Int32 )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 SamplingRate                ( ModelPrimitiveType int int int Int32 )
            value.NumSamples                                = GetInt64(new IntPtr(p + 0x018)); // 0x18 NumSamples                  ( ModelPrimitiveType long long long Int64 )
            value.LoopOffset                                = GetInt64(new IntPtr(p + 0x020)); // 0x20 LoopOffset                  ( ModelPrimitiveType long long long Int64 )
            value.LoopLength                                = GetInt64(new IntPtr(p + 0x028)); // 0x28 LoopLength                  ( ModelPrimitiveType long long long Int64 )
            value.NumChannels                               = GetInt32(new IntPtr(p + 0x030)); // 0x30 NumChannels                 ( ModelPrimitiveType int int int Int32 )
            value.Reserved                                  = GetUInt32(new IntPtr(p + 0x034)); // 0x34 Reserved                    ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
