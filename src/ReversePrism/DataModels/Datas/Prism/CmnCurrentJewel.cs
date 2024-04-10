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
    public partial class CmnCurrentJewel : DataModel
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
            var value   = new CmnCurrentJewel() { Pointer= p0 };

            value.TxtPaid                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664F35E88 0x20 TxtPaid                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFree                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664F35EA8 0x28 TxtFree                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 024664F35EC8 0x30 JewelButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LimitedSaleJewelButton                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024664F35EE8 0x38 LimitedSaleJewelButton      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 024664F35F08 0x40 ShopOverlayCaller           ( 0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024664F35F48 0x50 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024664F35F68 0x58 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
