using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 Buttons0                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Buttons1                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Hat                                      00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 LeftX                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 LeftY                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 RightX                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 RightY                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class SwitchInputOnlyReport
    {
        public sbyte                                    Buttons0                                { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Hat                                     { get; set; }
        public sbyte                                    LeftX                                   { get; set; }
        public sbyte                                    LeftY                                   { get; set; }
        public sbyte                                    RightX                                  { get; set; }
        public sbyte                                    RightY                                  { get; set; }

        public static SwitchInputOnlyReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchInputOnlyReport();

            value.Buttons0                                  = GetSByte(new IntPtr(p + 0x010)); // 0270D77BB208 0x10 Buttons0                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x011)); // 0270D77BB228 0x11 Buttons1                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Hat                                       = GetSByte(new IntPtr(p + 0x012)); // 0270D77BB248 0x12 Hat                         ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftX                                     = GetSByte(new IntPtr(p + 0x013)); // 0270D77BB268 0x13 LeftX                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftY                                     = GetSByte(new IntPtr(p + 0x014)); // 0270D77BB288 0x14 LeftY                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightX                                    = GetSByte(new IntPtr(p + 0x015)); // 0270D77BB2A8 0x15 RightX                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightY                                    = GetSByte(new IntPtr(p + 0x016)); // 0270D77BB2C8 0x16 RightY                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
