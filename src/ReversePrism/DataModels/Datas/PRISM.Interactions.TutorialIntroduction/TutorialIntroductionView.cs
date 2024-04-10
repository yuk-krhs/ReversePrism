using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PanelViews                               000185CAD2C8 ModelClassListType TutorialIntroductionPhasePanelView[] TutorialIntroductionPhasePanelView[] List<TutorialIntroductionPhasePanelView> Pointer
    // 028 PrevButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 CarouselIndicator                        000186547E60 ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer
    // 040 FinishSequence                           0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    public partial class TutorialIntroductionView : DataModel
    {
        public List<TutorialIntroductionPhasePanelView>? PanelViews                              { get; set; }
        public UIButton?                                PrevButton                              { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public CarouselIndicator?                       CarouselIndicator                       { get; set; }
        public ITutorialSequence?                       FinishSequence                          { get; set; }

        public static TutorialIntroductionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialIntroductionView() { Pointer= p0 };

            value.PanelViews                                = GetObjectList<TutorialIntroductionPhasePanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialIntroductionPhasePanelView.FromPointer); // 02466B6B3428 0x20 PanelViews                  ( 000185CAD2C8 ModelClassListType TutorialIntroductionPhasePanelView[] TutorialIntroductionPhasePanelView[] List<TutorialIntroductionPhasePanelView> Pointer )
            value.PrevButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6B3448 0x28 PrevButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6B3468 0x30 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CarouselIndicator                         = GetObject<CarouselIndicator>(new IntPtr(p + 0x038), ReversePrism.DataModels.CarouselIndicator.FromPointer); // 02466B6B3488 0x38 CarouselIndicator           ( 000186547E60 ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer )
            value.FinishSequence                            = GetObject<ITutorialSequence>(new IntPtr(p + 0x040), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 02466B6B34A8 0x40 FinishSequence              ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )

            return value;
        }
    }
}
