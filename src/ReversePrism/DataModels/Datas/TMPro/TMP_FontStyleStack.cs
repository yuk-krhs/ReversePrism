using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bold                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Italic                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Underline                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Strikethrough                            ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Highlight                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Superscript                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Subscript                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Uppercase                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Lowercase                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Smallcaps                                ModelPrimitiveType sbyte sbyte sbyte SByte
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

            value.Bold                                      = GetSByte(new IntPtr(p + 0x010)); // 0x10 Bold                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Italic                                    = GetSByte(new IntPtr(p + 0x011)); // 0x11 Italic                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Underline                                 = GetSByte(new IntPtr(p + 0x012)); // 0x12 Underline                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Strikethrough                             = GetSByte(new IntPtr(p + 0x013)); // 0x13 Strikethrough               ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Highlight                                 = GetSByte(new IntPtr(p + 0x014)); // 0x14 Highlight                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Superscript                               = GetSByte(new IntPtr(p + 0x015)); // 0x15 Superscript                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Subscript                                 = GetSByte(new IntPtr(p + 0x016)); // 0x16 Subscript                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Uppercase                                 = GetSByte(new IntPtr(p + 0x017)); // 0x17 Uppercase                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Lowercase                                 = GetSByte(new IntPtr(p + 0x018)); // 0x18 Lowercase                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Smallcaps                                 = GetSByte(new IntPtr(p + 0x019)); // 0x19 Smallcaps                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
