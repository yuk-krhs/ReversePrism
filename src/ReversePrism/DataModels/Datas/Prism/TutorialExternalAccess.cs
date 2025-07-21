using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <GetCardPos>k__BackingField              Func`2<int, RectTransform> IL2CPP_TYPE_GENERICINST
    // 018 <GetAvoidRateIconPos>k__BackingField     Func`1<RectTransform> IL2CPP_TYPE_GENERICINST
    // 020 <GetStatusIconPos>k__BackingField        Func`2<int, RectTransform> IL2CPP_TYPE_GENERICINST
    // 028 <GetStatusContentRectTransform>k__BackingField Func`1<RectTransform> IL2CPP_TYPE_GENERICINST
    // 030 <GetAppealContentRectTransform>k__BackingField Func`1<RectTransform> IL2CPP_TYPE_GENERICINST
    // 038 <GetExclusionCardCounttRectTransform>k__BackingField Func`1<RectTransform> IL2CPP_TYPE_GENERICINST
    // 040 <GetCardAndCharaSkillDetailPanelRectTransform>k__BackingField Func`1<RectTransform> IL2CPP_TYPE_GENERICINST
    // 048 <GetBaffDebaffDetailRectTransform>k__BackingField Func`1<RectTransform> IL2CPP_TYPE_GENERICINST
    // 050 <GetIdolSkillPos>k__BackingField         Func`2<int, RectTransform> IL2CPP_TYPE_GENERICINST
    // 058 <OnShowFade>k__BackingField              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 <OnHideFade>k__BackingField              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 <OnSetFadeAlpha>k__BackingField          Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 070 <OnShowInfoHand>k__BackingField          Action`4<Vector3, Vector2, Vector2, float> IL2CPP_TYPE_GENERICINST
    // 078 <OnHideInfoHand>k__BackingField          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 <OnShowMask>k__BackingField              Action`5<Vector2, Vector2, Vector2, Vector2, int> IL2CPP_TYPE_GENERICINST
    // 088 <OnShowMaskWorldPos>k__BackingField      Action`4<Vector3, Vector2, Vector2, int> IL2CPP_TYPE_GENERICINST
    // 090 <OnShowInfoText>k__BackingField          Subject`1<ValueTuple`2<string, float>> IL2CPP_TYPE_GENERICINST
    // 098 <OnHideInfoText>k__BackingField          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 <OnSetInfoTextAlpha>k__BackingField      Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 0A8 <OnHideMask>k__BackingField              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0B0 <OnShowArrow>k__BackingField             Action`2<Vector3, Vector2> IL2CPP_TYPE_GENERICINST
    // 0B8 <OnShowAvoidArrow>k__BackingField        Action`2<Vector3, Vector2> IL2CPP_TYPE_GENERICINST
    // 0C0 <OnHideArrow>k__BackingField             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0C8 <OnHideAvoidArrow>k__BackingField        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D0 <OnTryShowInputBlock>k__BackingField     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D8 <OnTryHideInputBlock>k__BackingField     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E0 <OnTryShowInputDragBlock>k__BackingField Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E8 <OnTryHideInputDragBlock>k__BackingField Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0F0 <OnShowInputDragBlock>k__BackingField    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0F8 <OnHideInputDragBlock>k__BackingField    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 100 <OnTryShowTextInfo>k__BackingField       Subject`1<ValueTuple`2<string, float>> IL2CPP_TYPE_GENERICINST
    // 108 <OnTryHideTextInfo>k__BackingField       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 110 <OnShowInputBlock>k__BackingField        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 118 <OnHideInputBlock>k__BackingField        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 120 <OnTryShowFade>k__BackingField           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 128 <OnTryHideFade>k__BackingField           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 130 <OnShowAllTap>k__BackingField            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 138 <OnSetAllTap>k__BackingField             Subject`1<Action> IL2CPP_TYPE_GENERICINST
    // 140 <OnHideAllTap>k__BackingField            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 148 OnHideSkipBtn                            ModelClassType Action Action Action Pointer
    // 150 OnHideCommonWindow                       ModelClassType Action Action Action Pointer
    // 158 <OnDisableFixDrowSbuject>k__BackingField Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 160 <OnCanselCardSelect>k__BackingField      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 168 <OnSetGameStop>k__BackingField           Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 170 <OnSetPP>k__BackingField                 Action`1<int> IL2CPP_TYPE_GENERICINST
    // 178 <OnSetMentalRate>k__BackingField         Action`1<float> IL2CPP_TYPE_GENERICINST
    // 180 OnResetGame                              ModelClassType Action Action Action Pointer
    // 188 OnBrekeMental                            ModelClassType Action Action Action Pointer
    // 190 OnDebffSkill                             ModelClassType Action Action Action Pointer
    // 198 <OnSetDrowTargetCard>k__BackingField     Action`1<int> IL2CPP_TYPE_GENERICINST
    // 1A0 <OnSetDrowStartTargetCardList>k__BackingField Action`1<int[]> IL2CPP_TYPE_GENERICINST
    // 1A8 <OnDisableNPC>k__BackingField            Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 1B0 <OnNotMaxAppeal>k__BackingField          Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 1B8 <OnAddUseCardAction>k__BackingField      Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 1C0 <OnRemoveUseCardAction>k__BackingField   Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 1C8 <OnAddUseEnemyCardAction>k__BackingField Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 1D0 <OnRemoveUseEnemyCardAction>k__BackingField Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 1D8 <OnAddUseUnitSkillAction>k__BackingField Action`1<Action`1<int>> IL2CPP_TYPE_GENERICINST
    // 1E0 <OnRemoveUseUnitSkillAction>k__BackingField Action`1<Action`1<int>> IL2CPP_TYPE_GENERICINST
    // 1E8 <OnAddChangePPAction>k__BackingField     Action`1<Action`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 1F0 <OnRemoveChangePPAction>k__BackingField  Action`1<Action`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 1F8 <OnAddStartMentalBreak>k__BackingField   Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 200 <OnRemoveStartMentalBreak>k__BackingField Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 208 <OnAddRecoverMentalBreak>k__BackingField Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 210 <OnRemoveRecoverMentalBreak>k__BackingField Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 218 <OnAddGetCurrentTimeLimit>k__BackingField Action`1<Action`1<float>> IL2CPP_TYPE_GENERICINST
    // 220 <OnRemoveGetCurrentTimeLimit>k__BackingField Action`1<Action`1<float>> IL2CPP_TYPE_GENERICINST
    // 228 <OnEndIngame>k__BackingField             Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 230 <OnStartIngame>k__BackingField           Action`1<Action> IL2CPP_TYPE_GENERICINST
    // 238 <OnAddTapCanselSbuject>k__BackingField   Subject`1<Action> IL2CPP_TYPE_GENERICINST
    // 240 <OnRemoveTapCanselSbuject>k__BackingField Subject`1<Action> IL2CPP_TYPE_GENERICINST
    // 248 <OnAddTapCardSbuject>k__BackingField     Subject`1<Action> IL2CPP_TYPE_GENERICINST
    // 250 <OnRemoveTapCardSbuject>k__BackingField  Subject`1<Action> IL2CPP_TYPE_GENERICINST
    // 258 <OnAddTapBuffIconSbuject>k__BackingField Subject`1<Action> IL2CPP_TYPE_GENERICINST
    // 260 <OnRemoveTapBuffIconSbuject>k__BackingField Subject`1<Action> IL2CPP_TYPE_GENERICINST
    public partial class TutorialExternalAccess : DataModel
    {
        public Action?                                  OnHideSkipBtn                           { get; set; }
        public Action?                                  OnHideCommonWindow                      { get; set; }
        public Action?                                  OnResetGame                             { get; set; }
        public Action?                                  OnBrekeMental                           { get; set; }
        public Action?                                  OnDebffSkill                            { get; set; }

        public static TutorialExternalAccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialExternalAccess() { Pointer= p0 };

            value.OnHideSkipBtn                             = GetObject<Action>(new IntPtr(p + 0x148), ReversePrism.DataModels.Action.FromPointer); // 0x148 OnHideSkipBtn               ( ModelClassType Action Action Action Pointer )
            value.OnHideCommonWindow                        = GetObject<Action>(new IntPtr(p + 0x150), ReversePrism.DataModels.Action.FromPointer); // 0x150 OnHideCommonWindow          ( ModelClassType Action Action Action Pointer )
            value.OnResetGame                               = GetObject<Action>(new IntPtr(p + 0x180), ReversePrism.DataModels.Action.FromPointer); // 0x180 OnResetGame                 ( ModelClassType Action Action Action Pointer )
            value.OnBrekeMental                             = GetObject<Action>(new IntPtr(p + 0x188), ReversePrism.DataModels.Action.FromPointer); // 0x188 OnBrekeMental               ( ModelClassType Action Action Action Pointer )
            value.OnDebffSkill                              = GetObject<Action>(new IntPtr(p + 0x190), ReversePrism.DataModels.Action.FromPointer); // 0x190 OnDebffSkill                ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
