using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Desc                                     ModelEnumType RendererListDesc RendererListDesc RendererListDesc Int32
    // 0E0 RendererList                             ModelEnumType RendererList RendererList RendererList Int32
    public partial class RendererListResource : DataModel
    {
        public RendererListDesc                         Desc                                    { get; set; }
        public RendererList                             RendererList                            { get; set; }

        public static RendererListResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererListResource() { Pointer= p0 };

            value.Desc                                      = (RendererListDesc)GetInt32(new IntPtr(p + 0x010)); // 0x10 Desc                        ( ModelEnumType RendererListDesc RendererListDesc RendererListDesc Int32 )
            value.RendererList                              = (RendererList)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 RendererList                ( ModelEnumType RendererList RendererList RendererList Int32 )

            return value;
        }
    }
}
