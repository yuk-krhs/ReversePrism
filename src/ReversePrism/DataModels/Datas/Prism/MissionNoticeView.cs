using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MissionCompletText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 MissionGroupText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CheckMarkImg                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 MissionGroupBackImg                      0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 048 MissionGroupObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class MissionNoticeView
    {
        public UITextMeshProUGUI?                       MissionCompletText                      { get; set; }
        public UITextMeshProUGUI?                       MissionGroupText                        { get; set; }
        public UIImage?                                 CheckMarkImg                            { get; set; }
        public UIImage?                                 MissionGroupBackImg                     { get; set; }
        public Animator?                                Animator                                { get; set; }
        public GameObject?                              MissionGroupObject                      { get; set; }

        public static MissionNoticeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionNoticeView();

            value.MissionCompletText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027003F92BA0 0x20 MissionCompletText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionGroupText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027003F92BC0 0x28 MissionGroupText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CheckMarkImg                              = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 027003F92BE0 0x30 CheckMarkImg                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.MissionGroupBackImg                       = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 027003F92C00 0x38 MissionGroupBackImg         ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 027003F92C20 0x40 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.MissionGroupObject                        = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 027003F92C40 0x48 MissionGroupObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
