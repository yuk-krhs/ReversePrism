using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 000186772A40 ModelClassType VariableCellListView VariableCellListView VariableCellListView Pointer
    // 028 ViewModel                                0001866A9610 ModelClassType IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel Pointer
    // 030 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class IdolBaseDetailRewardListPopupView : DataModel
    {
        public VariableCellListView?                    ListView                                { get; set; }
        public IdolBaseDetailRewardListViewModel?       ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static IdolBaseDetailRewardListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailRewardListPopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<VariableCellListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.VariableCellListView.FromPointer); // 02466A3515B8 0x20 ListView                    ( 000186772A40 ModelClassType VariableCellListView VariableCellListView VariableCellListView Pointer )
            value.ViewModel                                 = GetObject<IdolBaseDetailRewardListViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolBaseDetailRewardListViewModel.FromPointer); // 02466A3515D8 0x28 ViewModel                   ( 0001866A9610 ModelClassType IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A351618 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
