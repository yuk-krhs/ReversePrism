using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType JewelContentView JewelContentView JewelContentView Pointer
    // 028 ShopOverlayCaller                        ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer
    // 030 JewelModel                               ModelClassType JewelModel JewelModel JewelModel Pointer
    // 038 onClosePostProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class JewelContent : DataModel
    {
        public JewelContentView?                        View                                    { get; set; }
        public ShopOverlayCaller?                       ShopOverlayCaller                       { get; set; }
        public JewelModel?                              JewelModel                              { get; set; }

        public static JewelContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JewelContent() { Pointer= p0 };

            value.View                                      = GetObject<JewelContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.JewelContentView.FromPointer); // 0x20 View                        ( ModelClassType JewelContentView JewelContentView JewelContentView Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 0x28 ShopOverlayCaller           ( ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.JewelModel                                = GetObject<JewelModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.JewelModel.FromPointer); // 0x30 JewelModel                  ( ModelClassType JewelModel JewelModel JewelModel Pointer )

            return value;
        }
    }
}
