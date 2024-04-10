using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186611120 ModelClassType GashaProductItemView GashaProductItemView GashaProductItemView Pointer
    // 028 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 030 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 038 OnLongPressDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class GashaProductItemPresenter : DataModel
    {
        public GashaProductItemView?                    View                                    { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public IDisposable?                             OnLongPressDisposable                   { get; set; }

        public static GashaProductItemPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaProductItemPresenter() { Pointer= p0 };

            value.View                                      = GetObject<GashaProductItemView>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductItemView.FromPointer); // 02466537B288 0x20 View                        ( 000186611120 ModelClassType GashaProductItemView GashaProductItemView GashaProductItemView Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x028), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 02466537B2A8 0x28 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 02466537B2C8 0x30 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.OnLongPressDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 02466537B2E8 0x38 OnLongPressDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
