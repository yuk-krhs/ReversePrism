using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MetricDescriptorMetadata> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LaunchStageFieldNumber                   int IL2CPP_TYPE_I4
    // 018 LaunchStage                              00018650A860 ModelEnumType LaunchStage LaunchStage LaunchStage Int32
    // 000 SamplePeriodFieldNumber                  int IL2CPP_TYPE_I4
    // 020 SamplePeriod                             00018670DB80 ModelClassType Duration Duration Duration Pointer
    // 000 IngestDelayFieldNumber                   int IL2CPP_TYPE_I4
    // 028 IngestDelay                              00018670DB80 ModelClassType Duration Duration Duration Pointer
    public partial class MetricDescriptorMetadata
    {
        public LaunchStage                              LaunchStage                             { get; set; }
        public Duration?                                SamplePeriod                            { get; set; }
        public Duration?                                IngestDelay                             { get; set; }

        public static MetricDescriptorMetadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricDescriptorMetadata();

            value.LaunchStage                               = (LaunchStage)GetInt32(new IntPtr(p + 0x018)); // 0270DA7FBAF8 0x18 LaunchStage                 ( 00018650A860 ModelEnumType LaunchStage LaunchStage LaunchStage Int32 )
            value.SamplePeriod                              = GetObject<Duration>(new IntPtr(p + 0x020), ReversePrism.DataModels.Duration.FromPointer); // 0270DA7FBB38 0x20 SamplePeriod                ( 00018670DB80 ModelClassType Duration Duration Duration Pointer )
            value.IngestDelay                               = GetObject<Duration>(new IntPtr(p + 0x028), ReversePrism.DataModels.Duration.FromPointer); // 0270DA7FBB78 0x28 IngestDelay                 ( 00018670DB80 ModelClassType Duration Duration Duration Pointer )

            return value;
        }
    }
}
