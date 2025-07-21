using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SECRET_LIMIT                             int IL2CPP_TYPE_I4
    // 004 NB_STRIPES_PER_BLOCK                     int IL2CPP_TYPE_I4
    // 008 INTERNAL_BUFFER_SIZE                     int IL2CPP_TYPE_I4
    // 00C INTERNAL_BUFFER_STRIPES                  int IL2CPP_TYPE_I4
    // 010 State                                    ModelEnumType StreamingStateData StreamingStateData StreamingStateData Int32
    public partial class StreamingState : DataModel
    {
        public StreamingStateData                       State                                   { get; set; }

        public static StreamingState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamingState() { Pointer= p0 };

            value.State                                     = (StreamingStateData)GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelEnumType StreamingStateData StreamingStateData StreamingStateData Int32 )

            return value;
        }
    }
}
