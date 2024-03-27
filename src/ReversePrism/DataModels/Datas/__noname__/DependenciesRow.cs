using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Label                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Dep                                      0001865F7700 ModelPrimitiveType long long long Int64
    public partial class DependenciesRow
    {
        public long                                     Label                                   { get; set; }
        public long                                     Dep                                     { get; set; }

        public static DependenciesRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DependenciesRow();

            value.Label                                     = GetInt64(new IntPtr(p + 0x010)); // 027003E03290 0x10 Label                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Dep                                       = GetInt64(new IntPtr(p + 0x018)); // 027003E032B0 0x18 Dep                         ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
