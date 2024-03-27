using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LoadType                               00018669A410 ModelEnumType RuntimeInitializeLoadType RuntimeInitializeLoadType RuntimeInitializeLoadType Int32
    public partial class RuntimeInitializeOnLoadMethodAttribute
    {
        public RuntimeInitializeLoadType                M_LoadType                              { get; set; }

        public static RuntimeInitializeOnLoadMethodAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeInitializeOnLoadMethodAttribute();

            value.M_LoadType                                = (RuntimeInitializeLoadType)GetInt32(new IntPtr(p + 0x010)); // 02700248C5B8 0x10 M_LoadType                  ( 00018669A410 ModelEnumType RuntimeInitializeLoadType RuntimeInitializeLoadType RuntimeInitializeLoadType Int32 )

            return value;
        }
    }
}
