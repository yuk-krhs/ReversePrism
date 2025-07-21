using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AnchorRect                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 IdolSkillIconView                        ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 BgImage                                  ModelClassType UIImage UIImage UIImage Pointer
    // 000 VitalityLimit                            float IL2CPP_TYPE_R4
    // 000 VoiceMaxOnNormal                         int IL2CPP_TYPE_I4
    // 000 VoiceMaxOnDamage                         int IL2CPP_TYPE_I4
    // 038 CacheInProduceIdol                       ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer
    // 040 CacheProduceIdol                         ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 048 CacheProduceUnit                         ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer
    // 050 IsDamagedVoisePlayed                     ModelPrimitiveType bool bool bool Bool
    // 051 IsDamaged                                ModelPrimitiveType bool bool bool Bool
    // 058 VoiceSheetList                           ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 060 VoiceCueList                             ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 068 BeforeIndex                              ModelPrimitiveType int int int Int32
    // 06C RandomIndex                              ModelPrimitiveType int int int Int32
    // 070 onRingIdolVoiceActivate                  Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 onLongClickIdol                          Subject`1<ValueTuple`2<ProduceIdol, IInProduceIdolStatus>> IL2CPP_TYPE_GENERICINST
    public partial class UnitIdolContent : DataModel
    {
        public RectTransform?                           AnchorRect                              { get; set; }
        public IdolSkillIconView?                       IdolSkillIconView                       { get; set; }
        public UIImage?                                 BgImage                                 { get; set; }
        public IInProduceIdolStatus?                    CacheInProduceIdol                      { get; set; }
        public IProduceIdolStatus?                      CacheProduceIdol                        { get; set; }
        public IProduceUnitStatus?                      CacheProduceUnit                        { get; set; }
        public bool                                     IsDamagedVoisePlayed                    { get; set; }
        public bool                                     IsDamaged                               { get; set; }
        public List<string>?                            VoiceSheetList                          { get; set; }
        public List<string>?                            VoiceCueList                            { get; set; }
        public int                                      BeforeIndex                             { get; set; }
        public int                                      RandomIndex                             { get; set; }

        public static UnitIdolContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitIdolContent() { Pointer= p0 };

            value.AnchorRect                                = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 AnchorRect                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x28 IdolSkillIconView           ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 BgImage                     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.CacheInProduceIdol                        = GetObject<IInProduceIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0x38 CacheInProduceIdol          ( ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer )
            value.CacheProduceIdol                          = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0x40 CacheProduceIdol            ( ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.CacheProduceUnit                          = GetObject<IProduceUnitStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceUnitStatus.FromPointer); // 0x48 CacheProduceUnit            ( ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer )
            value.IsDamagedVoisePlayed                      = GetBool(new IntPtr(p + 0x050)); // 0x50 IsDamagedVoisePlayed        ( ModelPrimitiveType bool bool bool Bool )
            value.IsDamaged                                 = GetBool(new IntPtr(p + 0x051)); // 0x51 IsDamaged                   ( ModelPrimitiveType bool bool bool Bool )
            value.VoiceSheetList                            = GetStringList(new IntPtr(p + 0x058)); // 0x58 VoiceSheetList              ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.VoiceCueList                              = GetStringList(new IntPtr(p + 0x060)); // 0x60 VoiceCueList                ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.BeforeIndex                               = GetInt32(new IntPtr(p + 0x068)); // 0x68 BeforeIndex                 ( ModelPrimitiveType int int int Int32 )
            value.RandomIndex                               = GetInt32(new IntPtr(p + 0x06C)); // 0x6C RandomIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
