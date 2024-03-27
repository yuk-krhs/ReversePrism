using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseEffect                               000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 018 EffectByStar                             000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 020 EffectByLevel                            000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 028 Bonus                                    000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 030 ProduceIdol                              0001865EB580 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 038 IsShowDetail                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 040 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class LiveEventBonusListCellViewModel
    {
        public ILimitedValueStatus?                     BaseEffect                              { get; set; }
        public ILimitedValueStatus?                     EffectByStar                            { get; set; }
        public ILimitedValueStatus?                     EffectByLevel                           { get; set; }
        public ILimitedValueStatus?                     Bonus                                   { get; set; }
        public IProduceIdolStatus?                      ProduceIdol                             { get; set; }
        public bool                                     IsShowDetail                            { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static LiveEventBonusListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBonusListCellViewModel();

            value.BaseEffect                                = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0270D627D930 0x10 BaseEffect                  ( 000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.EffectByStar                              = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0270D627D950 0x18 EffectByStar                ( 000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.EffectByLevel                             = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0270D627D970 0x20 EffectByLevel               ( 000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.Bonus                                     = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0270D627D990 0x28 Bonus                       ( 000186591600 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.ProduceIdol                               = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0270D627D9B0 0x30 ProduceIdol                 ( 0001865EB580 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.IsShowDetail                              = GetBool(new IntPtr(p + 0x038)); // 0270D627D9D0 0x38 IsShowDetail                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D627D9F0 0x40 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
