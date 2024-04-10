using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ht                                       ConcurrentDictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class NameCache : DataModel
    {
        public string                                   Name                                    { get; set; }

        public static NameCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameCache() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024666CC4F90 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
