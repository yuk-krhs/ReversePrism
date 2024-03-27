using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HowToPlayPopupOpener                     0001866D8EA0 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    public partial class PRISMFullSizePopupContentBase
    {
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }

        public static PRISMFullSizePopupContentBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMFullSizePopupContentBase();

            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x060), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0270D4C81C38 0x60 HowToPlayPopupOpener        ( 0001866D8EA0 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )

            return value;
        }
    }
}
