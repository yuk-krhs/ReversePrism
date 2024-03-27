using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LevelImages                              000185CBF418 ModelEnumListType LevelImage[] LevelImage[] List<LevelImage> Pointer
    // 028 StarObjects                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 RateText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GradeNameText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Animator                                 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    public partial class MusicRateView
    {
        public List<LevelImage>?                        LevelImages                             { get; set; }
        public List<GameObject>?                        StarObjects                             { get; set; }
        public UITextMeshProUGUI?                       RateText                                { get; set; }
        public UITextMeshProUGUI?                       GradeNameText                           { get; set; }
        public ParamRememberableAnimator?               Animator                                { get; set; }

        public static MusicRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateView();

            value.LevelImages                               = GetEnumList<LevelImage>(new IntPtr(p + 0x020)); // 0270D51349D0 0x20 LevelImages                 ( 000185CBF418 ModelEnumListType LevelImage[] LevelImage[] List<LevelImage> Pointer )
            value.StarObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D51349F0 0x28 StarObjects                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5134A10 0x30 RateText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GradeNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5134A30 0x38 GradeNameText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0270D5134A50 0x40 Animator                    ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )

            return value;
        }
    }
}
