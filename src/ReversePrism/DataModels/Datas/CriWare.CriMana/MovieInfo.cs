using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reserved1                                000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 014 NumAlphaStreams                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Width                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C Height                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 DispWidth                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 DispHeight                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 FramerateN                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C FramerateD                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 030 TotalFrames                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 034 CodecType                                0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32
    // 038 AlphaCodecType                           0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32
    // 03C NumAudioStreams                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 040 AudioPrm                                 000185B715E0 ModelEnumListType AudioInfo[] AudioInfo[] List<AudioInfo> Pointer
    // 048 NumSubtitleChannels                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 04C MaxSubtitleSize                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 050 MaxChunkSize                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class MovieInfo : DataModel
    {
        public uint                                     Reserved1                               { get; set; }
        public uint                                     NumAlphaStreams                         { get; set; }
        public uint                                     Width                                   { get; set; }
        public uint                                     Height                                  { get; set; }
        public uint                                     DispWidth                               { get; set; }
        public uint                                     DispHeight                              { get; set; }
        public uint                                     FramerateN                              { get; set; }
        public uint                                     FramerateD                              { get; set; }
        public uint                                     TotalFrames                             { get; set; }
        public CodecType                                CodecType                               { get; set; }
        public CodecType                                AlphaCodecType                          { get; set; }
        public uint                                     NumAudioStreams                         { get; set; }
        public List<AudioInfo>?                         AudioPrm                                { get; set; }
        public uint                                     NumSubtitleChannels                     { get; set; }
        public uint                                     MaxSubtitleSize                         { get; set; }
        public uint                                     MaxChunkSize                            { get; set; }

        public static MovieInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovieInfo() { Pointer= p0 };

            value.Reserved1                                 = GetUInt32(new IntPtr(p + 0x010)); // 0245A447ECE8 0x10 Reserved1                   ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.NumAlphaStreams                           = GetUInt32(new IntPtr(p + 0x014)); // 0245A447ED08 0x14 NumAlphaStreams             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Width                                     = GetUInt32(new IntPtr(p + 0x018)); // 0245A447ED28 0x18 Width                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Height                                    = GetUInt32(new IntPtr(p + 0x01C)); // 0245A447ED48 0x1C Height                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DispWidth                                 = GetUInt32(new IntPtr(p + 0x020)); // 0245A447ED68 0x20 DispWidth                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DispHeight                                = GetUInt32(new IntPtr(p + 0x024)); // 0245A447ED88 0x24 DispHeight                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateN                                = GetUInt32(new IntPtr(p + 0x028)); // 0245A447EDA8 0x28 FramerateN                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateD                                = GetUInt32(new IntPtr(p + 0x02C)); // 0245A447EDC8 0x2C FramerateD                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.TotalFrames                               = GetUInt32(new IntPtr(p + 0x030)); // 0245A447EDE8 0x30 TotalFrames                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CodecType                                 = (CodecType)GetInt32(new IntPtr(p + 0x034)); // 0245A447EE08 0x34 CodecType                   ( 0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32 )
            value.AlphaCodecType                            = (CodecType)GetInt32(new IntPtr(p + 0x038)); // 0245A447EE28 0x38 AlphaCodecType              ( 0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32 )
            value.NumAudioStreams                           = GetUInt32(new IntPtr(p + 0x03C)); // 0245A447EE48 0x3C NumAudioStreams             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.AudioPrm                                  = GetEnumList<AudioInfo>(new IntPtr(p + 0x040)); // 0245A447EE68 0x40 AudioPrm                    ( 000185B715E0 ModelEnumListType AudioInfo[] AudioInfo[] List<AudioInfo> Pointer )
            value.NumSubtitleChannels                       = GetUInt32(new IntPtr(p + 0x048)); // 0245A447EE88 0x48 NumSubtitleChannels         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxSubtitleSize                           = GetUInt32(new IntPtr(p + 0x04C)); // 0245A447EEA8 0x4C MaxSubtitleSize             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxChunkSize                              = GetUInt32(new IntPtr(p + 0x050)); // 0245A447EEC8 0x50 MaxChunkSize                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
