using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 020 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    public partial class FinishScheduleRestReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }

        public static FinishScheduleRestReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishScheduleRestReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )

            return value;
        }
    }
}
