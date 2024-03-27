using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 00018655A7C0 ModelClassType FavoriteIconSelectGridView FavoriteIconSelectGridView FavoriteIconSelectGridView Pointer
    // 028 onClick                                  Subject`1<ValueTuple`2<bool, int>> IL2CPP_TYPE_GENERICINST
    // 030 Vm                                       000186715F30 ModelClassType SelectFavoriteMarkViewModel SelectFavoriteMarkViewModel SelectFavoriteMarkViewModel Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SelectFavoriteMarkPopupView
    {
        public FavoriteIconSelectGridView?              GridView                                { get; set; }
        public SelectFavoriteMarkViewModel?             Vm                                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SelectFavoriteMarkPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectFavoriteMarkPopupView();

            value.GridView                                  = GetObject<FavoriteIconSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FavoriteIconSelectGridView.FromPointer); // 0270DA339518 0x20 GridView                    ( 00018655A7C0 ModelClassType FavoriteIconSelectGridView FavoriteIconSelectGridView FavoriteIconSelectGridView Pointer )
            value.Vm                                        = GetObject<SelectFavoriteMarkViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectFavoriteMarkViewModel.FromPointer); // 0270DA339558 0x30 Vm                          ( 000186715F30 ModelClassType SelectFavoriteMarkViewModel SelectFavoriteMarkViewModel SelectFavoriteMarkViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA339578 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
