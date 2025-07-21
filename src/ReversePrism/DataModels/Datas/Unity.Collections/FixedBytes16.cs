using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte0000                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte0001                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte0002                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte0003                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte0004                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte0005                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte0006                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte0007                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Byte0008                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Byte0009                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Byte0010                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Byte0011                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Byte0012                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Byte0013                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Byte0014                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Byte0015                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes16 : DataModel
    {
        public sbyte                                    Byte0000                                { get; set; }
        public sbyte                                    Byte0001                                { get; set; }
        public sbyte                                    Byte0002                                { get; set; }
        public sbyte                                    Byte0003                                { get; set; }
        public sbyte                                    Byte0004                                { get; set; }
        public sbyte                                    Byte0005                                { get; set; }
        public sbyte                                    Byte0006                                { get; set; }
        public sbyte                                    Byte0007                                { get; set; }
        public sbyte                                    Byte0008                                { get; set; }
        public sbyte                                    Byte0009                                { get; set; }
        public sbyte                                    Byte0010                                { get; set; }
        public sbyte                                    Byte0011                                { get; set; }
        public sbyte                                    Byte0012                                { get; set; }
        public sbyte                                    Byte0013                                { get; set; }
        public sbyte                                    Byte0014                                { get; set; }
        public sbyte                                    Byte0015                                { get; set; }

        public static FixedBytes16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes16() { Pointer= p0 };

            value.Byte0000                                  = GetSByte(new IntPtr(p + 0x010)); // 0x10 Byte0000                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0001                                  = GetSByte(new IntPtr(p + 0x011)); // 0x11 Byte0001                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0002                                  = GetSByte(new IntPtr(p + 0x012)); // 0x12 Byte0002                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0003                                  = GetSByte(new IntPtr(p + 0x013)); // 0x13 Byte0003                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0004                                  = GetSByte(new IntPtr(p + 0x014)); // 0x14 Byte0004                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0005                                  = GetSByte(new IntPtr(p + 0x015)); // 0x15 Byte0005                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0006                                  = GetSByte(new IntPtr(p + 0x016)); // 0x16 Byte0006                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0007                                  = GetSByte(new IntPtr(p + 0x017)); // 0x17 Byte0007                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0008                                  = GetSByte(new IntPtr(p + 0x018)); // 0x18 Byte0008                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0009                                  = GetSByte(new IntPtr(p + 0x019)); // 0x19 Byte0009                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0010                                  = GetSByte(new IntPtr(p + 0x01A)); // 0x1A Byte0010                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0011                                  = GetSByte(new IntPtr(p + 0x01B)); // 0x1B Byte0011                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0012                                  = GetSByte(new IntPtr(p + 0x01C)); // 0x1C Byte0012                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0013                                  = GetSByte(new IntPtr(p + 0x01D)); // 0x1D Byte0013                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0014                                  = GetSByte(new IntPtr(p + 0x01E)); // 0x1E Byte0014                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0015                                  = GetSByte(new IntPtr(p + 0x01F)); // 0x1F Byte0015                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
