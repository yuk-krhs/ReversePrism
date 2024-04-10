using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018667C510 ModelClassType TitleView TitleView TitleView Pointer
    public partial class TitleBuilder : DataModel
    {
        public TitleView?                               View                                    { get; set; }

        public static TitleBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleBuilder() { Pointer= p0 };

            value.View                                      = GetObject<TitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TitleView.FromPointer); // 0245A43FEB70 0x20 View                        ( 00018667C510 ModelClassType TitleView TitleView TitleView Pointer )

            return value;
        }
    }
}
