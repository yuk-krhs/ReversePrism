using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventBreakTimeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CurrentPeriodFieldNumber                 int IL2CPP_TYPE_I4
    // 018 CurrentPeriod                            ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 IsBreakTimeFieldNumber                   int IL2CPP_TYPE_I4
    // 020 IsBreakTime                              ModelPrimitiveType bool bool bool Bool
    // 000 IsChangeableFieldNumber                  int IL2CPP_TYPE_I4
    // 021 IsChangeable                             ModelPrimitiveType bool bool bool Bool
    // 000 OptionListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_optionList_codec               FieldCodec`1<EventBreakTimeOptionStatus> IL2CPP_TYPE_GENERICINST
    // 028 OptionList                               ModelClassListType RepeatedField`1<EventBreakTimeOptionStatus> RepeatedField`1<EventBreakTimeOptionStatus> List<EventBreakTimeOptionStatus> Pointer
    public partial class EventBreakTimeStatus : DataModel
    {
        public PeriodStatus?                            CurrentPeriod                           { get; set; }
        public bool                                     IsBreakTime                             { get; set; }
        public bool                                     IsChangeable                            { get; set; }
        public List<EventBreakTimeOptionStatus>?        OptionList                              { get; set; }

        public static EventBreakTimeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventBreakTimeStatus() { Pointer= p0 };

            value.CurrentPeriod                             = GetObject<PeriodStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x18 CurrentPeriod               ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.IsBreakTime                               = GetBool(new IntPtr(p + 0x020)); // 0x20 IsBreakTime                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsChangeable                              = GetBool(new IntPtr(p + 0x021)); // 0x21 IsChangeable                ( ModelPrimitiveType bool bool bool Bool )
            value.OptionList                                = GetObjectList<EventBreakTimeOptionStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventBreakTimeOptionStatus.FromPointer); // 0x28 OptionList                  ( ModelClassListType RepeatedField`1<EventBreakTimeOptionStatus> RepeatedField`1<EventBreakTimeOptionStatus> List<EventBreakTimeOptionStatus> Pointer )

            return value;
        }
    }
}
