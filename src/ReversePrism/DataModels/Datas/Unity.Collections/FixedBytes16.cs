using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte0000                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte0001                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte0002                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte0003                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte0004                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte0005                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte0006                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte0007                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Byte0008                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Byte0009                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Byte0010                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Byte0011                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Byte0012                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Byte0013                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Byte0014                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Byte0015                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes16
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
            var value   = new FixedBytes16();

            value.Byte0000                                  = GetSByte(new IntPtr(p + 0x010)); // 0270D98A63E8 0x10 Byte0000                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0001                                  = GetSByte(new IntPtr(p + 0x011)); // 0270D98A6408 0x11 Byte0001                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0002                                  = GetSByte(new IntPtr(p + 0x012)); // 0270D98A6428 0x12 Byte0002                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0003                                  = GetSByte(new IntPtr(p + 0x013)); // 0270D98A6448 0x13 Byte0003                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0004                                  = GetSByte(new IntPtr(p + 0x014)); // 0270D98A6468 0x14 Byte0004                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0005                                  = GetSByte(new IntPtr(p + 0x015)); // 0270D98A6488 0x15 Byte0005                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0006                                  = GetSByte(new IntPtr(p + 0x016)); // 0270D98A64A8 0x16 Byte0006                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0007                                  = GetSByte(new IntPtr(p + 0x017)); // 0270D98A64C8 0x17 Byte0007                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0008                                  = GetSByte(new IntPtr(p + 0x018)); // 0270D98A64E8 0x18 Byte0008                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0009                                  = GetSByte(new IntPtr(p + 0x019)); // 0270D98A6508 0x19 Byte0009                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0010                                  = GetSByte(new IntPtr(p + 0x01A)); // 0270D98A6528 0x1A Byte0010                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0011                                  = GetSByte(new IntPtr(p + 0x01B)); // 0270D98A6548 0x1B Byte0011                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0012                                  = GetSByte(new IntPtr(p + 0x01C)); // 0270D98A6568 0x1C Byte0012                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0013                                  = GetSByte(new IntPtr(p + 0x01D)); // 0270D98A6588 0x1D Byte0013                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0014                                  = GetSByte(new IntPtr(p + 0x01E)); // 0270D98A65A8 0x1E Byte0014                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0015                                  = GetSByte(new IntPtr(p + 0x01F)); // 0270D98A65C8 0x1F Byte0015                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
