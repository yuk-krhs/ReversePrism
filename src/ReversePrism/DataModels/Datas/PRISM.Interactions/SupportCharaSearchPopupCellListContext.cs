using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vm                                       0001865E2150 ModelClassType SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel Pointer
    // 018 onSelectCell                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaSearchPopupCellListContext
    {
        public SupportCharaSearchPopupViewModel?        Vm                                      { get; set; }

        public static SupportCharaSearchPopupCellListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaSearchPopupCellListContext();

            value.Vm                                        = GetObject<SupportCharaSearchPopupViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SupportCharaSearchPopupViewModel.FromPointer); // 0270DA341818 0x10 Vm                          ( 0001865E2150 ModelClassType SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel Pointer )

            return value;
        }
    }
}
