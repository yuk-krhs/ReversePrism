using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishAuditionResultReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 020 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    public partial class FinishAuditionResultReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }

        public static FinishAuditionResultReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishAuditionResultReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D2539910 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 0270D2539950 0x20 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )

            return value;
        }
    }
}
