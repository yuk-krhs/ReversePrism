using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Win8                                     ModelClassType IWindowsIAP IWindowsIAP IWindowsIAP Pointer
    // 018 Callback                                 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 020 Util                                     ModelClassType IUtil IUtil IUtil Pointer
    // 028 Logger                                   ModelClassType ILogger ILogger ILogger Pointer
    // 030 M_CanReceivePurchases                    ModelPrimitiveType bool bool bool Bool
    public partial class WinRTStore : DataModel
    {
        public IWindowsIAP?                             Win8                                    { get; set; }
        public IStoreCallback?                          Callback                                { get; set; }
        public IUtil?                                   Util                                    { get; set; }
        public ILogger?                                 Logger                                  { get; set; }
        public bool                                     M_CanReceivePurchases                   { get; set; }

        public static WinRTStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WinRTStore() { Pointer= p0 };

            value.Win8                                      = GetObject<IWindowsIAP>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWindowsIAP.FromPointer); // 0x10 Win8                        ( ModelClassType IWindowsIAP IWindowsIAP IWindowsIAP Pointer )
            value.Callback                                  = GetObject<IStoreCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0x18 Callback                    ( ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.Util                                      = GetObject<IUtil>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUtil.FromPointer); // 0x20 Util                        ( ModelClassType IUtil IUtil IUtil Pointer )
            value.Logger                                    = GetObject<ILogger>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILogger.FromPointer); // 0x28 Logger                      ( ModelClassType ILogger ILogger ILogger Pointer )
            value.M_CanReceivePurchases                     = GetBool(new IntPtr(p + 0x030)); // 0x30 M_CanReceivePurchases       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
