using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventBonusStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalBonusFieldNumber                    int IL2CPP_TYPE_I4
    // 020 TotalBonus                               00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceIdolList_codec          FieldCodec`1<EventBonusProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceIdolList                          000185CD54B8 ModelClassListType RepeatedField`1<EventBonusProduceIdolStatus> RepeatedField`1<EventBonusProduceIdolStatus> List<EventBonusProduceIdolStatus> Pointer
    public partial class EventBonusStatus : DataModel
    {
        public int                                      MstEventId                              { get; set; }
        public LimitedValueStatus?                      TotalBonus                              { get; set; }
        public List<EventBonusProduceIdolStatus>?       ProduceIdolList                         { get; set; }

        public static EventBonusStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventBonusStatus() { Pointer= p0 };

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 024661307C10 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalBonus                                = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661307C50 0x20 TotalBonus                  ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.ProduceIdolList                           = GetObjectList<EventBonusProduceIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventBonusProduceIdolStatus.FromPointer); // 024661307CB0 0x28 ProduceIdolList             ( 000185CD54B8 ModelClassListType RepeatedField`1<EventBonusProduceIdolStatus> RepeatedField`1<EventBonusProduceIdolStatus> List<EventBonusProduceIdolStatus> Pointer )

            return value;
        }
    }
}
