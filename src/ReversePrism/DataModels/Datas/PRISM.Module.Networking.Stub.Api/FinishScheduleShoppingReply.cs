using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishScheduleShoppingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProduceCardList                          000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 028 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    public partial class FinishScheduleShoppingReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }

        public static FinishScheduleShoppingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishScheduleShoppingReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D2550E78 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0270D2550ED8 0x20 ProduceCardList             ( 000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x028)); // 0270D2550F18 0x28 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )

            return value;
        }
    }
}
