using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartAuditionReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 RivalUnitFieldNumber                     int IL2CPP_TYPE_I4
    // 020 RivalUnit                                000186691660 ModelClassType RivalUnitStatus RivalUnitStatus RivalUnitStatus Pointer
    // 000 OpponentFieldNumber                      int IL2CPP_TYPE_I4
    // 028 Opponent                                 0001866E5AB0 ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 030 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    public partial class StartAuditionReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public RivalUnitStatus?                         RivalUnit                               { get; set; }
        public OpponentStatus?                          Opponent                                { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }

        public static StartAuditionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartAuditionReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D25AA7D8 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.RivalUnit                                 = GetObject<RivalUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RivalUnitStatus.FromPointer); // 0270D25AA818 0x20 RivalUnit                   ( 000186691660 ModelClassType RivalUnitStatus RivalUnitStatus RivalUnitStatus Pointer )
            value.Opponent                                  = GetObject<OpponentStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.OpponentStatus.FromPointer); // 0270D25AA858 0x28 Opponent                    ( 0001866E5AB0 ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 0270D25AA898 0x30 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )

            return value;
        }
    }
}
