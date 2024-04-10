using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnableFlags1                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 EnableFlags2                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 HighFrequencyMotorSpeed                  00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 LowFrequencyMotorSpeed                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03C RedColor                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03D GreenColor                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03E BlueColor                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DualSenseHIDOutputReportPayload : DataModel
    {
        public sbyte                                    EnableFlags1                            { get; set; }
        public sbyte                                    EnableFlags2                            { get; set; }
        public sbyte                                    HighFrequencyMotorSpeed                 { get; set; }
        public sbyte                                    LowFrequencyMotorSpeed                  { get; set; }
        public sbyte                                    RedColor                                { get; set; }
        public sbyte                                    GreenColor                              { get; set; }
        public sbyte                                    BlueColor                               { get; set; }

        public static DualSenseHIDOutputReportPayload? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDOutputReportPayload() { Pointer= p0 };

            value.EnableFlags1                              = GetSByte(new IntPtr(p + 0x010)); // 024667851878 0x10 EnableFlags1                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.EnableFlags2                              = GetSByte(new IntPtr(p + 0x011)); // 024667851898 0x11 EnableFlags2                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.HighFrequencyMotorSpeed                   = GetSByte(new IntPtr(p + 0x012)); // 0246678518B8 0x12 HighFrequencyMotorSpeed     ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LowFrequencyMotorSpeed                    = GetSByte(new IntPtr(p + 0x013)); // 0246678518D8 0x13 LowFrequencyMotorSpeed      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RedColor                                  = GetSByte(new IntPtr(p + 0x03C)); // 0246678518F8 0x3C RedColor                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.GreenColor                                = GetSByte(new IntPtr(p + 0x03D)); // 024667851918 0x3D GreenColor                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BlueColor                                 = GetSByte(new IntPtr(p + 0x03E)); // 024667851938 0x3E BlueColor                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
