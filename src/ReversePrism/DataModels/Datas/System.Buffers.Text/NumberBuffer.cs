using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scale                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 IsNegative                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 015 B0                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 B1                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 B2                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 B3                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 B4                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A B5                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B B6                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C B7                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D B8                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E B9                                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F B10                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 020 B11                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 021 B12                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 022 B13                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 023 B14                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 024 B15                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 025 B16                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 026 B17                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 027 B18                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 028 B19                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 029 B20                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02A B21                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B B22                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C B23                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02D B24                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02E B25                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02F B26                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 030 B27                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 031 B28                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 032 B29                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 033 B30                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 034 B31                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 035 B32                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 036 B33                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 037 B34                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 038 B35                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 039 B36                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03A B37                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03B B38                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03C B39                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03D B40                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03E B41                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 03F B42                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 040 B43                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 041 B44                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 042 B45                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 043 B46                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 044 B47                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 045 B48                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 046 B49                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 047 B50                                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class NumberBuffer : DataModel
    {
        public int                                      Scale                                   { get; set; }
        public bool                                     IsNegative                              { get; set; }
        public sbyte                                    B0                                      { get; set; }
        public sbyte                                    B1                                      { get; set; }
        public sbyte                                    B2                                      { get; set; }
        public sbyte                                    B3                                      { get; set; }
        public sbyte                                    B4                                      { get; set; }
        public sbyte                                    B5                                      { get; set; }
        public sbyte                                    B6                                      { get; set; }
        public sbyte                                    B7                                      { get; set; }
        public sbyte                                    B8                                      { get; set; }
        public sbyte                                    B9                                      { get; set; }
        public sbyte                                    B10                                     { get; set; }
        public sbyte                                    B11                                     { get; set; }
        public sbyte                                    B12                                     { get; set; }
        public sbyte                                    B13                                     { get; set; }
        public sbyte                                    B14                                     { get; set; }
        public sbyte                                    B15                                     { get; set; }
        public sbyte                                    B16                                     { get; set; }
        public sbyte                                    B17                                     { get; set; }
        public sbyte                                    B18                                     { get; set; }
        public sbyte                                    B19                                     { get; set; }
        public sbyte                                    B20                                     { get; set; }
        public sbyte                                    B21                                     { get; set; }
        public sbyte                                    B22                                     { get; set; }
        public sbyte                                    B23                                     { get; set; }
        public sbyte                                    B24                                     { get; set; }
        public sbyte                                    B25                                     { get; set; }
        public sbyte                                    B26                                     { get; set; }
        public sbyte                                    B27                                     { get; set; }
        public sbyte                                    B28                                     { get; set; }
        public sbyte                                    B29                                     { get; set; }
        public sbyte                                    B30                                     { get; set; }
        public sbyte                                    B31                                     { get; set; }
        public sbyte                                    B32                                     { get; set; }
        public sbyte                                    B33                                     { get; set; }
        public sbyte                                    B34                                     { get; set; }
        public sbyte                                    B35                                     { get; set; }
        public sbyte                                    B36                                     { get; set; }
        public sbyte                                    B37                                     { get; set; }
        public sbyte                                    B38                                     { get; set; }
        public sbyte                                    B39                                     { get; set; }
        public sbyte                                    B40                                     { get; set; }
        public sbyte                                    B41                                     { get; set; }
        public sbyte                                    B42                                     { get; set; }
        public sbyte                                    B43                                     { get; set; }
        public sbyte                                    B44                                     { get; set; }
        public sbyte                                    B45                                     { get; set; }
        public sbyte                                    B46                                     { get; set; }
        public sbyte                                    B47                                     { get; set; }
        public sbyte                                    B48                                     { get; set; }
        public sbyte                                    B49                                     { get; set; }
        public sbyte                                    B50                                     { get; set; }

        public static NumberBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumberBuffer() { Pointer= p0 };

            value.Scale                                     = GetInt32(new IntPtr(p + 0x010)); // 024666E89708 0x10 Scale                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsNegative                                = GetBool(new IntPtr(p + 0x014)); // 024666E89728 0x14 IsNegative                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.B0                                        = GetSByte(new IntPtr(p + 0x015)); // 024666E89748 0x15 B0                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B1                                        = GetSByte(new IntPtr(p + 0x016)); // 024666E89768 0x16 B1                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B2                                        = GetSByte(new IntPtr(p + 0x017)); // 024666E89788 0x17 B2                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B3                                        = GetSByte(new IntPtr(p + 0x018)); // 024666E897A8 0x18 B3                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B4                                        = GetSByte(new IntPtr(p + 0x019)); // 024666E897C8 0x19 B4                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B5                                        = GetSByte(new IntPtr(p + 0x01A)); // 024666E897E8 0x1A B5                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B6                                        = GetSByte(new IntPtr(p + 0x01B)); // 024666E89808 0x1B B6                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B7                                        = GetSByte(new IntPtr(p + 0x01C)); // 024666E89828 0x1C B7                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B8                                        = GetSByte(new IntPtr(p + 0x01D)); // 024666E89848 0x1D B8                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B9                                        = GetSByte(new IntPtr(p + 0x01E)); // 024666E89868 0x1E B9                          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B10                                       = GetSByte(new IntPtr(p + 0x01F)); // 024666E89888 0x1F B10                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B11                                       = GetSByte(new IntPtr(p + 0x020)); // 024666E898A8 0x20 B11                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B12                                       = GetSByte(new IntPtr(p + 0x021)); // 024666E898C8 0x21 B12                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B13                                       = GetSByte(new IntPtr(p + 0x022)); // 024666E898E8 0x22 B13                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B14                                       = GetSByte(new IntPtr(p + 0x023)); // 024666E89908 0x23 B14                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B15                                       = GetSByte(new IntPtr(p + 0x024)); // 024666E89928 0x24 B15                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B16                                       = GetSByte(new IntPtr(p + 0x025)); // 024666E89948 0x25 B16                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B17                                       = GetSByte(new IntPtr(p + 0x026)); // 024666E89968 0x26 B17                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B18                                       = GetSByte(new IntPtr(p + 0x027)); // 024666E89988 0x27 B18                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B19                                       = GetSByte(new IntPtr(p + 0x028)); // 024666E899A8 0x28 B19                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B20                                       = GetSByte(new IntPtr(p + 0x029)); // 024666E899C8 0x29 B20                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B21                                       = GetSByte(new IntPtr(p + 0x02A)); // 024666E899E8 0x2A B21                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B22                                       = GetSByte(new IntPtr(p + 0x02B)); // 024666E89A08 0x2B B22                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B23                                       = GetSByte(new IntPtr(p + 0x02C)); // 024666E89A28 0x2C B23                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B24                                       = GetSByte(new IntPtr(p + 0x02D)); // 024666E89A48 0x2D B24                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B25                                       = GetSByte(new IntPtr(p + 0x02E)); // 024666E89A68 0x2E B25                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B26                                       = GetSByte(new IntPtr(p + 0x02F)); // 024666E89A88 0x2F B26                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B27                                       = GetSByte(new IntPtr(p + 0x030)); // 024666E89AA8 0x30 B27                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B28                                       = GetSByte(new IntPtr(p + 0x031)); // 024666E89AC8 0x31 B28                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B29                                       = GetSByte(new IntPtr(p + 0x032)); // 024666E89AE8 0x32 B29                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B30                                       = GetSByte(new IntPtr(p + 0x033)); // 024666E89B08 0x33 B30                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B31                                       = GetSByte(new IntPtr(p + 0x034)); // 024666E89B28 0x34 B31                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B32                                       = GetSByte(new IntPtr(p + 0x035)); // 024666E89B48 0x35 B32                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B33                                       = GetSByte(new IntPtr(p + 0x036)); // 024666E89B68 0x36 B33                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B34                                       = GetSByte(new IntPtr(p + 0x037)); // 024666E89B88 0x37 B34                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B35                                       = GetSByte(new IntPtr(p + 0x038)); // 024666E89BA8 0x38 B35                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B36                                       = GetSByte(new IntPtr(p + 0x039)); // 024666E89BC8 0x39 B36                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B37                                       = GetSByte(new IntPtr(p + 0x03A)); // 024666E89BE8 0x3A B37                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B38                                       = GetSByte(new IntPtr(p + 0x03B)); // 024666E89C08 0x3B B38                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B39                                       = GetSByte(new IntPtr(p + 0x03C)); // 024666E89C28 0x3C B39                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B40                                       = GetSByte(new IntPtr(p + 0x03D)); // 024666E89C48 0x3D B40                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B41                                       = GetSByte(new IntPtr(p + 0x03E)); // 024666E89C68 0x3E B41                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B42                                       = GetSByte(new IntPtr(p + 0x03F)); // 024666E89C88 0x3F B42                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B43                                       = GetSByte(new IntPtr(p + 0x040)); // 024666E89CA8 0x40 B43                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B44                                       = GetSByte(new IntPtr(p + 0x041)); // 024666E89CC8 0x41 B44                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B45                                       = GetSByte(new IntPtr(p + 0x042)); // 024666E89CE8 0x42 B45                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B46                                       = GetSByte(new IntPtr(p + 0x043)); // 024666E89D08 0x43 B46                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B47                                       = GetSByte(new IntPtr(p + 0x044)); // 024666E89D28 0x44 B47                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B48                                       = GetSByte(new IntPtr(p + 0x045)); // 024666E89D48 0x45 B48                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B49                                       = GetSByte(new IntPtr(p + 0x046)); // 024666E89D68 0x46 B49                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B50                                       = GetSByte(new IntPtr(p + 0x047)); // 024666E89D88 0x47 B50                         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
