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
    public partial class IngamePCardContentModel
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
            var value   = new IngamePCardContentModel();

            value.OriginalAppealTypes                       = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x010)); // 0270D5B86B48 0x10 OriginalAppealTypes         ( 000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.AppealTypes                               = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x018)); // 0270D5B86B68 0x18 AppealTypes                 ( 000185D22D68 ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.DisplaySortCardEffects                    = GetObjectList<IngameActionEffectModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngameActionEffectModel.FromPointer); // 0270D5B86B88 0x20 DisplaySortCardEffects      ( 000185D10BE8 ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer )
            value.CardEffects                               = GetObjectList<IngameActionEffectModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngameActionEffectModel.FromPointer); // 0270D5B86BA8 0x28 CardEffects                 ( 000185D10BE8 ModelClassListType IReadOnlyList`1<IngameActionEffectModel> IReadOnlyList`1<IngameActionEffectModel> List<IngameActionEffectModel> Pointer )
            value.BaseCost                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D5B86BC8 0x30 BaseCost                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x034)); // 0270D5B86BE8 0x34 Phase                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x038)); // 0270D5B86C08 0x38 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConditionTypeId                           = GetInt32(new IntPtr(p + 0x03C)); // 0270D5B86C28 0x3C ConditionTypeId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x040)); // 0270D5B86C48 0x40 ConditionValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
