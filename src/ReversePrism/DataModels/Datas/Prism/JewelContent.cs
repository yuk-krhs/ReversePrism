using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018674AEF0 ModelClassType JewelContentView JewelContentView JewelContentView Pointer
    // 028 ShopOverlayCaller                        0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer
    // 030 JewelModel                               00018674B3C0 ModelClassType JewelModel JewelModel JewelModel Pointer
    // 038 onClosePostProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class JewelContent
    {
        public JewelContentView?                        View                                    { get; set; }
        public ShopOverlayCaller?                       ShopOverlayCaller                       { get; set; }
        public JewelModel?                              JewelModel                              { get; set; }

        public static JewelContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JewelContent();

            value.View                                      = GetObject<JewelContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.JewelContentView.FromPointer); // 027004F46370 0x20 View                        ( 00018674AEF0 ModelClassType JewelContentView JewelContentView JewelContentView Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 027004F46390 0x28 ShopOverlayCaller           ( 0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.JewelModel                                = GetObject<JewelModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.JewelModel.FromPointer); // 027004F463B0 0x30 JewelModel                  ( 00018674B3C0 ModelClassType JewelModel JewelModel JewelModel Pointer )

            return value;
        }
    }
}
