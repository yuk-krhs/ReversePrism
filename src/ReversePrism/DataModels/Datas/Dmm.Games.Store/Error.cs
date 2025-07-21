using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  ModelPrimitiveType string string string String
    // 018 Class                                    ModelPrimitiveType string string string String
    // 020 StackTraces                              ModelClassListType List`1<StackTraceElement> List`1<StackTraceElement> List<StackTraceElement> Pointer
    // 028 Cause                                    ModelClassType Error Error Error Pointer
    public partial class Error : DataModel
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
            var value   = new Error() { Pointer= p0 };

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Message                     ( ModelPrimitiveType string string string String )
            value.Class                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Class                       ( ModelPrimitiveType string string string String )
            value.StackTraces                               = GetObjectList<StackTraceElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.StackTraceElement.FromPointer); // 0x20 StackTraces                 ( ModelClassListType List`1<StackTraceElement> List`1<StackTraceElement> List<StackTraceElement> Pointer )
            value.Cause                                     = GetObject<Error>(new IntPtr(p + 0x028), ReversePrism.DataModels.Error.FromPointer); // 0x28 Cause                       ( ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
