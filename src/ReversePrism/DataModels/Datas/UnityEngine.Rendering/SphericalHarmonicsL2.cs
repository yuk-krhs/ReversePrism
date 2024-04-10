using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Shr0                                     0001866656B0 ModelPrimitiveType float float float Single
    // 014 Shr1                                     0001866656B0 ModelPrimitiveType float float float Single
    // 018 Shr2                                     0001866656B0 ModelPrimitiveType float float float Single
    // 01C Shr3                                     0001866656B0 ModelPrimitiveType float float float Single
    // 020 Shr4                                     0001866656B0 ModelPrimitiveType float float float Single
    // 024 Shr5                                     0001866656B0 ModelPrimitiveType float float float Single
    // 028 Shr6                                     0001866656B0 ModelPrimitiveType float float float Single
    // 02C Shr7                                     0001866656B0 ModelPrimitiveType float float float Single
    // 030 Shr8                                     0001866656B0 ModelPrimitiveType float float float Single
    // 034 Shg0                                     0001866656B0 ModelPrimitiveType float float float Single
    // 038 Shg1                                     0001866656B0 ModelPrimitiveType float float float Single
    // 03C Shg2                                     0001866656B0 ModelPrimitiveType float float float Single
    // 040 Shg3                                     0001866656B0 ModelPrimitiveType float float float Single
    // 044 Shg4                                     0001866656B0 ModelPrimitiveType float float float Single
    // 048 Shg5                                     0001866656B0 ModelPrimitiveType float float float Single
    // 04C Shg6                                     0001866656B0 ModelPrimitiveType float float float Single
    // 050 Shg7                                     0001866656B0 ModelPrimitiveType float float float Single
    // 054 Shg8                                     0001866656B0 ModelPrimitiveType float float float Single
    // 058 Shb0                                     0001866656B0 ModelPrimitiveType float float float Single
    // 05C Shb1                                     0001866656B0 ModelPrimitiveType float float float Single
    // 060 Shb2                                     0001866656B0 ModelPrimitiveType float float float Single
    // 064 Shb3                                     0001866656B0 ModelPrimitiveType float float float Single
    // 068 Shb4                                     0001866656B0 ModelPrimitiveType float float float Single
    // 06C Shb5                                     0001866656B0 ModelPrimitiveType float float float Single
    // 070 Shb6                                     0001866656B0 ModelPrimitiveType float float float Single
    // 074 Shb7                                     0001866656B0 ModelPrimitiveType float float float Single
    // 078 Shb8                                     0001866656B0 ModelPrimitiveType float float float Single
    public partial class SphericalHarmonicsL2 : DataModel
    {
        public float                                    Shr0                                    { get; set; }
        public float                                    Shr1                                    { get; set; }
        public float                                    Shr2                                    { get; set; }
        public float                                    Shr3                                    { get; set; }
        public float                                    Shr4                                    { get; set; }
        public float                                    Shr5                                    { get; set; }
        public float                                    Shr6                                    { get; set; }
        public float                                    Shr7                                    { get; set; }
        public float                                    Shr8                                    { get; set; }
        public float                                    Shg0                                    { get; set; }
        public float                                    Shg1                                    { get; set; }
        public float                                    Shg2                                    { get; set; }
        public float                                    Shg3                                    { get; set; }
        public float                                    Shg4                                    { get; set; }
        public float                                    Shg5                                    { get; set; }
        public float                                    Shg6                                    { get; set; }
        public float                                    Shg7                                    { get; set; }
        public float                                    Shg8                                    { get; set; }
        public float                                    Shb0                                    { get; set; }
        public float                                    Shb1                                    { get; set; }
        public float                                    Shb2                                    { get; set; }
        public float                                    Shb3                                    { get; set; }
        public float                                    Shb4                                    { get; set; }
        public float                                    Shb5                                    { get; set; }
        public float                                    Shb6                                    { get; set; }
        public float                                    Shb7                                    { get; set; }
        public float                                    Shb8                                    { get; set; }

        public static SphericalHarmonicsL2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SphericalHarmonicsL2() { Pointer= p0 };

            value.Shr0                                      = GetSingle(new IntPtr(p + 0x010)); // 0245A2479C60 0x10 Shr0                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr1                                      = GetSingle(new IntPtr(p + 0x014)); // 0245A2479C80 0x14 Shr1                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr2                                      = GetSingle(new IntPtr(p + 0x018)); // 0245A2479CA0 0x18 Shr2                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr3                                      = GetSingle(new IntPtr(p + 0x01C)); // 0245A2479CC0 0x1C Shr3                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr4                                      = GetSingle(new IntPtr(p + 0x020)); // 0245A2479CE0 0x20 Shr4                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr5                                      = GetSingle(new IntPtr(p + 0x024)); // 0245A2479D00 0x24 Shr5                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr6                                      = GetSingle(new IntPtr(p + 0x028)); // 0245A2479D20 0x28 Shr6                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr7                                      = GetSingle(new IntPtr(p + 0x02C)); // 0245A2479D40 0x2C Shr7                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shr8                                      = GetSingle(new IntPtr(p + 0x030)); // 0245A2479D60 0x30 Shr8                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg0                                      = GetSingle(new IntPtr(p + 0x034)); // 0245A2479D80 0x34 Shg0                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg1                                      = GetSingle(new IntPtr(p + 0x038)); // 0245A2479DA0 0x38 Shg1                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg2                                      = GetSingle(new IntPtr(p + 0x03C)); // 0245A2479DC0 0x3C Shg2                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg3                                      = GetSingle(new IntPtr(p + 0x040)); // 0245A2479DE0 0x40 Shg3                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg4                                      = GetSingle(new IntPtr(p + 0x044)); // 0245A2479E00 0x44 Shg4                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg5                                      = GetSingle(new IntPtr(p + 0x048)); // 0245A2479E20 0x48 Shg5                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg6                                      = GetSingle(new IntPtr(p + 0x04C)); // 0245A2479E40 0x4C Shg6                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg7                                      = GetSingle(new IntPtr(p + 0x050)); // 0245A2479E60 0x50 Shg7                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shg8                                      = GetSingle(new IntPtr(p + 0x054)); // 0245A2479E80 0x54 Shg8                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb0                                      = GetSingle(new IntPtr(p + 0x058)); // 0245A2479EA0 0x58 Shb0                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb1                                      = GetSingle(new IntPtr(p + 0x05C)); // 0245A2479EC0 0x5C Shb1                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb2                                      = GetSingle(new IntPtr(p + 0x060)); // 0245A2479EE0 0x60 Shb2                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb3                                      = GetSingle(new IntPtr(p + 0x064)); // 0245A2479F00 0x64 Shb3                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb4                                      = GetSingle(new IntPtr(p + 0x068)); // 0245A2479F20 0x68 Shb4                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb5                                      = GetSingle(new IntPtr(p + 0x06C)); // 0245A2479F40 0x6C Shb5                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb6                                      = GetSingle(new IntPtr(p + 0x070)); // 0245A2479F60 0x70 Shb6                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb7                                      = GetSingle(new IntPtr(p + 0x074)); // 0245A2479F80 0x74 Shb7                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Shb8                                      = GetSingle(new IntPtr(p + 0x078)); // 0245A2479FA0 0x78 Shb8                        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
