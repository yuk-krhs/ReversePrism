using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NextOrder                                0001865EE670 ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer
    // 018 ProduceBaseInfo                          0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 ScheduleDetailType                       000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 024 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 GettableProduceCardAmount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C DeletableProduceCardAmount               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 UnitParamVariation                       0001865D2190 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 038 FanVariation                             000186775250 ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer
    // 040 VitalityVariation                        000186698420 ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer
    // 048 IsTrouble                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 MstCharacterInfoIdList                   000185D11ED8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 058 ExertSupportEffectList                   000185CF6708 ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    // 060 GettableProduceCardList                  000185D06078 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    public partial class StartMiniLiveModel : DataModel
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

        public static StartMiniLiveModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartMiniLiveModel() { Pointer= p0 };

            value.NextOrder                                 = GetObject<IProduceNextOrderStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceNextOrderStatus.FromPointer); // 024666637D38 0x10 NextOrder                   ( 0001865EE670 ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 024666637D58 0x18 ProduceBaseInfo             ( 0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 024666637D78 0x20 ScheduleDetailType          ( 000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x024)); // 024666637D98 0x24 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x028)); // 024666637DB8 0x28 GettableProduceCardAmount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DeletableProduceCardAmount                = GetInt32(new IntPtr(p + 0x02C)); // 024666637DD8 0x2C DeletableProduceCardAmount  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitParamVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 024666637DF8 0x30 UnitParamVariation          ( 0001865D2190 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.FanVariation                              = GetObject<IFanVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFanVariationStatus.FromPointer); // 024666637E18 0x38 FanVariation                ( 000186775250 ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer )
            value.VitalityVariation                         = GetObject<IVitalityVariationStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IVitalityVariationStatus.FromPointer); // 024666637E38 0x40 VitalityVariation           ( 000186698420 ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x048)); // 024666637E58 0x48 IsTrouble                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x050)); // 024666637E78 0x50 MstCharacterInfoIdList      ( 000185D11ED8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 024666637E98 0x58 ExertSupportEffectList      ( 000185CF6708 ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )
            value.GettableProduceCardList                   = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 024666637EB8 0x60 GettableProduceCardList     ( 000185D06078 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
