using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HiddenButtonId                           int IL2CPP_TYPE_I4
    // 000 ResourceLoaderTag                        string IL2CPP_TYPE_STRING
    // 000 OpenTriggerName                          string IL2CPP_TYPE_STRING
    // 000 CloseTriggerName                         string IL2CPP_TYPE_STRING
    // 000 OpeningStateName                         string IL2CPP_TYPE_STRING
    // 000 ClosingStateName                         string IL2CPP_TYPE_STRING
    // 020 MenuButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 HiddenButtonParentList                   000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 030 DisappearCanvasGroup                     000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 WaitMilisecondsForMenuFadeOut            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C DurationSecondsForFadeOut                0001866656B0 ModelPrimitiveType float float float Single
    // 040 AdvSkipConfirmationPopupCaller           0001866EFEA0 ModelClassType IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller Pointer
    // 048 AdvLogCaller                             000186664150 ModelClassType ADVLogCaller ADVLogCaller ADVLogCaller Pointer
    // 050 LogButtonPrefab                          000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 SkipButtonPrefab                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 FavoriteButtonPrefab                     000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 DisplayButtonPrefab                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 Opening                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 IsADVUIActive                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 AutoPlayController                       0001866621D0 ModelClassType ADVAutoPlayController ADVAutoPlayController ADVAutoPlayController Pointer
    // 080 OpeningAnimator                          0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 088 ScenarioID                               0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 090 AdvScenarioInfo                          0001866EF2B0 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 098 FavoriteInfo                             000186695320 ModelClassType AdvFavoriteInfo AdvFavoriteInfo AdvFavoriteInfo Pointer
    // 0A0 FavoriteButton                           0001866626B0 ModelClassType ADVFavoriteButton ADVFavoriteButton ADVFavoriteButton Pointer
    // 0A8 SkipButtonUpdaterOnSelectChoice          00018667EFC0 ModelClassType SkipButtonUpdaterOnSelectChoice SkipButtonUpdaterOnSelectChoice SkipButtonUpdaterOnSelectChoice Pointer
    // 0B0 SkipPU                                   0001865E8C10 ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer
    // 0B8 OpenableSkipPU                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C0 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 0C8 DisappearCanceler                        00018667EAF0 ModelClassType DisappearCanceler DisappearCanceler DisappearCanceler Pointer
    // 0D0 SkipFlag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ADVMenu : DataModel
    {
        public ButtonBase?                              MenuButton                              { get; set; }
        public List<GameObject>?                        HiddenButtonParentList                  { get; set; }
        public CanvasGroup?                             DisappearCanvasGroup                    { get; set; }
        public int                                      WaitMilisecondsForMenuFadeOut           { get; set; }
        public float                                    DurationSecondsForFadeOut               { get; set; }
        public IAdvSkipConfirmationPopupCaller?         AdvSkipConfirmationPopupCaller          { get; set; }
        public ADVLogCaller?                            AdvLogCaller                            { get; set; }
        public ButtonBase?                              LogButtonPrefab                         { get; set; }
        public ButtonBase?                              SkipButtonPrefab                        { get; set; }
        public ButtonBase?                              FavoriteButtonPrefab                    { get; set; }
        public ButtonBase?                              DisplayButtonPrefab                     { get; set; }
        public bool                                     Opening                                 { get; set; }
        public bool                                     IsADVUIActive                           { get; set; }
        public ADVAutoPlayController?                   AutoPlayController                      { get; set; }
        public Animator?                                OpeningAnimator                         { get; set; }
        public ScenarioID?                              ScenarioID                              { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public AdvFavoriteInfo?                         FavoriteInfo                            { get; set; }
        public ADVFavoriteButton?                       FavoriteButton                          { get; set; }
        public SkipButtonUpdaterOnSelectChoice?         SkipButtonUpdaterOnSelectChoice         { get; set; }
        public CommonPopupWindow?                       SkipPU                                  { get; set; }
        public bool                                     OpenableSkipPU                          { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public DisappearCanceler?                       DisappearCanceler                       { get; set; }
        public bool                                     SkipFlag                                { get; set; }

        public static ADVMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVMenu() { Pointer= p0 };

            value.MenuButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E45238 0x20 MenuButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HiddenButtonParentList                    = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665E45258 0x28 HiddenButtonParentList      ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.DisappearCanvasGroup                      = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665E45278 0x30 DisappearCanvasGroup        ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.WaitMilisecondsForMenuFadeOut             = GetInt32(new IntPtr(p + 0x038)); // 024665E45298 0x38 WaitMilisecondsForMenuFadeOut ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DurationSecondsForFadeOut                 = GetSingle(new IntPtr(p + 0x03C)); // 024665E452B8 0x3C DurationSecondsForFadeOut   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AdvSkipConfirmationPopupCaller            = GetObject<IAdvSkipConfirmationPopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.IAdvSkipConfirmationPopupCaller.FromPointer); // 024665E452D8 0x40 AdvSkipConfirmationPopupCaller ( 0001866EFEA0 ModelClassType IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller Pointer )
            value.AdvLogCaller                              = GetObject<ADVLogCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.ADVLogCaller.FromPointer); // 024665E452F8 0x48 AdvLogCaller                ( 000186664150 ModelClassType ADVLogCaller ADVLogCaller ADVLogCaller Pointer )
            value.LogButtonPrefab                           = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E45318 0x50 LogButtonPrefab             ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SkipButtonPrefab                          = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E45338 0x58 SkipButtonPrefab            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.FavoriteButtonPrefab                      = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E45358 0x60 FavoriteButtonPrefab        ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.DisplayButtonPrefab                       = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E45378 0x68 DisplayButtonPrefab         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Opening                                   = GetBool(new IntPtr(p + 0x070)); // 024665E45398 0x70 Opening                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsADVUIActive                             = GetBool(new IntPtr(p + 0x071)); // 024665E453B8 0x71 IsADVUIActive               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoPlayController                        = GetObject<ADVAutoPlayController>(new IntPtr(p + 0x078), ReversePrism.DataModels.ADVAutoPlayController.FromPointer); // 024665E453D8 0x78 AutoPlayController          ( 0001866621D0 ModelClassType ADVAutoPlayController ADVAutoPlayController ADVAutoPlayController Pointer )
            value.OpeningAnimator                           = GetObject<Animator>(new IntPtr(p + 0x080), ReversePrism.DataModels.Animator.FromPointer); // 024665E453F8 0x80 OpeningAnimator             ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ScenarioID                                = GetObject<ScenarioID>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScenarioID.FromPointer); // 024665E45418 0x88 ScenarioID                  ( 0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 024665E45438 0x90 AdvScenarioInfo             ( 0001866EF2B0 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.FavoriteInfo                              = GetObject<AdvFavoriteInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.AdvFavoriteInfo.FromPointer); // 024665E45458 0x98 FavoriteInfo                ( 000186695320 ModelClassType AdvFavoriteInfo AdvFavoriteInfo AdvFavoriteInfo Pointer )
            value.FavoriteButton                            = GetObject<ADVFavoriteButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ADVFavoriteButton.FromPointer); // 024665E45478 0xA0 FavoriteButton              ( 0001866626B0 ModelClassType ADVFavoriteButton ADVFavoriteButton ADVFavoriteButton Pointer )
            value.SkipButtonUpdaterOnSelectChoice           = GetObject<SkipButtonUpdaterOnSelectChoice>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SkipButtonUpdaterOnSelectChoice.FromPointer); // 024665E45498 0xA8 SkipButtonUpdaterOnSelectChoice ( 00018667EFC0 ModelClassType SkipButtonUpdaterOnSelectChoice SkipButtonUpdaterOnSelectChoice SkipButtonUpdaterOnSelectChoice Pointer )
            value.SkipPU                                    = GetObject<CommonPopupWindow>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 024665E454B8 0xB0 SkipPU                      ( 0001865E8C10 ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )
            value.OpenableSkipPU                            = GetBool(new IntPtr(p + 0x0B8)); // 024665E454D8 0xB8 OpenableSkipPU              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ScenarioManager.FromPointer); // 024665E454F8 0xC0 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.DisappearCanceler                         = GetObject<DisappearCanceler>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.DisappearCanceler.FromPointer); // 024665E45518 0xC8 DisappearCanceler           ( 00018667EAF0 ModelClassType DisappearCanceler DisappearCanceler DisappearCanceler Pointer )
            value.SkipFlag                                  = GetBool(new IntPtr(p + 0x0D0)); // 024665E45538 0xD0 SkipFlag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
