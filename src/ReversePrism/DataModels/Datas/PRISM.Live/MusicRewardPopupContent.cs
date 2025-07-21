using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MusicTypeIcon                            ModelClassType RawImage RawImage RawImage Pointer
    // 068 MusicName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 MusicDifficultyButtonGroup               ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 MaskRoot                                 ModelClassType GameObject GameObject GameObject Pointer
    // 080 MaskLabel                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 SkipButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 090 ScoreRankRewardInfoCells                 ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer
    // 098 ComboRankRewardInfoCells                 ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer
    // 0A0 IsSkippable                              ModelPrimitiveType bool bool bool Bool
    // 0A8 AnimationCanceller                       ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 0B0 CloseButton                              ModelClassType PopupButton PopupButton PopupButton Pointer
    public partial class MusicRewardPopupContent : DataModel
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
            var value   = new MusicRewardPopupContent() { Pointer= p0 };

            value.MusicTypeIcon                             = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0x60 MusicTypeIcon               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 MusicName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicDifficultyButtonGroup                = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x70 MusicDifficultyButtonGroup  ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.MaskRoot                                  = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 MaskRoot                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MaskLabel                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 MaskLabel                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 SkipButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ScoreRankRewardInfoCells                  = GetObjectList<MusicRewardInfoCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.MusicRewardInfoCell.FromPointer); // 0x90 ScoreRankRewardInfoCells    ( ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer )
            value.ComboRankRewardInfoCells                  = GetObjectList<MusicRewardInfoCell>(new IntPtr(p + 0x098), ReversePrism.DataModels.MusicRewardInfoCell.FromPointer); // 0x98 ComboRankRewardInfoCells    ( ModelClassListType MusicRewardInfoCell[] MusicRewardInfoCell[] List<MusicRewardInfoCell> Pointer )
            value.IsSkippable                               = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsSkippable                 ( ModelPrimitiveType bool bool bool Bool )
            value.AnimationCanceller                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 AnimationCanceller          ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.CloseButton                               = GetObject<PopupButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PopupButton.FromPointer); // 0xB0 CloseButton                 ( ModelClassType PopupButton PopupButton PopupButton Pointer )

            return value;
        }
    }
}
