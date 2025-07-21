using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonDearnessConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsConditionFieldNumber                   int IL2CPP_TYPE_I4
    // 018 IsCondition                              ModelPrimitiveType bool bool bool Bool
    // 000 ConditionListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_conditionList_codec            FieldCodec`1<IdolDearnessConditionStatus> IL2CPP_TYPE_GENERICINST
    // 020 ConditionList                            ModelClassListType RepeatedField`1<IdolDearnessConditionStatus> RepeatedField`1<IdolDearnessConditionStatus> List<IdolDearnessConditionStatus> Pointer
    // 000 MeetConditionFieldNumber                 int IL2CPP_TYPE_I4
    // 028 MeetCondition                            ModelPrimitiveType bool bool bool Bool
    public partial class SubSeasonDearnessConditionStatus : DataModel
    {
        public bool                                     IsCondition                             { get; set; }
        public List<IdolDearnessConditionStatus>?       ConditionList                           { get; set; }
        public bool                                     MeetCondition                           { get; set; }

        public static SubSeasonDearnessConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDearnessConditionStatus() { Pointer= p0 };

            value.IsCondition                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsCondition                 ( ModelPrimitiveType bool bool bool Bool )
            value.ConditionList                             = GetObjectList<IdolDearnessConditionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolDearnessConditionStatus.FromPointer); // 0x20 ConditionList               ( ModelClassListType RepeatedField`1<IdolDearnessConditionStatus> RepeatedField`1<IdolDearnessConditionStatus> List<IdolDearnessConditionStatus> Pointer )
            value.MeetCondition                             = GetBool(new IntPtr(p + 0x028)); // 0x28 MeetCondition               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
