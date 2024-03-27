using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Factory                                  000186722210 ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer
    public partial class EfficacyDetailListPopupCallerImplement
    {
        public EfficacyDetailListPopupViewFactory?      Factory                                 { get; set; }

        public static EfficacyDetailListPopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EfficacyDetailListPopupCallerImplement();

            value.Factory                                   = GetObject<EfficacyDetailListPopupViewFactory>(new IntPtr(p + 0x010), ReversePrism.DataModels.EfficacyDetailListPopupViewFactory.FromPointer); // 0270DB9C2D70 0x10 Factory                     ( 000186722210 ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer )

            return value;
        }
    }
}
