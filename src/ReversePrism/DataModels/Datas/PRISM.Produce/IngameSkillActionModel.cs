using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TempCallBackDisposable                   ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 RandomModel                              ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 020 AvoidResult                              ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer
    // 028 IngamePlayerActionData                   ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer
    // 030 IngameOpponentActionData                 ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer
    // 038 EmptyApealTypes                          ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 040 VoDaApealTypes                           ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 048 VoViApealTypes                           ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 050 DaViApealTypes                           ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 058 VoDaViApealTypes                         ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 060 VoAppealTypes                            ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 068 DaAppealTypes                            ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 070 ViAppealTypes                            ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 078 <CurrentTimeSecondFunc>k__BackingField   Func`1<float> IL2CPP_TYPE_GENERICINST
    // 080 <ElapsedTimeSecondFunc>k__BackingField   Func`1<float> IL2CPP_TYPE_GENERICINST
    // 088 <CardAndSkillExecResultPoolFunc>k__BackingField Func`1<InGameActionResultPool`1<CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    // 090 GetEffectsList                           ModelClassListType List`1<ProduceInGameEffect> List`1<ProduceInGameEffect> List<ProduceInGameEffect> Pointer
    public partial class IngameSkillActionModel : DataModel
    {
        public CompositeDisposable?                     TempCallBackDisposable                  { get; set; }
        public IngameRandomModel?                       RandomModel                             { get; set; }
        public InGameExecActionResult?                  AvoidResult                             { get; set; }
        public IngamePlayerActionData?                  IngamePlayerActionData                  { get; set; }
        public IngamePlayerActionData?                  IngameOpponentActionData                { get; set; }
        public List<ProduceParameterType>?              EmptyApealTypes                         { get; set; }
        public List<ProduceParameterType>?              VoDaApealTypes                          { get; set; }
        public List<ProduceParameterType>?              VoViApealTypes                          { get; set; }
        public List<ProduceParameterType>?              DaViApealTypes                          { get; set; }
        public List<ProduceParameterType>?              VoDaViApealTypes                        { get; set; }
        public List<ProduceParameterType>?              VoAppealTypes                           { get; set; }
        public List<ProduceParameterType>?              DaAppealTypes                           { get; set; }
        public List<ProduceParameterType>?              ViAppealTypes                           { get; set; }
        public List<ProduceInGameEffect>?               GetEffectsList                          { get; set; }

        public static IngameSkillActionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameSkillActionModel() { Pointer= p0 };

            value.TempCallBackDisposable                    = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x10 TempCallBackDisposable      ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 0x18 RandomModel                 ( ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.AvoidResult                               = GetObject<InGameExecActionResult>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameExecActionResult.FromPointer); // 0x20 AvoidResult                 ( ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer )
            value.IngamePlayerActionData                    = GetObject<IngamePlayerActionData>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngamePlayerActionData.FromPointer); // 0x28 IngamePlayerActionData      ( ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer )
            value.IngameOpponentActionData                  = GetObject<IngamePlayerActionData>(new IntPtr(p + 0x030), ReversePrism.DataModels.IngamePlayerActionData.FromPointer); // 0x30 IngameOpponentActionData    ( ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer )
            value.EmptyApealTypes                           = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x038)); // 0x38 EmptyApealTypes             ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoDaApealTypes                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x040)); // 0x40 VoDaApealTypes              ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoViApealTypes                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x048)); // 0x48 VoViApealTypes              ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.DaViApealTypes                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x050)); // 0x50 DaViApealTypes              ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoDaViApealTypes                          = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x058)); // 0x58 VoDaViApealTypes            ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoAppealTypes                             = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x060)); // 0x60 VoAppealTypes               ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.DaAppealTypes                             = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x068)); // 0x68 DaAppealTypes               ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.ViAppealTypes                             = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x070)); // 0x70 ViAppealTypes               ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.GetEffectsList                            = GetObjectList<ProduceInGameEffect>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceInGameEffect.FromPointer); // 0x90 GetEffectsList              ( ModelClassListType List`1<ProduceInGameEffect> List`1<ProduceInGameEffect> List<ProduceInGameEffect> Pointer )

            return value;
        }
    }
}
