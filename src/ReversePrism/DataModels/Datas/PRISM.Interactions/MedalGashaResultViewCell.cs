using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Anim                                     ModelClassType Animator Animator Animator Pointer
    // 028 RewardItemIcon                           ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 030 ObjectNew                                ModelClassType GameObject GameObject GameObject Pointer
    // 038 ImageConvertItem                         ModelClassType RawImage RawImage RawImage Pointer
    // 040 TextConvertAmount                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CanvasGroupReward                        ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 CanvasGroupConvert                       ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 IsConvertProduct                         ModelPrimitiveType bool bool bool Bool
    // 000 ChangeTime                               float IL2CPP_TYPE_R4
    // 060 Model                                    ModelClassType MedalGashaResultViewCellModel MedalGashaResultViewCellModel MedalGashaResultViewCellModel Pointer
    public partial class MedalGashaResultViewCell : DataModel
    {
        public Animator?                                Anim                                    { get; set; }
        public RewardItemIcon?                          RewardItemIcon                          { get; set; }
        public GameObject?                              ObjectNew                               { get; set; }
        public RawImage?                                ImageConvertItem                        { get; set; }
        public UITextMeshProUGUI?                       TextConvertAmount                       { get; set; }
        public CanvasGroup?                             CanvasGroupReward                       { get; set; }
        public CanvasGroup?                             CanvasGroupConvert                      { get; set; }
        public bool                                     IsConvertProduct                        { get; set; }
        public MedalGashaResultViewCellModel?           Model                                   { get; set; }

        public static MedalGashaResultViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaResultViewCell() { Pointer= p0 };

            value.Anim                                      = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 Anim                        ( ModelClassType Animator Animator Animator Pointer )
            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x28 RewardItemIcon              ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ObjectNew                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ObjectNew                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImageConvertItem                          = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0x38 ImageConvertItem            ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TextConvertAmount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TextConvertAmount           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroupReward                         = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x48 CanvasGroupReward           ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CanvasGroupConvert                        = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x50 CanvasGroupConvert          ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IsConvertProduct                          = GetBool(new IntPtr(p + 0x058)); // 0x58 IsConvertProduct            ( ModelPrimitiveType bool bool bool Bool )
            value.Model                                     = GetObject<MedalGashaResultViewCellModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.MedalGashaResultViewCellModel.FromPointer); // 0x60 Model                       ( ModelClassType MedalGashaResultViewCellModel MedalGashaResultViewCellModel MedalGashaResultViewCellModel Pointer )

            return value;
        }
    }
}
