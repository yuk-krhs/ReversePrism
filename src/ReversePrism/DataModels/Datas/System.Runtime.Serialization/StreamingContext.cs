using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_additionalContext                      <object> IL2CPP_TYPE_OBJECT
    // 018 M_state                                  ModelEnumType StreamingContextStates StreamingContextStates StreamingContextStates Int32
    public partial class StreamingContext : DataModel
    {
        public StreamingContextStates                   M_state                                 { get; set; }

        public static StreamingContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamingContext() { Pointer= p0 };

            value.M_state                                   = (StreamingContextStates)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_state                     ( ModelEnumType StreamingContextStates StreamingContextStates StreamingContextStates Int32 )

            return value;
        }
    }
}
