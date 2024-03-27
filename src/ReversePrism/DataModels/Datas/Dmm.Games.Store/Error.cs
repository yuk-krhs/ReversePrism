using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  0001866722E0 ModelPrimitiveType string string string String
    // 018 Class                                    0001866722E0 ModelPrimitiveType string string string String
    // 020 StackTraces                              000185D0C388 ModelClassListType List`1<StackTraceElement> List`1<StackTraceElement> List<StackTraceElement> Pointer
    // 028 Cause                                    0001865C8690 ModelClassType Error Error Error Pointer
    public partial class Error
    {
        public string                                   Message                                 { get; set; }
        public string                                   Class                                   { get; set; }
        public List<StackTraceElement>?                 StackTraces                             { get; set; }
        public Error?                                   Cause                                   { get; set; }

        public static Error? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Error();

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 0270DB49B820 0x10 Message                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Class                                     = GetString(new IntPtr(p + 0x018)); // 0270DB49B840 0x18 Class                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StackTraces                               = GetObjectList<StackTraceElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.StackTraceElement.FromPointer); // 0270DB49B860 0x20 StackTraces                 ( 000185D0C388 ModelClassListType List`1<StackTraceElement> List`1<StackTraceElement> List<StackTraceElement> Pointer )
            value.Cause                                     = GetObject<Error>(new IntPtr(p + 0x028), ReversePrism.DataModels.Error.FromPointer); // 0270DB49B880 0x28 Cause                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
