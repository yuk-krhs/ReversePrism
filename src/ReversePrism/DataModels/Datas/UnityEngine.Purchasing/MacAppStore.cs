using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Name                                     string IL2CPP_TYPE_STRING
    public partial class MacAppStore
    {

        public static MacAppStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MacAppStore();


            return value;
        }
    }
}
