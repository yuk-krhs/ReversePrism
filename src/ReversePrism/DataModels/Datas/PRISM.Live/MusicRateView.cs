using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LevelImages                              ModelEnumListType LevelImage[] LevelImage[] List<LevelImage> Pointer
    // 028 StarObjects                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 RateText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GradeNameText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Animator                                 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    public partial class MusicRateView : DataModel
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
            var value   = new MusicRateView() { Pointer= p0 };

            value.LevelImages                               = GetEnumList<LevelImage>(new IntPtr(p + 0x020)); // 0x20 LevelImages                 ( ModelEnumListType LevelImage[] LevelImage[] List<LevelImage> Pointer )
            value.StarObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 StarObjects                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 RateText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GradeNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 GradeNameText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0x40 Animator                    ( ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )

            return value;
        }
    }
}
