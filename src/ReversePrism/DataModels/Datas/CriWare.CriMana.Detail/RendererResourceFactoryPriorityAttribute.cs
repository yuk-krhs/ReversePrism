using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Priority                                 ModelPrimitiveType int int int Int32
    public partial class RendererResourceFactoryPriorityAttribute : DataModel
    {
        public int                                      Priority                                { get; set; }

        public static RendererResourceFactoryPriorityAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererResourceFactoryPriorityAttribute() { Pointer= p0 };

            value.Priority                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 Priority                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
