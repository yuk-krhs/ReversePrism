using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 HomeGridView                             ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 030 ProduceGridView                          ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 038 LiveGridView                             ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 040 OtherGridView                            ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Vm                                       ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class VoicePlayTabListPopupView : DataModel
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public CategoryElementGridView?                 HomeGridView                            { get; set; }
        public CategoryElementGridView?                 ProduceGridView                         { get; set; }
        public CategoryElementGridView?                 LiveGridView                            { get; set; }
        public CategoryElementGridView?                 OtherGridView                           { get; set; }
        public VoicePlayTabListPopupViewModel?          Vm                                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static VoicePlayTabListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePlayTabListPopupView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.HomeGridView                              = GetObject<CategoryElementGridView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 0x28 HomeGridView                ( ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.ProduceGridView                           = GetObject<CategoryElementGridView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 0x30 ProduceGridView             ( ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.LiveGridView                              = GetObject<CategoryElementGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 0x38 LiveGridView                ( ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.OtherGridView                             = GetObject<CategoryElementGridView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 0x40 OtherGridView               ( ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.Vm                                        = GetObject<VoicePlayTabListPopupViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoicePlayTabListPopupViewModel.FromPointer); // 0x50 Vm                          ( ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
