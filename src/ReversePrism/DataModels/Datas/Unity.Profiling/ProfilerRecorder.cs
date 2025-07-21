using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   ModelPrimitiveType ulong ulong ulong UInt64
    // 000 SharedRecorder                           ProfilerRecorderOptions IL2CPP_TYPE_VALUETYPE
    public partial class ProfilerRecorder : DataModel
    {
        public ulong                                    Handle                                  { get; set; }

        public static ProfilerRecorder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerRecorder() { Pointer= p0 };

            value.Handle                                    = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Handle                      ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
