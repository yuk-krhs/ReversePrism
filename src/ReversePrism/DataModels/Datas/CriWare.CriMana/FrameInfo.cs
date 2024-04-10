using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrameNo                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 FrameNoPerFile                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Width                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C Height                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 DispWidth                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 DispHeight                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 NumImages                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C FramerateN                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 030 FramerateD                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 034 Reserved1                                000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 038 Time                                     00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 040 Tunit                                    00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 048 CntConcatenatedMovie                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 04C AlphaType                                0001866A5140 ModelEnumType AlphaType AlphaType AlphaType Int32
    // 050 CntSkippedFrames                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 054 TotalFramesPerFile                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class FrameInfo : DataModel
    {
        public int                                      FrameNo                                 { get; set; }
        public int                                      FrameNoPerFile                          { get; set; }
        public uint                                     Width                                   { get; set; }
        public uint                                     Height                                  { get; set; }
        public uint                                     DispWidth                               { get; set; }
        public uint                                     DispHeight                              { get; set; }
        public uint                                     NumImages                               { get; set; }
        public uint                                     FramerateN                              { get; set; }
        public uint                                     FramerateD                              { get; set; }
        public uint                                     Reserved1                               { get; set; }
        public ulong                                    Time                                    { get; set; }
        public ulong                                    Tunit                                   { get; set; }
        public uint                                     CntConcatenatedMovie                    { get; set; }
        public AlphaType                                AlphaType                               { get; set; }
        public uint                                     CntSkippedFrames                        { get; set; }
        public uint                                     TotalFramesPerFile                      { get; set; }

        public static FrameInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameInfo() { Pointer= p0 };

            value.FrameNo                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A447E9B0 0x10 FrameNo                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FrameNoPerFile                            = GetInt32(new IntPtr(p + 0x014)); // 0245A447E9D0 0x14 FrameNoPerFile              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Width                                     = GetUInt32(new IntPtr(p + 0x018)); // 0245A447E9F0 0x18 Width                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Height                                    = GetUInt32(new IntPtr(p + 0x01C)); // 0245A447EA10 0x1C Height                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DispWidth                                 = GetUInt32(new IntPtr(p + 0x020)); // 0245A447EA30 0x20 DispWidth                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DispHeight                                = GetUInt32(new IntPtr(p + 0x024)); // 0245A447EA50 0x24 DispHeight                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.NumImages                                 = GetUInt32(new IntPtr(p + 0x028)); // 0245A447EA70 0x28 NumImages                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateN                                = GetUInt32(new IntPtr(p + 0x02C)); // 0245A447EA90 0x2C FramerateN                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FramerateD                                = GetUInt32(new IntPtr(p + 0x030)); // 0245A447EAB0 0x30 FramerateD                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Reserved1                                 = GetUInt32(new IntPtr(p + 0x034)); // 0245A447EAD0 0x34 Reserved1                   ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Time                                      = GetUInt64(new IntPtr(p + 0x038)); // 0245A447EAF0 0x38 Time                        ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Tunit                                     = GetUInt64(new IntPtr(p + 0x040)); // 0245A447EB10 0x40 Tunit                       ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CntConcatenatedMovie                      = GetUInt32(new IntPtr(p + 0x048)); // 0245A447EB30 0x48 CntConcatenatedMovie        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.AlphaType                                 = (AlphaType)GetInt32(new IntPtr(p + 0x04C)); // 0245A447EB50 0x4C AlphaType                   ( 0001866A5140 ModelEnumType AlphaType AlphaType AlphaType Int32 )
            value.CntSkippedFrames                          = GetUInt32(new IntPtr(p + 0x050)); // 0245A447EB70 0x50 CntSkippedFrames            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.TotalFramesPerFile                        = GetUInt32(new IntPtr(p + 0x054)); // 0245A447EB90 0x54 TotalFramesPerFile          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
