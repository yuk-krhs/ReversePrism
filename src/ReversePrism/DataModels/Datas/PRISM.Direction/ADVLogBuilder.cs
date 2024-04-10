using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AdvLogFactoryPrefab                      000186665770 ModelClassType ADVLogOverlayFactory ADVLogOverlayFactory ADVLogOverlayFactory Pointer
    // 028 View                                     0001866E9F30 ModelClassType IADVLogOverlayView IADVLogOverlayView IADVLogOverlayView Pointer
    public partial class ADVLogBuilder : DataModel
    {
        public ADVLogOverlayFactory?                    AdvLogFactoryPrefab                     { get; set; }
        public IADVLogOverlayView?                      View                                    { get; set; }

        public static ADVLogBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogBuilder() { Pointer= p0 };

            value.AdvLogFactoryPrefab                       = GetObject<ADVLogOverlayFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.ADVLogOverlayFactory.FromPointer); // 02466B6B6448 0x20 AdvLogFactoryPrefab         ( 000186665770 ModelClassType ADVLogOverlayFactory ADVLogOverlayFactory ADVLogOverlayFactory Pointer )
            value.View                                      = GetObject<IADVLogOverlayView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IADVLogOverlayView.FromPointer); // 02466B6B6468 0x28 View                        ( 0001866E9F30 ModelClassType IADVLogOverlayView IADVLogOverlayView IADVLogOverlayView Pointer )

            return value;
        }
    }
}
