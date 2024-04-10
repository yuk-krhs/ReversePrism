using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoadingViewType                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TitleArgument : DataModel
    {
        public int                                      LoadingViewType                         { get; set; }

        public static TitleArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleArgument() { Pointer= p0 };

            value.LoadingViewType                           = GetInt32(new IntPtr(p + 0x010)); // 0245A44A0A30 0x10 LoadingViewType             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
