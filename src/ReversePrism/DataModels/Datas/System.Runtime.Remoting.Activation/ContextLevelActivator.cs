using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_NextActivator                          0001866ED780 ModelClassType IActivator IActivator IActivator Pointer
    public partial class ContextLevelActivator
    {
        public IActivator?                              M_NextActivator                         { get; set; }

        public static ContextLevelActivator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextLevelActivator();

            value.M_NextActivator                           = GetObject<IActivator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IActivator.FromPointer); // 0270D6BE69B8 0x10 M_NextActivator             ( 0001866ED780 ModelClassType IActivator IActivator IActivator Pointer )

            return value;
        }
    }
}
