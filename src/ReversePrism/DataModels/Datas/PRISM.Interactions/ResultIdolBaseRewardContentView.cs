using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolViews                                ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer
    // 028 ContentViewAnimator                      ModelClassType Animator Animator Animator Pointer
    // 030 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 CanvasFadeDuration                       ModelPrimitiveType float float float Single
    // 040 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 048 EndButton                                ModelClassType UIButton UIButton UIButton Pointer
    // 050 MemorialLiveButton                       ModelClassType UIButton UIButton UIButton Pointer
    public partial class ResultIdolBaseRewardContentView : DataModel
    {
        public List<LiveResultIdolView>?                IdolViews                               { get; set; }
        public Animator?                                ContentViewAnimator                     { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    CanvasFadeDuration                      { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public UIButton?                                EndButton                               { get; set; }
        public UIButton?                                MemorialLiveButton                      { get; set; }

        public static ResultIdolBaseRewardContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResultIdolBaseRewardContentView() { Pointer= p0 };

            value.IdolViews                                 = GetObjectList<LiveResultIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 0x20 IdolViews                   ( ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer )
            value.ContentViewAnimator                       = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 ContentViewAnimator         ( ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CanvasFadeDuration                        = GetSingle(new IntPtr(p + 0x038)); // 0x38 CanvasFadeDuration          ( ModelPrimitiveType float float float Single )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EndButton                                 = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 EndButton                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MemorialLiveButton                        = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 MemorialLiveButton          ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
