using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Valid                                    000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CacheRefInstance
    {
        public bool                                     Valid                                   { get; set; }

        public static CacheRefInstance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CacheRefInstance();

            value.Valid                                     = GetBool(new IntPtr(p + 0x010)); // 0270D7866E70 0x10 Valid                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
