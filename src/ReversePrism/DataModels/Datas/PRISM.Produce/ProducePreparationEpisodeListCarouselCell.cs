using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 EpisodeIdText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 StaminaText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 LockText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 LockObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 058 Thumbnail                                ModelClassType UIImage UIImage UIImage Pointer
    // 060 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 068 SelectedFrame                            ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProducePreparationEpisodeListCarouselCell : DataModel
    {
        public UITextMeshProUGUI?                       EpisodeIdText                           { get; set; }
        public UITextMeshProUGUI?                       StaminaText                             { get; set; }
        public UITextMeshProUGUI?                       LockText                                { get; set; }
        public GameObject?                              LockObject                              { get; set; }
        public UIImage?                                 Thumbnail                               { get; set; }
        public Animator?                                Animator                                { get; set; }
        public GameObject?                              SelectedFrame                           { get; set; }

        public static ProducePreparationEpisodeListCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeListCarouselCell() { Pointer= p0 };

            value.EpisodeIdText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 EpisodeIdText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 StaminaText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LockText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 LockText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 LockObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Thumbnail                                 = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 Thumbnail                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 0x60 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.SelectedFrame                             = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 SelectedFrame               ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
