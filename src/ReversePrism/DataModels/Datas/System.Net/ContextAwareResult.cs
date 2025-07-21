using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Context                                  ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 048 _lock                                    <object> IL2CPP_TYPE_OBJECT
    // 050 Flags                                    ModelEnumType StateFlags StateFlags StateFlags Int32
    public partial class ContextAwareResult : DataModel
    {
        public ExecutionContext?                        Context                                 { get; set; }
        public StateFlags                               Flags                                   { get; set; }

        public static ContextAwareResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextAwareResult() { Pointer= p0 };

            value.Context                                   = GetObject<ExecutionContext>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0x40 Context                     ( ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.Flags                                     = (StateFlags)GetInt32(new IntPtr(p + 0x050)); // 0x50 Flags                       ( ModelEnumType StateFlags StateFlags StateFlags Int32 )

            return value;
        }
    }
}
