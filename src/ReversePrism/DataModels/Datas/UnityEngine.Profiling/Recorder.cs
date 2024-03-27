using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_InvalidRecorder                        Recorder IL2CPP_TYPE_CLASS
    // 010 M_RecorderCPU                            000186647080 ModelEnumType ProfilerRecorder ProfilerRecorder ProfilerRecorder Int32
    // 018 M_RecorderGPU                            000186647080 ModelEnumType ProfilerRecorder ProfilerRecorder ProfilerRecorder Int32
    public partial class Recorder
    {
        public ProfilerRecorder                         M_RecorderCPU                           { get; set; }
        public ProfilerRecorder                         M_RecorderGPU                           { get; set; }

        public static Recorder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Recorder();

            value.M_RecorderCPU                             = (ProfilerRecorder)GetInt32(new IntPtr(p + 0x010)); // 02700242C0E8 0x10 M_RecorderCPU               ( 000186647080 ModelEnumType ProfilerRecorder ProfilerRecorder ProfilerRecorder Int32 )
            value.M_RecorderGPU                             = (ProfilerRecorder)GetInt32(new IntPtr(p + 0x018)); // 02700242C108 0x18 M_RecorderGPU               ( 000186647080 ModelEnumType ProfilerRecorder ProfilerRecorder ProfilerRecorder Int32 )

            return value;
        }
    }
}
