using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseEffect                               ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 018 EffectByStar                             ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 020 EffectByLevel                            ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 028 Bonus                                    ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 030 ProduceIdol                              ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    public partial class LiveEventBonusListCellViewModel : DataModel
    {
        public ILimitedValueStatus?                     BaseEffect                              { get; set; }
        public ILimitedValueStatus?                     EffectByStar                            { get; set; }
        public ILimitedValueStatus?                     EffectByLevel                           { get; set; }
        public ILimitedValueStatus?                     Bonus                                   { get; set; }
        public IProduceIdolStatus?                      ProduceIdol                             { get; set; }

        public static LiveEventBonusListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBonusListCellViewModel() { Pointer= p0 };

            value.BaseEffect                                = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x10 BaseEffect                  ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.EffectByStar                              = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x18 EffectByStar                ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.EffectByLevel                             = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x20 EffectByLevel               ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.Bonus                                     = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x28 Bonus                       ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.ProduceIdol                               = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0x30 ProduceIdol                 ( ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )

            return value;
        }
    }
}
