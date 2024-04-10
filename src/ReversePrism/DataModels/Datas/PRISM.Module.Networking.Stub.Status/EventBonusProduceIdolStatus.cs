using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventBonusProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BonusFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Bonus                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 020 ProduceIdol                              000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 BaseBonusFieldNumber                     int IL2CPP_TYPE_I4
    // 028 BaseBonus                                00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 StarBonusFieldNumber                     int IL2CPP_TYPE_I4
    // 030 StarBonus                                00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 EvolutionBonusFieldNumber                int IL2CPP_TYPE_I4
    // 038 EvolutionBonus                           00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    public partial class EventBonusProduceIdolStatus : DataModel
    {
        public LimitedValueStatus?                      Bonus                                   { get; set; }
        public ProduceIdolStatus?                       ProduceIdol                             { get; set; }
        public LimitedValueStatus?                      BaseBonus                               { get; set; }
        public LimitedValueStatus?                      StarBonus                               { get; set; }
        public LimitedValueStatus?                      EvolutionBonus                          { get; set; }

        public static EventBonusProduceIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventBonusProduceIdolStatus() { Pointer= p0 };

            value.Bonus                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661306C60 0x18 Bonus                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 024661306CA0 0x20 ProduceIdol                 ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.BaseBonus                                 = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661306CE0 0x28 BaseBonus                   ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.StarBonus                                 = GetObject<LimitedValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661306D20 0x30 StarBonus                   ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.EvolutionBonus                            = GetObject<LimitedValueStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661306D60 0x38 EvolutionBonus              ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )

            return value;
        }
    }
}
