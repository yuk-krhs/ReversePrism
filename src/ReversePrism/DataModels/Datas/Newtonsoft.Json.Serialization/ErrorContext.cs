using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Traced                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Error                                    0001865CB1C0 ModelClassType Exception Exception Exception Pointer
    // 020 <OriginalObject>k__BackingField          <object> IL2CPP_TYPE_OBJECT
    // 028 <Member>k__BackingField                  <object> IL2CPP_TYPE_OBJECT
    // 030 Path                                     000186672F10 ModelPrimitiveType string string string String
    // 038 Handled                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ErrorContext : DataModel
    {
        public bool                                     Traced                                  { get; set; }
        public Exception?                               Error                                   { get; set; }
        public string                                   Path                                    { get; set; }
        public bool                                     Handled                                 { get; set; }

        public static ErrorContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorContext() { Pointer= p0 };

            value.Traced                                    = GetBool(new IntPtr(p + 0x010)); // 0246687C5400 0x10 Traced                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Error                                     = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0246687C5420 0x18 Error                       ( 0001865CB1C0 ModelClassType Exception Exception Exception Pointer )
            value.Path                                      = GetString(new IntPtr(p + 0x030)); // 0246687C5480 0x30 Path                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Handled                                   = GetBool(new IntPtr(p + 0x038)); // 0246687C54A0 0x38 Handled                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
