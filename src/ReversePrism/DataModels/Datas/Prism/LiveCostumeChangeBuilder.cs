using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186549B80 ModelClassType LiveCostumeChangeView LiveCostumeChangeView LiveCostumeChangeView Pointer
    public partial class LiveCostumeChangeBuilder : DataModel
    {
        public LiveCostumeChangeView?                   View                                    { get; set; }

        public static LiveCostumeChangeBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeBuilder() { Pointer= p0 };

            value.View                                      = GetObject<LiveCostumeChangeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveCostumeChangeView.FromPointer); // 02466B698C18 0x20 View                        ( 000186549B80 ModelClassType LiveCostumeChangeView LiveCostumeChangeView LiveCostumeChangeView Pointer )

            return value;
        }
    }
}
