using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 factoryList                              SortedList`2<int, RendererResourceFactory> IL2CPP_TYPE_GENERICINST
    // 010 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RendererResourceFactory
    {
        public bool                                     Disposed                                { get; set; }

        public static RendererResourceFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererResourceFactory();

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0270D1874F68 0x10 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
