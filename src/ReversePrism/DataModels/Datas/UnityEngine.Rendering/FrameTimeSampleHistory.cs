using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Samples                                ModelEnumListType List`1<FrameTimeSample> List`1<FrameTimeSample> List<FrameTimeSample> Pointer
    // 018 SampleAverage                            ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    // 030 SampleMin                                ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    // 048 SampleMax                                ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    // 000 s_SampleValueAdd                         Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 008 s_SampleValueMin                         Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 010 s_SampleValueMax                         Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 018 s_SampleValueCountValid                  Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 020 s_SampleValueEnsureValid                 Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 028 s_SampleValueDivide                      Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    public partial class FrameTimeSampleHistory : DataModel
    {
        public List<FrameTimeSample>?                   M_Samples                               { get; set; }
        public FrameTimeSample                          SampleAverage                           { get; set; }
        public FrameTimeSample                          SampleMin                               { get; set; }
        public FrameTimeSample                          SampleMax                               { get; set; }

        public static FrameTimeSampleHistory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameTimeSampleHistory() { Pointer= p0 };

            value.M_Samples                                 = GetEnumList<FrameTimeSample>(new IntPtr(p + 0x010)); // 0x10 M_Samples                   ( ModelEnumListType List`1<FrameTimeSample> List`1<FrameTimeSample> List<FrameTimeSample> Pointer )
            value.SampleAverage                             = (FrameTimeSample)GetInt32(new IntPtr(p + 0x018)); // 0x18 SampleAverage               ( ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )
            value.SampleMin                                 = (FrameTimeSample)GetInt32(new IntPtr(p + 0x030)); // 0x30 SampleMin                   ( ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )
            value.SampleMax                                 = (FrameTimeSample)GetInt32(new IntPtr(p + 0x048)); // 0x48 SampleMax                   ( ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )

            return value;
        }
    }
}
