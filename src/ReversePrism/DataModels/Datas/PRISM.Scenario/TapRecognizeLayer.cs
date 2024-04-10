using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    public partial class TapRecognizeLayer : DataModel
    {
        public ButtonBase?                              Button                                  { get; set; }
        public Canvas?                                  Canvas                                  { get; set; }

        public static TapRecognizeLayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TapRecognizeLayer() { Pointer= p0 };

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E4F0B8 0x20 Button                      ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x028), ReversePrism.DataModels.Canvas.FromPointer); // 024665E4F0D8 0x28 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )

            return value;
        }
    }
}
