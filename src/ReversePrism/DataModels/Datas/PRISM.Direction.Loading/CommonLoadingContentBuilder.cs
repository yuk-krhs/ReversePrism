using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LoadingContentView                       0001865E7010 ModelClassType CommonLoadingContentView CommonLoadingContentView CommonLoadingContentView Pointer
    public partial class CommonLoadingContentBuilder : DataModel
    {
        public CommonLoadingContentView?                LoadingContentView                      { get; set; }

        public static CommonLoadingContentBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonLoadingContentBuilder() { Pointer= p0 };

            value.LoadingContentView                        = GetObject<CommonLoadingContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonLoadingContentView.FromPointer); // 0245A1EA0070 0x20 LoadingContentView          ( 0001865E7010 ModelClassType CommonLoadingContentView CommonLoadingContentView CommonLoadingContentView Pointer )

            return value;
        }
    }
}
