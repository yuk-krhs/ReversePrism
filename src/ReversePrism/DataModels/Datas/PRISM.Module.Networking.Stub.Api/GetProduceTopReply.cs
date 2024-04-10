using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProduceTopReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 WeekScheduleListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_weekScheduleList_codec         FieldCodec`1<WeekScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 018 WeekScheduleList                         000185CF7E18 ModelClassListType RepeatedField`1<WeekScheduleStatus> RepeatedField`1<WeekScheduleStatus> List<WeekScheduleStatus> Pointer
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    public partial class GetProduceTopReply : DataModel
    {
        public List<WeekScheduleStatus>?                WeekScheduleList                        { get; set; }
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }

        public static GetProduceTopReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceTopReply() { Pointer= p0 };

            value.WeekScheduleList                          = GetObjectList<WeekScheduleStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.WeekScheduleStatus.FromPointer); // 02466254A158 0x18 WeekScheduleList            ( 000185CF7E18 ModelClassListType RepeatedField`1<WeekScheduleStatus> RepeatedField`1<WeekScheduleStatus> List<WeekScheduleStatus> Pointer )
            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 02466254A198 0x20 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )

            return value;
        }
    }
}
