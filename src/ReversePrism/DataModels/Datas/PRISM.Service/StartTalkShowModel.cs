using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NextOrder                                ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer
    // 018 ProduceBaseInfo                          ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 024 MstUnitId                                ModelPrimitiveType int int int Int32
    // 028 GettableProduceCardAmount                ModelPrimitiveType int int int Int32
    // 02C DeletableProduceCardAmount               ModelPrimitiveType int int int Int32
    // 030 UnitParamVariation                       ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 038 FanVariation                             ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer
    // 040 VitalityVariation                        ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer
    // 048 IsTrouble                                ModelPrimitiveType bool bool bool Bool
    // 050 MstCharacterInfoIdList                   ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 058 ExertSupportEffectList                   ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    // 060 GettableProduceCardList                  ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    public partial class StartTalkShowModel : DataModel
    {
        public IProduceNextOrderStatus?                 NextOrder                               { get; set; }
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public int                                      DeletableProduceCardAmount              { get; set; }
        public IParameterVariationStatus?               UnitParamVariation                      { get; set; }
        public IFanVariationStatus?                     FanVariation                            { get; set; }
        public IVitalityVariationStatus?                VitalityVariation                       { get; set; }
        public bool                                     IsTrouble                               { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public List<IExertSupportEffectStatus>?         ExertSupportEffectList                  { get; set; }
        public List<IProduceCardStatus>?                GettableProduceCardList                 { get; set; }

        public static StartTalkShowModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartTalkShowModel() { Pointer= p0 };

            value.NextOrder                                 = GetObject<IProduceNextOrderStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceNextOrderStatus.FromPointer); // 0x10 NextOrder                   ( ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 GettableProduceCardAmount   ( ModelPrimitiveType int int int Int32 )
            value.DeletableProduceCardAmount                = GetInt32(new IntPtr(p + 0x02C)); // 0x2C DeletableProduceCardAmount  ( ModelPrimitiveType int int int Int32 )
            value.UnitParamVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x30 UnitParamVariation          ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.FanVariation                              = GetObject<IFanVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFanVariationStatus.FromPointer); // 0x38 FanVariation                ( ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer )
            value.VitalityVariation                         = GetObject<IVitalityVariationStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IVitalityVariationStatus.FromPointer); // 0x40 VitalityVariation           ( ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x048)); // 0x48 IsTrouble                   ( ModelPrimitiveType bool bool bool Bool )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x050)); // 0x50 MstCharacterInfoIdList      ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 0x58 ExertSupportEffectList      ( ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )
            value.GettableProduceCardList                   = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x60 GettableProduceCardList     ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
