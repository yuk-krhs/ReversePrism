using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NewRecordBadge                           ModelClassType GameObject GameObject GameObject Pointer
    // 028 ComboTexts                               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 ComboLeadingZeroTexts                    ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 ComboRankAnimator                        ModelClassType Animator Animator Animator Pointer
    // 040 ClearInfoBadges                          ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 ShinyCount                               ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer
    // 050 PerfectCount                             ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer
    // 058 GreatCount                               ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer
    // 060 GoodCount                                ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer
    // 068 MissCount                                ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer
    // 070 SkillBoostedToPerfectBadge               ModelClassType GameObject GameObject GameObject Pointer
    // 078 SkillBoostedToGreatBadge                 ModelClassType GameObject GameObject GameObject Pointer
    // 080 DetailAnnotation                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 SwitchDetailButton                       ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 090 SaveData                                 ModelClassType ComboInfoViewSaveData ComboInfoViewSaveData ComboInfoViewSaveData Pointer
    public partial class LiveResultComboInfoView : DataModel
    {
        public GameObject?                              NewRecordBadge                          { get; set; }
        public List<UITextMeshProUGUI>?                 ComboTexts                              { get; set; }
        public List<UITextMeshProUGUI>?                 ComboLeadingZeroTexts                   { get; set; }
        public Animator?                                ComboRankAnimator                       { get; set; }
        public List<GameObject>?                        ClearInfoBadges                         { get; set; }
        public LiveResultJudgeCountView?                ShinyCount                              { get; set; }
        public LiveResultJudgeCountView?                PerfectCount                            { get; set; }
        public LiveResultJudgeCountView?                GreatCount                              { get; set; }
        public LiveResultJudgeCountView?                GoodCount                               { get; set; }
        public LiveResultJudgeCountView?                MissCount                               { get; set; }
        public GameObject?                              SkillBoostedToPerfectBadge              { get; set; }
        public GameObject?                              SkillBoostedToGreatBadge                { get; set; }
        public UITextMeshProUGUI?                       DetailAnnotation                        { get; set; }
        public ClickNumberCountedButton?                SwitchDetailButton                      { get; set; }
        public ComboInfoViewSaveData?                   SaveData                                { get; set; }

        public static LiveResultComboInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultComboInfoView() { Pointer= p0 };

            value.NewRecordBadge                            = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 NewRecordBadge              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ComboTexts                                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ComboTexts                  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ComboLeadingZeroTexts                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ComboLeadingZeroTexts       ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ComboRankAnimator                         = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 ComboRankAnimator           ( ModelClassType Animator Animator Animator Pointer )
            value.ClearInfoBadges                           = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ClearInfoBadges             ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ShinyCount                                = GetObject<LiveResultJudgeCountView>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveResultJudgeCountView.FromPointer); // 0x48 ShinyCount                  ( ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer )
            value.PerfectCount                              = GetObject<LiveResultJudgeCountView>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveResultJudgeCountView.FromPointer); // 0x50 PerfectCount                ( ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer )
            value.GreatCount                                = GetObject<LiveResultJudgeCountView>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveResultJudgeCountView.FromPointer); // 0x58 GreatCount                  ( ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer )
            value.GoodCount                                 = GetObject<LiveResultJudgeCountView>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveResultJudgeCountView.FromPointer); // 0x60 GoodCount                   ( ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer )
            value.MissCount                                 = GetObject<LiveResultJudgeCountView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultJudgeCountView.FromPointer); // 0x68 MissCount                   ( ModelClassType LiveResultJudgeCountView LiveResultJudgeCountView LiveResultJudgeCountView Pointer )
            value.SkillBoostedToPerfectBadge                = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 SkillBoostedToPerfectBadge  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillBoostedToGreatBadge                  = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 SkillBoostedToGreatBadge    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DetailAnnotation                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 DetailAnnotation            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SwitchDetailButton                        = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0x88 SwitchDetailButton          ( ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.SaveData                                  = GetObject<ComboInfoViewSaveData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ComboInfoViewSaveData.FromPointer); // 0x90 SaveData                    ( ModelClassType ComboInfoViewSaveData ComboInfoViewSaveData ComboInfoViewSaveData Pointer )

            return value;
        }
    }
}
