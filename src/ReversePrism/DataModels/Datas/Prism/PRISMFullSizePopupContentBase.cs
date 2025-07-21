using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    public partial class PRISMFullSizePopupContentBase : DataModel
    {
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }

        public static PRISMFullSizePopupContentBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMFullSizePopupContentBase() { Pointer= p0 };

            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x060), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x60 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )

            return value;
        }
    }
}
