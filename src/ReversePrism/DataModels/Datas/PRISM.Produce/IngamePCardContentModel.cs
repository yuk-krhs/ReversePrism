using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalAppealTypes                      ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 018 AppealTypes                              ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 020 DisplaySortCardEffects                   ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer
    // 028 CardEffects                              ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer
    // 030 BaseCost                                 ModelPrimitiveType int int int Int32
    // 034 Phase                                    ModelPrimitiveType int int int Int32
    // 038 Rank                                     ModelPrimitiveType int int int Int32
    // 03C ConditionTypeId                          ModelPrimitiveType int int int Int32
    // 040 ConditionValue                           ModelPrimitiveType int int int Int32
    public partial class IngamePCardContentModel : DataModel
    {
        public List<ProduceParameterType>?              OriginalAppealTypes                     { get; set; }
        public List<ProduceParameterType>?              AppealTypes                             { get; set; }
        public List<IngameActionEffectModel>?           DisplaySortCardEffects                  { get; set; }
        public List<IngameActionEffectModel>?           CardEffects                             { get; set; }
        public int                                      BaseCost                                { get; set; }
        public int                                      Phase                                   { get; set; }
        public int                                      Rank                                    { get; set; }
        public int                                      ConditionTypeId                         { get; set; }
        public int                                      ConditionValue                          { get; set; }

        public static IngamePCardContentModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngamePCardContentModel() { Pointer= p0 };

            value.OriginalAppealTypes                       = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x010)); // 0x10 OriginalAppealTypes         ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.AppealTypes                               = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x018)); // 0x18 AppealTypes                 ( ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.DisplaySortCardEffects                    = GetObjectList<IngameActionEffectModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngameActionEffectModel.FromPointer); // 0x20 DisplaySortCardEffects      ( ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer )
            value.CardEffects                               = GetObjectList<IngameActionEffectModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngameActionEffectModel.FromPointer); // 0x28 CardEffects                 ( ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer )
            value.BaseCost                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 BaseCost                    ( ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x034)); // 0x34 Phase                       ( ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.ConditionTypeId                           = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ConditionTypeId             ( ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x040)); // 0x40 ConditionValue              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
