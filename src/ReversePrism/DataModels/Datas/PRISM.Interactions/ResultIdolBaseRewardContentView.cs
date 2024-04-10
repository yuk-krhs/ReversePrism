using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolViews                                000185B912F0 ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer
    // 028 ContentViewAnimator                      0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 CanvasFadeDuration                       0001866656B0 ModelPrimitiveType float float float Single
    // 040 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 EndButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 MemorialLiveButton                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
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

            value.IdolViews                                 = GetObjectList<LiveResultIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 02466A145610 0x20 IdolViews                   ( 000185B912F0 ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer )
            value.ContentViewAnimator                       = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 02466A145630 0x28 ContentViewAnimator         ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A145650 0x30 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CanvasFadeDuration                        = GetSingle(new IntPtr(p + 0x038)); // 02466A145670 0x38 CanvasFadeDuration          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A145690 0x40 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EndButton                                 = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1456B0 0x48 EndButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MemorialLiveButton                        = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1456D0 0x50 MemorialLiveButton          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
