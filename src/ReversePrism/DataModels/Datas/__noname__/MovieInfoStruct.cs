using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Width                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Height                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 DispWidth                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C DispHeight                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 FramerateN                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 FramerateD                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 TotalFrames                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C CodecType                                0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32
    // 030 AlphaCodecType                           0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32
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

            value.Width                                     = GetUInt32(new IntPtr(p + 0x010)); // 02466AD2B578 0x10 Width                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Height                                    = GetUInt32(new IntPtr(p + 0x014)); // 02466AD2B598 0x14 Height                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DispWidth                                 = GetUInt32(new IntPtr(p + 0x018)); // 02466AD2B5B8 0x18 DispWidth                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DispHeight                                = GetUInt32(new IntPtr(p + 0x01C)); // 02466AD2B5D8 0x1C DispHeight                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateN                                = GetUInt32(new IntPtr(p + 0x020)); // 02466AD2B5F8 0x20 FramerateN                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateD                                = GetUInt32(new IntPtr(p + 0x024)); // 02466AD2B618 0x24 FramerateD                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.TotalFrames                               = GetUInt32(new IntPtr(p + 0x028)); // 02466AD2B638 0x28 TotalFrames                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CodecType                                 = (CodecType)GetInt32(new IntPtr(p + 0x02C)); // 02466AD2B658 0x2C CodecType                   ( 0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32 )
            value.AlphaCodecType                            = (CodecType)GetInt32(new IntPtr(p + 0x030)); // 02466AD2B678 0x30 AlphaCodecType              ( 0001865C0EA0 ModelEnumType CodecType CodecType CodecType Int32 )

            return value;
        }
    }
}
