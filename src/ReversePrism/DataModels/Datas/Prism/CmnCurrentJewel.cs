using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtPaid                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtFree                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 JewelButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 LimitedSaleJewelButton                   ModelClassType GameObject GameObject GameObject Pointer
    // 040 ShopOverlayCaller                        ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer
    // 048 onClosePostProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 050 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 058 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.TxtPaid                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtPaid                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFree                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtFree                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 JewelButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LimitedSaleJewelButton                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 LimitedSaleJewelButton      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 0x40 ShopOverlayCaller           ( ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x50 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x58 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
