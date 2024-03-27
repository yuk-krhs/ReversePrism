using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonFanConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsConditionFieldNumber                   int IL2CPP_TYPE_I4
    // 018 IsCondition                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ConditionListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_conditionList_codec            FieldCodec`1<IdolFanConditionStatus> IL2CPP_TYPE_GENERICINST
    // 020 ConditionList                            000185CDFB08 ModelClassListType RepeatedField`1<IdolFanConditionStatus> RepeatedField`1<IdolFanConditionStatus> List<IdolFanConditionStatus> Pointer
    // 000 MeetConditionFieldNumber                 int IL2CPP_TYPE_I4
    // 028 MeetCondition                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SubSeasonFanConditionStatus
    {
        public bool                                     IsCondition                             { get; set; }
        public List<IdolFanConditionStatus>?            ConditionList                           { get; set; }
        public bool                                     MeetCondition                           { get; set; }

        public static SubSeasonFanConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonFanConditionStatus();

            value.IsCondition                               = GetBool(new IntPtr(p + 0x018)); // 0270D1151B60 0x18 IsCondition                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ConditionList                             = GetObjectList<IdolFanConditionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolFanConditionStatus.FromPointer); // 0270D1151BC0 0x20 ConditionList               ( 000185CDFB08 ModelClassListType RepeatedField`1<IdolFanConditionStatus> RepeatedField`1<IdolFanConditionStatus> List<IdolFanConditionStatus> Pointer )
            value.MeetCondition                             = GetBool(new IntPtr(p + 0x028)); // 0270D1151C00 0x28 MeetCondition               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
