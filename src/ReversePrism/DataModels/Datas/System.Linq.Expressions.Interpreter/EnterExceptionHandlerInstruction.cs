using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Void                                     EnterExceptionHandlerInstruction IL2CPP_TYPE_CLASS
    // 008 NonVoid                                  EnterExceptionHandlerInstruction IL2CPP_TYPE_CLASS
    // 010 HasValue                                 ModelPrimitiveType bool bool bool Bool
    public partial class EnterExceptionHandlerInstruction : DataModel
    {
        public bool                                     HasValue                                { get; set; }

        public static EnterExceptionHandlerInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnterExceptionHandlerInstruction() { Pointer= p0 };

            value.HasValue                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 HasValue                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
