using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Priority                                 0001865F4940 ModelPrimitiveType int int int Int32
    public partial class RendererResourceFactoryPriorityAttribute
    {
        public int                                      Priority                                { get; set; }

        public static RendererResourceFactoryPriorityAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererResourceFactoryPriorityAttribute();

            value.Priority                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D1874A88 0x10 Priority                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
