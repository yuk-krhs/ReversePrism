using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Anim                                     0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 RewardItemIcon                           00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 030 ObjectNew                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ImageConvertItem                         000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 040 TextConvertAmount                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CanvasGroupReward                        000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 CanvasGroupConvert                       000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 IsConvertProduct                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ChangeTime                               float IL2CPP_TYPE_R4
    // 060 Model                                    0001865E9E00 ModelClassType MedalGashaResultViewCellModel MedalGashaResultViewCellModel MedalGashaResultViewCellModel Pointer
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

            value.Anim                                      = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 02466B9B1418 0x20 Anim                        ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 02466B9B1438 0x28 RewardItemIcon              ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ObjectNew                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B9B1458 0x30 ObjectNew                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImageConvertItem                          = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 02466B9B1478 0x38 ImageConvertItem            ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TextConvertAmount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9B1498 0x40 TextConvertAmount           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroupReward                         = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B9B14B8 0x48 CanvasGroupReward           ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CanvasGroupConvert                        = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B9B14D8 0x50 CanvasGroupConvert          ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IsConvertProduct                          = GetBool(new IntPtr(p + 0x058)); // 02466B9B14F8 0x58 IsConvertProduct            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Model                                     = GetObject<MedalGashaResultViewCellModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.MedalGashaResultViewCellModel.FromPointer); // 02466B9B1538 0x60 Model                       ( 0001865E9E00 ModelClassType MedalGashaResultViewCellModel MedalGashaResultViewCellModel MedalGashaResultViewCellModel Pointer )

            return value;
        }
    }
}
