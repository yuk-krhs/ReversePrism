using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ISCharaDetailPopupView ISCharaDetailPopupView ISCharaDetailPopupView Pointer
    // 018 Vm                                       ModelClassType SCharaDetailPopupViewModel SCharaDetailPopupViewModel SCharaDetailPopupViewModel Pointer
    // 020 SCharaDetailPopupViewFactory             ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 028 onChangeFavoriteMark                     Subject`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    public partial class SCharaDetailPopupPresenter : DataModel
    {
        public ISCharaDetailPopupView?                  View                                    { get; set; }
        public SCharaDetailPopupViewModel?              Vm                                      { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }

        public static SCharaDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaDetailPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ISCharaDetailPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISCharaDetailPopupView.FromPointer); // 0x10 View                        ( ModelClassType ISCharaDetailPopupView ISCharaDetailPopupView ISCharaDetailPopupView Pointer )
            value.Vm                                        = GetObject<SCharaDetailPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCharaDetailPopupViewModel.FromPointer); // 0x18 Vm                          ( ModelClassType SCharaDetailPopupViewModel SCharaDetailPopupViewModel SCharaDetailPopupViewModel Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 0x20 SCharaDetailPopupViewFactory ( ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
