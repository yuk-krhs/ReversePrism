using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AnchorRect                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 IdolSkillIconView                        0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 BgImage                                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 000 VitalityLimit                            float IL2CPP_TYPE_R4
    // 000 VoiceMaxOnNormal                         int IL2CPP_TYPE_I4
    // 000 VoiceMaxOnDamage                         int IL2CPP_TYPE_I4
    // 038 CacheInProduceIdol                       00018657D3B0 ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer
    // 040 CacheProduceIdol                         0001865EB0E0 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 048 CacheProduceUnit                         0001865F75F0 ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer
    // 050 IsDamagedVoisePlayed                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 IsDamaged                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 VoiceSheetList                           000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 060 VoiceCueList                             000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 068 BeforeIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C RandomIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 onRingIdolVoiceActivate                  Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 onLongClickIdol                          Subject`1<ValueTuple`2<ProduceIdol, IInProduceIdolStatus>> IL2CPP_TYPE_GENERICINST
    public partial class UnitIdolContent
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
            var value   = new UnitIdolContent();

            value.AnchorRect                                = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA192140 0x20 AnchorRect                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA192160 0x28 IdolSkillIconView           ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA192180 0x30 BgImage                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.CacheInProduceIdol                        = GetObject<IInProduceIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0270DA192200 0x38 CacheInProduceIdol          ( 00018657D3B0 ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer )
            value.CacheProduceIdol                          = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0270DA192220 0x40 CacheProduceIdol            ( 0001865EB0E0 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.CacheProduceUnit                          = GetObject<IProduceUnitStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceUnitStatus.FromPointer); // 0270DA192240 0x48 CacheProduceUnit            ( 0001865F75F0 ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer )
            value.IsDamagedVoisePlayed                      = GetBool(new IntPtr(p + 0x050)); // 0270DA192260 0x50 IsDamagedVoisePlayed        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDamaged                                 = GetBool(new IntPtr(p + 0x051)); // 0270DA192280 0x51 IsDamaged                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.VoiceSheetList                            = GetStringList(new IntPtr(p + 0x058)); // 0270DA1922A0 0x58 VoiceSheetList              ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.VoiceCueList                              = GetStringList(new IntPtr(p + 0x060)); // 0270DA1922C0 0x60 VoiceCueList                ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.BeforeIndex                               = GetInt32(new IntPtr(p + 0x068)); // 0270DA1922E0 0x68 BeforeIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RandomIndex                               = GetInt32(new IntPtr(p + 0x06C)); // 0270DA192300 0x6C RandomIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
