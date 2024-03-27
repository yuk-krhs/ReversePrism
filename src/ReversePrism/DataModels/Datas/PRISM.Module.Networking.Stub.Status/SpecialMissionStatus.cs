using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReceiveEndDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SpecialMissionStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSpecialMissionIdFieldNumber           int IL2CPP_TYPE_I4
    // 028 MstSpecialMissionId                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PeriodFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Period                                   000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 ReceiveEndDateFieldNumber                int IL2CPP_TYPE_I4
    // 038 _ReceiveEndDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 StepListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_stepList_codec                 FieldCodec`1<SpecialMissionStepStatus> IL2CPP_TYPE_GENERICINST
    // 040 StepList                                 000185CF23F8 ModelClassListType RepeatedField`1<SpecialMissionStepStatus> RepeatedField`1<SpecialMissionStepStatus> List<SpecialMissionStepStatus> Pointer
    public partial class SpecialMissionStatus
    {
        public DateTime                                 ReceiveEndDate                          { get; set; }
        public int                                      MstSpecialMissionId                     { get; set; }
        public PeriodStatus?                            Period                                  { get; set; }
        public Timestamp?                               _ReceiveEndDate                         { get; set; }
        public List<SpecialMissionStepStatus>?          StepList                                { get; set; }

        public static SpecialMissionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionStatus();

            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0270D28C5B78 0x10 ReceiveEndDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSpecialMissionId                       = GetInt32(new IntPtr(p + 0x028)); // 0270D28C5BF8 0x28 MstSpecialMissionId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Period                                    = GetObject<PeriodStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0270D28C5C38 0x30 Period                      ( 000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value._ReceiveEndDate                           = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D28C5C78 0x38 _ReceiveEndDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.StepList                                  = GetObjectList<SpecialMissionStepStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.SpecialMissionStepStatus.FromPointer); // 0270D28C5CD8 0x40 StepList                    ( 000185CF23F8 ModelClassListType RepeatedField`1<SpecialMissionStepStatus> RepeatedField`1<SpecialMissionStepStatus> List<SpecialMissionStepStatus> Pointer )
            value.ReceiveEndDate                = ToDateTime(value._ReceiveEndDate);

            return value;
        }
    }
}
