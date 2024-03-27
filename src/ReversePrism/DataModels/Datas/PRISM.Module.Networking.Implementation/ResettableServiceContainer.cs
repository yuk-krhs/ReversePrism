using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Container                                000186736390 ModelClassType ServerServiceContainer ServerServiceContainer ServerServiceContainer Pointer
    public partial class ResettableServiceContainer
    {
        public ServerServiceContainer?                  Container                               { get; set; }

        public static ResettableServiceContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResettableServiceContainer();

            value.Container                                 = GetObject<ServerServiceContainer>(new IntPtr(p + 0x010), ReversePrism.DataModels.ServerServiceContainer.FromPointer); // 027003A344C0 0x10 Container                   ( 000186736390 ModelClassType ServerServiceContainer ServerServiceContainer ServerServiceContainer Pointer )

            return value;
        }
    }
}
