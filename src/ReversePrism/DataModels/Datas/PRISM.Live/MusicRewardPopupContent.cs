using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MusicTypeIcon                            000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 068 MusicName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 MusicDifficultyButtonGroup               000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 MaskRoot                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 MaskLabel                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 SkipButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 ScoreRankRewardInfoCells                 000185B97C90 ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer
    // 098 ComboRankRewardInfoCells                 000185B97C90 ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer
    // 0A0 IsSkippable                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 AnimationCanceller                       000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 0B0 CloseButton                              0001867605D0 ModelClassType PopupButton PopupButton PopupButton Pointer
    public partial class MusicRewardPopupContent
    {
        public RawImage?                                MusicTypeIcon                           { get; set; }
        public UITextMeshProUGUI?                       MusicName                               { get; set; }
        public ToggleButtonGroup?                       MusicDifficultyButtonGroup              { get; set; }
        public GameObject?                              MaskRoot                                { get; set; }
        public UITextMeshProUGUI?                       MaskLabel                               { get; set; }
        public UIButton?                                SkipButton                              { get; set; }
        public List<MusicRewardInfoCell>?               ScoreRankRewardInfoCells                { get; set; }
        public List<MusicRewardInfoCell>?               ComboRankRewardInfoCells                { get; set; }
        public bool                                     IsSkippable                             { get; set; }
        public AutoCancellationTokenSource              AnimationCanceller                      { get; set; }
        public PopupButton?                             CloseButton                             { get; set; }

        public static MusicRewardPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRewardPopupContent();

            value.MusicTypeIcon                             = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0270D5217F60 0x60 MusicTypeIcon               ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5217F80 0x68 MusicName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicDifficultyButtonGroup                = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5217FA0 0x70 MusicDifficultyButtonGroup  ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.MaskRoot                                  = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5217FC0 0x78 MaskRoot                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MaskLabel                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5217FE0 0x80 MaskLabel                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5218000 0x88 SkipButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ScoreRankRewardInfoCells                  = GetObjectList<MusicRewardInfoCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.MusicRewardInfoCell.FromPointer); // 0270D5218020 0x90 ScoreRankRewardInfoCells    ( 000185B97C90 ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer )
            value.ComboRankRewardInfoCells                  = GetObjectList<MusicRewardInfoCell>(new IntPtr(p + 0x098), ReversePrism.DataModels.MusicRewardInfoCell.FromPointer); // 0270D5218040 0x98 ComboRankRewardInfoCells    ( 000185B97C90 ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer )
            value.IsSkippable                               = GetBool(new IntPtr(p + 0x0A0)); // 0270D5218060 0xA0 IsSkippable                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AnimationCanceller                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0A8)); // 0270D5218080 0xA8 AnimationCanceller          ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.CloseButton                               = GetObject<PopupButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PopupButton.FromPointer); // 0270D52180A0 0xB0 CloseButton                 ( 0001867605D0 ModelClassType PopupButton PopupButton PopupButton Pointer )

            return value;
        }
    }
}
