using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TwoChoicesContent                        0001866CEB80 ModelClassType TwoChoicesContent TwoChoicesContent TwoChoicesContent Pointer
    public partial class TitleLicensePopupView : DataModel
    {
        public TwoChoicesContent?                       TwoChoicesContent                       { get; set; }

        public static TitleLicensePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleLicensePopupView() { Pointer= p0 };

            value.TwoChoicesContent                         = GetObject<TwoChoicesContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwoChoicesContent.FromPointer); // 0245A43FBCA8 0x20 TwoChoicesContent           ( 0001866CEB80 ModelClassType TwoChoicesContent TwoChoicesContent TwoChoicesContent Pointer )

            return value;
        }
    }
}
