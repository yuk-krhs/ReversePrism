using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 PIdolGridView                            00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 030 SCharaGridView                           00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onPlay                                   Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 <OnDetailCellIcon>k__BackingField        IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class MoviePopupView
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public CategoryElementGridView?                 PIdolGridView                           { get; set; }
        public CategoryElementGridView?                 SCharaGridView                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static MoviePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoviePopupView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA2FF5B0 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.PIdolGridView                             = GetObject<CategoryElementGridView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 0270DA2FF5D0 0x28 PIdolGridView               ( 00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.SCharaGridView                            = GetObject<CategoryElementGridView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 0270DA2FF5F0 0x30 SCharaGridView              ( 00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2FF670 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
