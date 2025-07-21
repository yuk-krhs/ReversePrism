using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 028 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 Vm                                       ModelClassType VoicePlayListPopupViewModel VoicePlayListPopupViewModel VoicePlayListPopupViewModel Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class VoicePlayListPopupView : DataModel
    {
        public CategoryElementGridView?                 GridView                                { get; set; }
        public VoicePlayListPopupViewModel?             Vm                                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static VoicePlayListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePlayListPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<CategoryElementGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 0x20 GridView                    ( ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.Vm                                        = GetObject<VoicePlayListPopupViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoicePlayListPopupViewModel.FromPointer); // 0x30 Vm                          ( ModelClassType VoicePlayListPopupViewModel VoicePlayListPopupViewModel VoicePlayListPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
