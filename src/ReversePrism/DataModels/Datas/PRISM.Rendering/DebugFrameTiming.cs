using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 DebugFrameTiming IL2CPP_TYPE_CLASS
    // 000 SampleHistorySize                        int IL2CPP_TYPE_I4
    // 010 FrameTimeSample                          0001865D64C0 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    // 028 FrameTimeSampleHistory                   0001865BF960 ModelClassType FrameTimeSampleHistory FrameTimeSampleHistory FrameTimeSampleHistory Pointer
    // 030 FrameTimings                             000185B7FF10 ModelEnumListType FrameTiming[] FrameTiming[] List<FrameTiming> Pointer
    public partial class DebugFrameTiming
    {
        public FrameTimeSample                          FrameTimeSample                         { get; set; }
        public FrameTimeSampleHistory?                  FrameTimeSampleHistory                  { get; set; }
        public List<FrameTiming>?                       FrameTimings                            { get; set; }

        public static DebugFrameTiming? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugFrameTiming();

            value.FrameTimeSample                           = (FrameTimeSample)GetInt32(new IntPtr(p + 0x010)); // 0270DBA9AA70 0x10 FrameTimeSample             ( 0001865D64C0 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )
            value.FrameTimeSampleHistory                    = GetObject<FrameTimeSampleHistory>(new IntPtr(p + 0x028), ReversePrism.DataModels.FrameTimeSampleHistory.FromPointer); // 0270DBA9AA90 0x28 FrameTimeSampleHistory      ( 0001865BF960 ModelClassType FrameTimeSampleHistory FrameTimeSampleHistory FrameTimeSampleHistory Pointer )
            value.FrameTimings                              = GetEnumList<FrameTiming>(new IntPtr(p + 0x030)); // 0270DBA9AAB0 0x30 FrameTimings                ( 000185B7FF10 ModelEnumListType FrameTiming[] FrameTiming[] List<FrameTiming> Pointer )

            return value;
        }
    }
}
