using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Label                                    ModelPrimitiveType long long long Int64
    // 018 Dep                                      ModelPrimitiveType long long long Int64
    public partial class DependenciesRow : DataModel
    {
        public long                                     Label                                   { get; set; }
        public long                                     Dep                                     { get; set; }

        public static DependenciesRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DependenciesRow() { Pointer= p0 };

            value.Label                                     = GetInt64(new IntPtr(p + 0x010)); // 0x10 Label                       ( ModelPrimitiveType long long long Int64 )
            value.Dep                                       = GetInt64(new IntPtr(p + 0x018)); // 0x18 Dep                         ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
