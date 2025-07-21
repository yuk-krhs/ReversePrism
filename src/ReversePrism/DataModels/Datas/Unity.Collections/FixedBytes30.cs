using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 020 Byte0016                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 021 Byte0017                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 022 Byte0018                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 023 Byte0019                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 024 Byte0020                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 025 Byte0021                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 026 Byte0022                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 027 Byte0023                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 028 Byte0024                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 029 Byte0025                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02A Byte0026                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B Byte0027                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C Byte0028                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02D Byte0029                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes30 : DataModel
    {
        public FixedBytes16                             Offset0000                              { get; set; }
        public sbyte                                    Byte0016                                { get; set; }
        public sbyte                                    Byte0017                                { get; set; }
        public sbyte                                    Byte0018                                { get; set; }
        public sbyte                                    Byte0019                                { get; set; }
        public sbyte                                    Byte0020                                { get; set; }
        public sbyte                                    Byte0021                                { get; set; }
        public sbyte                                    Byte0022                                { get; set; }
        public sbyte                                    Byte0023                                { get; set; }
        public sbyte                                    Byte0024                                { get; set; }
        public sbyte                                    Byte0025                                { get; set; }
        public sbyte                                    Byte0026                                { get; set; }
        public sbyte                                    Byte0027                                { get; set; }
        public sbyte                                    Byte0028                                { get; set; }
        public sbyte                                    Byte0029                                { get; set; }

        public static FixedBytes30? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes30() { Pointer= p0 };

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 0x10 Offset0000                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte0016                                  = GetSByte(new IntPtr(p + 0x020)); // 0x20 Byte0016                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0017                                  = GetSByte(new IntPtr(p + 0x021)); // 0x21 Byte0017                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0018                                  = GetSByte(new IntPtr(p + 0x022)); // 0x22 Byte0018                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0019                                  = GetSByte(new IntPtr(p + 0x023)); // 0x23 Byte0019                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0020                                  = GetSByte(new IntPtr(p + 0x024)); // 0x24 Byte0020                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0021                                  = GetSByte(new IntPtr(p + 0x025)); // 0x25 Byte0021                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0022                                  = GetSByte(new IntPtr(p + 0x026)); // 0x26 Byte0022                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0023                                  = GetSByte(new IntPtr(p + 0x027)); // 0x27 Byte0023                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0024                                  = GetSByte(new IntPtr(p + 0x028)); // 0x28 Byte0024                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0025                                  = GetSByte(new IntPtr(p + 0x029)); // 0x29 Byte0025                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0026                                  = GetSByte(new IntPtr(p + 0x02A)); // 0x2A Byte0026                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0027                                  = GetSByte(new IntPtr(p + 0x02B)); // 0x2B Byte0027                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0028                                  = GetSByte(new IntPtr(p + 0x02C)); // 0x2C Byte0028                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0029                                  = GetSByte(new IntPtr(p + 0x02D)); // 0x2D Byte0029                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
