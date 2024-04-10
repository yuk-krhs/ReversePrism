using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalAppealTypes                      000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 018 AppealTypes                              000185D22D68 ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 020 DisplaySortCardEffects                   000185D10BE8 ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer
    // 028 CardEffects                              000185D10BE8 ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer
    // 030 BaseCost                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Phase                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C ConditionTypeId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 ConditionValue                           0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.OriginalAppealTypes                       = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x010)); // 024665BE7238 0x10 OriginalAppealTypes         ( 000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.AppealTypes                               = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x018)); // 024665BE7258 0x18 AppealTypes                 ( 000185D22D68 ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.DisplaySortCardEffects                    = GetObjectList<IngameActionEffectModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngameActionEffectModel.FromPointer); // 024665BE7278 0x20 DisplaySortCardEffects      ( 000185D10BE8 ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer )
            value.CardEffects                               = GetObjectList<IngameActionEffectModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngameActionEffectModel.FromPointer); // 024665BE7298 0x28 CardEffects                 ( 000185D10BE8 ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer )
            value.BaseCost                                  = GetInt32(new IntPtr(p + 0x030)); // 024665BE72B8 0x30 BaseCost                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x034)); // 024665BE72D8 0x34 Phase                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x038)); // 024665BE72F8 0x38 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConditionTypeId                           = GetInt32(new IntPtr(p + 0x03C)); // 024665BE7318 0x3C ConditionTypeId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x040)); // 024665BE7338 0x40 ConditionValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
