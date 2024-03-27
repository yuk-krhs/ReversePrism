using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Content                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 ViewModel                                00018651A2F0 ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer
    // 038 onClose                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 onExchange                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onDetail                                 Subject`1<ExchangeSelectionListItemViewModel> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeCostumeListPopupView
    {
        public GameObject?                              CellPrefab                              { get; set; }
        public Transform?                               Content                                 { get; set; }
        public ExchangeSelectionListPopupViewModel?     ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeCostumeListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeCostumeListPopupView();

            value.CellPrefab                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8DB0B0 0x20 CellPrefab                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Content                                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB8DB0D0 0x28 Content                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListPopupViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExchangeSelectionListPopupViewModel.FromPointer); // 0270DB8DB0F0 0x30 ViewModel                   ( 00018651A2F0 ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB8DB170 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
