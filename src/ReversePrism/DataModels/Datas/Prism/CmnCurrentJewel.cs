using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtPaid                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtFree                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 JewelButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 LimitedSaleJewelButton                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ShopOverlayCaller                        0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer
    // 048 onClosePostProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 050 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 058 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class CmnCurrentJewel
    {
        public UITextMeshProUGUI?                       TxtPaid                                 { get; set; }
        public UITextMeshProUGUI?                       TxtFree                                 { get; set; }
        public ButtonBase?                              JewelButton                             { get; set; }
        public GameObject?                              LimitedSaleJewelButton                  { get; set; }
        public ShopOverlayCaller?                       ShopOverlayCaller                       { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static CmnCurrentJewel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CmnCurrentJewel();

            value.TxtPaid                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4ED0270 0x20 TxtPaid                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFree                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4ED0290 0x28 TxtFree                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D4ED02B0 0x30 JewelButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LimitedSaleJewelButton                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4ED02D0 0x38 LimitedSaleJewelButton      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 0270D4ED02F0 0x40 ShopOverlayCaller           ( 0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D4ED0330 0x50 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D4ED0350 0x58 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
