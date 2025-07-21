using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Kind                                     ModelEnumType NumberFormatKind NumberFormatKind NumberFormatKind Int32
    // 011 AlignAndSize                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Specifier                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Lowercase                                ModelPrimitiveType bool bool bool Bool
    public partial class FormatOptions : DataModel
    {
        public NumberFormatKind                         Kind                                    { get; set; }
        public sbyte                                    AlignAndSize                            { get; set; }
        public sbyte                                    Specifier                               { get; set; }
        public bool                                     Lowercase                               { get; set; }

        public static FormatOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FormatOptions() { Pointer= p0 };

            value.Kind                                      = (NumberFormatKind)GetInt32(new IntPtr(p + 0x010)); // 0x10 Kind                        ( ModelEnumType NumberFormatKind NumberFormatKind NumberFormatKind Int32 )
            value.AlignAndSize                              = GetSByte(new IntPtr(p + 0x011)); // 0x11 AlignAndSize                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Specifier                                 = GetSByte(new IntPtr(p + 0x012)); // 0x12 Specifier                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Lowercase                                 = GetBool(new IntPtr(p + 0x013)); // 0x13 Lowercase                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
