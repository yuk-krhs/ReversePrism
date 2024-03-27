using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 000 ExpectedReportId                         sbyte IL2CPP_TYPE_U1
    // 010 ReportId                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Buttons0                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Buttons1                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Buttons2                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Left0                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Left1                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Left2                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Right0                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Right1                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Right2                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class SwitchFullInputReport
    {
        public sbyte                                    ReportId                                { get; set; }
        public sbyte                                    Buttons0                                { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Buttons2                                { get; set; }
        public sbyte                                    Left0                                   { get; set; }
        public sbyte                                    Left1                                   { get; set; }
        public sbyte                                    Left2                                   { get; set; }
        public sbyte                                    Right0                                  { get; set; }
        public sbyte                                    Right1                                  { get; set; }
        public sbyte                                    Right2                                  { get; set; }

        public static SwitchFullInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchFullInputReport();

            value.ReportId                                  = GetSByte(new IntPtr(p + 0x010)); // 0270D77BB8B8 0x10 ReportId                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons0                                  = GetSByte(new IntPtr(p + 0x013)); // 0270D77BB8D8 0x13 Buttons0                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x014)); // 0270D77BB8F8 0x14 Buttons1                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x015)); // 0270D77BB918 0x15 Buttons2                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Left0                                     = GetSByte(new IntPtr(p + 0x016)); // 0270D77BB938 0x16 Left0                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Left1                                     = GetSByte(new IntPtr(p + 0x017)); // 0270D77BB958 0x17 Left1                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Left2                                     = GetSByte(new IntPtr(p + 0x018)); // 0270D77BB978 0x18 Left2                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Right0                                    = GetSByte(new IntPtr(p + 0x019)); // 0270D77BB998 0x19 Right0                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Right1                                    = GetSByte(new IntPtr(p + 0x01A)); // 0270D77BB9B8 0x1A Right1                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Right2                                    = GetSByte(new IntPtr(p + 0x01B)); // 0270D77BB9D8 0x1B Right2                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
