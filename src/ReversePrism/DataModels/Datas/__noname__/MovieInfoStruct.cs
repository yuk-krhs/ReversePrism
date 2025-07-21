using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Width                                    ModelPrimitiveType uint uint uint UInt32
    // 014 Height                                   ModelPrimitiveType uint uint uint UInt32
    // 018 DispWidth                                ModelPrimitiveType uint uint uint UInt32
    // 01C DispHeight                               ModelPrimitiveType uint uint uint UInt32
    // 020 FramerateN                               ModelPrimitiveType uint uint uint UInt32
    // 024 FramerateD                               ModelPrimitiveType uint uint uint UInt32
    // 028 TotalFrames                              ModelPrimitiveType uint uint uint UInt32
    // 02C CodecType                                ModelEnumType CodecType CodecType CodecType Int32
    // 030 AlphaCodecType                           ModelEnumType CodecType CodecType CodecType Int32
    public partial class MovieInfoStruct : DataModel
    {
        public uint                                     Width                                   { get; set; }
        public uint                                     Height                                  { get; set; }
        public uint                                     DispWidth                               { get; set; }
        public uint                                     DispHeight                              { get; set; }
        public uint                                     FramerateN                              { get; set; }
        public uint                                     FramerateD                              { get; set; }
        public uint                                     TotalFrames                             { get; set; }
        public CodecType                                CodecType                               { get; set; }
        public CodecType                                AlphaCodecType                          { get; set; }

        public static MovieInfoStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovieInfoStruct() { Pointer= p0 };

            value.Width                                     = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Width                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Height                                    = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Height                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.DispWidth                                 = GetUInt32(new IntPtr(p + 0x018)); // 0x18 DispWidth                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.DispHeight                                = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C DispHeight                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateN                                = GetUInt32(new IntPtr(p + 0x020)); // 0x20 FramerateN                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateD                                = GetUInt32(new IntPtr(p + 0x024)); // 0x24 FramerateD                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.TotalFrames                               = GetUInt32(new IntPtr(p + 0x028)); // 0x28 TotalFrames                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.CodecType                                 = (CodecType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C CodecType                   ( ModelEnumType CodecType CodecType CodecType Int32 )
            value.AlphaCodecType                            = (CodecType)GetInt32(new IntPtr(p + 0x030)); // 0x30 AlphaCodecType              ( ModelEnumType CodecType CodecType CodecType Int32 )

            return value;
        }
    }
}
