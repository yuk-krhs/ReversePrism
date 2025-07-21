using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 parsedEnum                               <object> IL2CPP_TYPE_OBJECT
    // 018 CanThrow                                 ModelPrimitiveType bool bool bool Bool
    // 01C M_failure                                ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32
    // 020 M_failureMessageID                       ModelPrimitiveType string string string String
    // 028 M_failureParameter                       ModelPrimitiveType string string string String
    // 030 m_failureMessageFormatArgument           <object> IL2CPP_TYPE_OBJECT
    // 038 M_innerException                         ModelClassType Exception Exception Exception Pointer
    public partial class EnumResult : DataModel
    {
        public bool                                     CanThrow                                { get; set; }
        public ParseFailureKind                         M_failure                               { get; set; }
        public string                                   M_failureMessageID                      { get; set; }
        public string                                   M_failureParameter                      { get; set; }
        public Exception?                               M_innerException                        { get; set; }

        public static EnumResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumResult() { Pointer= p0 };

            value.CanThrow                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 CanThrow                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_failure                                 = (ParseFailureKind)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_failure                   ( ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32 )
            value.M_failureMessageID                        = GetString(new IntPtr(p + 0x020)); // 0x20 M_failureMessageID          ( ModelPrimitiveType string string string String )
            value.M_failureParameter                        = GetString(new IntPtr(p + 0x028)); // 0x28 M_failureParameter          ( ModelPrimitiveType string string string String )
            value.M_innerException                          = GetObject<Exception>(new IntPtr(p + 0x038), ReversePrism.DataModels.Exception.FromPointer); // 0x38 M_innerException            ( ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
