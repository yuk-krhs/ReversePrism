using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReceiveEndDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SpecialMissionStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSpecialMissionIdFieldNumber           int IL2CPP_TYPE_I4
    // 028 MstSpecialMissionId                      ModelPrimitiveType int int int Int32
    // 000 PeriodFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Period                                   ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 ReceiveEndDateFieldNumber                int IL2CPP_TYPE_I4
    // 038 _ReceiveEndDate                          ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 StepListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_stepList_codec                 FieldCodec`1<SpecialMissionStepStatus> IL2CPP_TYPE_GENERICINST
    // 040 StepList                                 ModelClassListType RepeatedField`1<SpecialMissionStepStatus> RepeatedField`1<SpecialMissionStepStatus> List<SpecialMissionStepStatus> Pointer
    public partial class SpecialMissionStatus : DataModel
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
            var value   = new SpecialMissionStatus() { Pointer= p0 };

            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0x10 ReceiveEndDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSpecialMissionId                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstSpecialMissionId         ( ModelPrimitiveType int int int Int32 )
            value.Period                                    = GetObject<PeriodStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x30 Period                      ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value._ReceiveEndDate                           = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _ReceiveEndDate             ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.StepList                                  = GetObjectList<SpecialMissionStepStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.SpecialMissionStepStatus.FromPointer); // 0x40 StepList                    ( ModelClassListType RepeatedField`1<SpecialMissionStepStatus> RepeatedField`1<SpecialMissionStepStatus> List<SpecialMissionStepStatus> Pointer )
            value.ReceiveEndDate                = ToDateTime(value._ReceiveEndDate);

            return value;
        }
    }
}
