using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoadingViewType                          ModelPrimitiveType int int int Int32
    public partial class TitleParameter : DataModel
    {
        public int                                      LoadingViewType                         { get; set; }

        public static TitleParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleParameter() { Pointer= p0 };

            value.LoadingViewType                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 LoadingViewType             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
