using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_FpsFormatString                        string IL2CPP_TYPE_STRING
    // 000 k_MsFormatString                         string IL2CPP_TYPE_STRING
    // 000 k_RefreshRate                            float IL2CPP_TYPE_R4
    // 010 M_FrameHistory                           ModelClassType FrameTimeSampleHistory FrameTimeSampleHistory FrameTimeSampleHistory Pointer
    // 018 M_BottleneckHistory                      ModelClassType BottleneckHistory BottleneckHistory BottleneckHistory Pointer
    // 020 BottleneckHistorySize                    ModelPrimitiveType int int int Int32
    // 024 SampleHistorySize                        ModelPrimitiveType int int int Int32
    // 028 M_Timing                                 ModelEnumListType FrameTiming[] FrameTiming[] List<FrameTiming> Pointer
    // 030 M_Sample                                 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    public partial class DebugFrameTiming : DataModel
    {
        public FrameTimeSampleHistory?                  M_FrameHistory                          { get; set; }
        public BottleneckHistory?                       M_BottleneckHistory                     { get; set; }
        public int                                      BottleneckHistorySize                   { get; set; }
        public int                                      SampleHistorySize                       { get; set; }
        public List<FrameTiming>?                       M_Timing                                { get; set; }
        public FrameTimeSample                          M_Sample                                { get; set; }

        public static DebugFrameTiming? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugFrameTiming() { Pointer= p0 };

            value.M_FrameHistory                            = GetObject<FrameTimeSampleHistory>(new IntPtr(p + 0x010), ReversePrism.DataModels.FrameTimeSampleHistory.FromPointer); // 0x10 M_FrameHistory              ( ModelClassType FrameTimeSampleHistory FrameTimeSampleHistory FrameTimeSampleHistory Pointer )
            value.M_BottleneckHistory                       = GetObject<BottleneckHistory>(new IntPtr(p + 0x018), ReversePrism.DataModels.BottleneckHistory.FromPointer); // 0x18 M_BottleneckHistory         ( ModelClassType BottleneckHistory BottleneckHistory BottleneckHistory Pointer )
            value.BottleneckHistorySize                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 BottleneckHistorySize       ( ModelPrimitiveType int int int Int32 )
            value.SampleHistorySize                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 SampleHistorySize           ( ModelPrimitiveType int int int Int32 )
            value.M_Timing                                  = GetEnumList<FrameTiming>(new IntPtr(p + 0x028)); // 0x28 M_Timing                    ( ModelEnumListType FrameTiming[] FrameTiming[] List<FrameTiming> Pointer )
            value.M_Sample                                  = (FrameTimeSample)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_Sample                    ( ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )

            return value;
        }
    }
}
