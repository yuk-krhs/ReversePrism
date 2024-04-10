using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_cache                                  LeaveExceptionHandlerInstruction[] IL2CPP_TYPE_SZARRAY
    // 018 HasValue                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class LeaveExceptionHandlerInstruction : DataModel
    {
        public bool                                     HasValue                                { get; set; }

        public static LeaveExceptionHandlerInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LeaveExceptionHandlerInstruction() { Pointer= p0 };

            value.HasValue                                  = GetBool(new IntPtr(p + 0x018)); // 02466A012150 0x18 HasValue                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
