using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrameTimeSamples                         000185CDC878 ModelEnumListType List`1<FrameTimeSample> List`1<FrameTimeSample> List<FrameTimeSample> Pointer
    // 018 SampleAverage                            0001865D6700 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    // 030 SampleMin                                0001865D6700 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    // 048 SampleMax                                0001865D6700 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32
    // 000 SampleValueAdd                           Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 008 SampleValueMin                           Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 010 SampleValueMax                           Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 018 SampleValueCountValid                    Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 020 SampleValueEnsureValid                   Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    // 028 SampleValueDivide                        Func`3<float, float, float> IL2CPP_TYPE_GENERICINST
    public partial class FrameTimeSampleHistory
    {
        public List<FrameTimeSample>?                   FrameTimeSamples                        { get; set; }
        public FrameTimeSample                          SampleAverage                           { get; set; }
        public FrameTimeSample                          SampleMin                               { get; set; }
        public FrameTimeSample                          SampleMax                               { get; set; }

        public static FrameTimeSampleHistory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameTimeSampleHistory();

            value.FrameTimeSamples                          = GetEnumList<FrameTimeSample>(new IntPtr(p + 0x010)); // 0270DBA7DED8 0x10 FrameTimeSamples            ( 000185CDC878 ModelEnumListType List`1<FrameTimeSample> List`1<FrameTimeSample> List<FrameTimeSample> Pointer )
            value.SampleAverage                             = (FrameTimeSample)GetInt32(new IntPtr(p + 0x018)); // 0270DBA7DEF8 0x18 SampleAverage               ( 0001865D6700 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )
            value.SampleMin                                 = (FrameTimeSample)GetInt32(new IntPtr(p + 0x030)); // 0270DBA7DF18 0x30 SampleMin                   ( 0001865D6700 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )
            value.SampleMax                                 = (FrameTimeSample)GetInt32(new IntPtr(p + 0x048)); // 0270DBA7DF38 0x48 SampleMax                   ( 0001865D6700 ModelEnumType FrameTimeSample FrameTimeSample FrameTimeSample Int32 )

            return value;
        }
    }
}
