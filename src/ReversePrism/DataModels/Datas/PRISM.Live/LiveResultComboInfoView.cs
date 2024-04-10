using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NewRecordBadge                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ComboTexts                               000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 ComboLeadingZeroTexts                    000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 ComboRankAnimator                        0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 AllPerfectBadge                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 AllGreatBadge                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 FullComboBadge                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 PerfectText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GreatText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 GreatDetailText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 GoodText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GoodDetailText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 MissText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 DetailAnnotation                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 SwitchDetailButton                       0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 098 SaveData                                 0001865DDF90 ModelClassType ComboInfoViewSaveData ComboInfoViewSaveData ComboInfoViewSaveData Pointer
    public partial class LiveResultComboInfoView : DataModel
    {
        public GameObject?                              NewRecordBadge                          { get; set; }
        public List<UITextMeshProUGUI>?                 ComboTexts                              { get; set; }
        public List<UITextMeshProUGUI>?                 ComboLeadingZeroTexts                   { get; set; }
        public Animator?                                ComboRankAnimator                       { get; set; }
        public GameObject?                              AllPerfectBadge                         { get; set; }
        public GameObject?                              AllGreatBadge                           { get; set; }
        public GameObject?                              FullComboBadge                          { get; set; }
        public UITextMeshProUGUI?                       PerfectText                             { get; set; }
        public UITextMeshProUGUI?                       GreatText                               { get; set; }
        public UITextMeshProUGUI?                       GreatDetailText                         { get; set; }
        public UITextMeshProUGUI?                       GoodText                                { get; set; }
        public UITextMeshProUGUI?                       GoodDetailText                          { get; set; }
        public UITextMeshProUGUI?                       MissText                                { get; set; }
        public UITextMeshProUGUI?                       DetailAnnotation                        { get; set; }
        public ClickNumberCountedButton?                SwitchDetailButton                      { get; set; }
        public ComboInfoViewSaveData?                   SaveData                                { get; set; }

        public static LiveResultComboInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultComboInfoView() { Pointer= p0 };

            value.NewRecordBadge                            = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0246652DE408 0x20 NewRecordBadge              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ComboTexts                                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE428 0x28 ComboTexts                  ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ComboLeadingZeroTexts                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE448 0x30 ComboLeadingZeroTexts       ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ComboRankAnimator                         = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0246652DE468 0x38 ComboRankAnimator           ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.AllPerfectBadge                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0246652DE488 0x40 AllPerfectBadge             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AllGreatBadge                             = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0246652DE4A8 0x48 AllGreatBadge               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FullComboBadge                            = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246652DE4C8 0x50 FullComboBadge              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PerfectText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE4E8 0x58 PerfectText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GreatText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE508 0x60 GreatText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GreatDetailText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE528 0x68 GreatDetailText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoodText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE548 0x70 GoodText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoodDetailText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE568 0x78 GoodDetailText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE588 0x80 MissText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DetailAnnotation                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246652DE5A8 0x88 DetailAnnotation            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SwitchDetailButton                        = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0246652DE5C8 0x90 SwitchDetailButton          ( 0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.SaveData                                  = GetObject<ComboInfoViewSaveData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ComboInfoViewSaveData.FromPointer); // 0246652DE5E8 0x98 SaveData                    ( 0001865DDF90 ModelClassType ComboInfoViewSaveData ComboInfoViewSaveData ComboInfoViewSaveData Pointer )

            return value;
        }
    }
}
