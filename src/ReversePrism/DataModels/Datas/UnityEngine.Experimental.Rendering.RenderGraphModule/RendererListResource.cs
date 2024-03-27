using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Desc                                     000186658DF0 ModelEnumType RendererListDesc RendererListDesc RendererListDesc Int32
    // 0E0 RendererList                             000186658460 ModelEnumType RendererList RendererList RendererList Int32
    public partial class RendererListResource
    {
        public RendererListDesc                         Desc                                    { get; set; }
        public RendererList                             RendererList                            { get; set; }

        public static RendererListResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererListResource();

            value.Desc                                      = (RendererListDesc)GetInt32(new IntPtr(p + 0x010)); // 0270D90F45A0 0x10 Desc                        ( 000186658DF0 ModelEnumType RendererListDesc RendererListDesc RendererListDesc Int32 )
            value.RendererList                              = (RendererList)GetInt32(new IntPtr(p + 0x0E0)); // 0270D90F45C0 0xE0 RendererList                ( 000186658460 ModelEnumType RendererList RendererList RendererList Int32 )

            return value;
        }
    }
}
