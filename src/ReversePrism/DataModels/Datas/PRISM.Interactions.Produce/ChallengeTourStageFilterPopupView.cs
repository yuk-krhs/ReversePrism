using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FilterStarButtons                        ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 ResetButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 030 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 onFilterClick                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourStageFilterPopupView : DataModel
    {
        public List<ToggleButton>?                      FilterStarButtons                       { get; set; }
        public UIButton?                                ResetButton                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourStageFilterPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageFilterPopupView() { Pointer= p0 };

            value.FilterStarButtons                         = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 FilterStarButtons           ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ResetButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 ResetButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
