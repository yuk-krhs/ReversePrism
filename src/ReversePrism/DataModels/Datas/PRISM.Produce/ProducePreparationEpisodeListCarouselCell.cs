using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 EpisodeIdText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 StaminaText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 LockText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 LockObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 Thumbnail                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 060 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 068 SelectedFrame                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
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

            value.EpisodeIdText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A3D528 0x38 EpisodeIdText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A3D548 0x40 StaminaText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LockText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A3D568 0x48 LockText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 024665A3D588 0x50 LockObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Thumbnail                                 = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 024665A3D5A8 0x58 Thumbnail                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 024665A3D5C8 0x60 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SelectedFrame                             = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024665A3D5E8 0x68 SelectedFrame               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
