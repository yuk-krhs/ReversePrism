using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 PrevButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class ChallengeTourStageListView
    {
        public UIButton?                                NextButton                              { get; set; }
        public UIButton?                                PrevButton                              { get; set; }

        public static ChallengeTourStageListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageListView();

            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1CCA90 0x88 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PrevButton                                = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1CCAB0 0x90 PrevButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
