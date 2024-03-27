using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Error                                    00018662D410 ModelClassType ErrorMain ErrorMain ErrorMain Pointer
    public partial class ErrorModel
    {
        public ErrorMain?                               Error                                   { get; set; }

        public static ErrorModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorModel();

            value.Error                                     = GetObject<ErrorMain>(new IntPtr(p + 0x010), ReversePrism.DataModels.ErrorMain.FromPointer); // 0270DB480F20 0x10 Error                       ( 00018662D410 ModelClassType ErrorMain ErrorMain ErrorMain Pointer )

            return value;
        }
    }
}
