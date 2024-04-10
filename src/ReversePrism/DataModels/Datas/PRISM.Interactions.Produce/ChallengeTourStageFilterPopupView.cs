using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FilterStarButtons                        000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 ResetButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 onDecideClick                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onCancelClick                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onFilterClick                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourStageFilterPopupView : DataModel
    {
        public List<ToggleButton>?                      FilterStarButtons                       { get; set; }
        public UIButton?                                ResetButton                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourStageFilterPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageFilterPopupView() { Pointer= p0 };

            value.FilterStarButtons                         = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466A225388 0x20 FilterStarButtons           ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ResetButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2253A8 0x28 ResetButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A225428 0x48 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A225448 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
