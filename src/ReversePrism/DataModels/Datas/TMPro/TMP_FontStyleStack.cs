using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bold                                     00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Italic                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Underline                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Strikethrough                            00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Highlight                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Superscript                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Subscript                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Uppercase                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Lowercase                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Smallcaps                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class TMP_FontStyleStack : DataModel
    {
        public sbyte                                    Bold                                    { get; set; }
        public sbyte                                    Italic                                  { get; set; }
        public sbyte                                    Underline                               { get; set; }
        public sbyte                                    Strikethrough                           { get; set; }
        public sbyte                                    Highlight                               { get; set; }
        public sbyte                                    Superscript                             { get; set; }
        public sbyte                                    Subscript                               { get; set; }
        public sbyte                                    Uppercase                               { get; set; }
        public sbyte                                    Lowercase                               { get; set; }
        public sbyte                                    Smallcaps                               { get; set; }

        public static TMP_FontStyleStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_FontStyleStack() { Pointer= p0 };

            value.Bold                                      = GetSByte(new IntPtr(p + 0x010)); // 024660942548 0x10 Bold                        ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Italic                                    = GetSByte(new IntPtr(p + 0x011)); // 024660942568 0x11 Italic                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Underline                                 = GetSByte(new IntPtr(p + 0x012)); // 024660942588 0x12 Underline                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Strikethrough                             = GetSByte(new IntPtr(p + 0x013)); // 0246609425A8 0x13 Strikethrough               ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Highlight                                 = GetSByte(new IntPtr(p + 0x014)); // 0246609425C8 0x14 Highlight                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Superscript                               = GetSByte(new IntPtr(p + 0x015)); // 0246609425E8 0x15 Superscript                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Subscript                                 = GetSByte(new IntPtr(p + 0x016)); // 024660942608 0x16 Subscript                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Uppercase                                 = GetSByte(new IntPtr(p + 0x017)); // 024660942628 0x17 Uppercase                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Lowercase                                 = GetSByte(new IntPtr(p + 0x018)); // 024660942648 0x18 Lowercase                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Smallcaps                                 = GetSByte(new IntPtr(p + 0x019)); // 024660942668 0x19 Smallcaps                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
