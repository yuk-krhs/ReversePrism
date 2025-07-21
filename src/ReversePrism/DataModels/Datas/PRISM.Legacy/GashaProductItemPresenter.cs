using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType GashaProductItemView GashaProductItemView GashaProductItemView Pointer
    // 028 OnLongPressDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class GashaProductItemPresenter : DataModel
    {
        public GashaProductItemView?                    View                                    { get; set; }
        public IDisposable?                             OnLongPressDisposable                   { get; set; }

        public static GashaProductItemPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaProductItemPresenter() { Pointer= p0 };

            value.View                                      = GetObject<GashaProductItemView>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductItemView.FromPointer); // 0x20 View                        ( ModelClassType GashaProductItemView GashaProductItemView GashaProductItemView Pointer )
            value.OnLongPressDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0x28 OnLongPressDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
