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
    // 018 Bonus                                    ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 020 ProduceIdol                              ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 BaseBonusFieldNumber                     int IL2CPP_TYPE_I4
    // 028 BaseBonus                                ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 StarBonusFieldNumber                     int IL2CPP_TYPE_I4
    // 030 StarBonus                                ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 EvolutionBonusFieldNumber                int IL2CPP_TYPE_I4
    // 038 EvolutionBonus                           ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
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

            value.Bonus                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x18 Bonus                       ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0x20 ProduceIdol                 ( ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.BaseBonus                                 = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x28 BaseBonus                   ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.StarBonus                                 = GetObject<LimitedValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x30 StarBonus                   ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.EvolutionBonus                            = GetObject<LimitedValueStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x38 EvolutionBonus              ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )

            return value;
        }
    }
}
