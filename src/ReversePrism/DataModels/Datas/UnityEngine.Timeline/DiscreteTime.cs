using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_Tick                                   double IL2CPP_TYPE_R8
    // 000 kMaxTime                                 DiscreteTime IL2CPP_TYPE_VALUETYPE
    // 010 M_DiscreteTime                           0001865F8300 ModelPrimitiveType long long long Int64
    public partial class DiscreteTime
    {
        public long                                     M_DiscreteTime                          { get; set; }

        public static DiscreteTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiscreteTime();

            value.M_DiscreteTime                            = GetInt64(new IntPtr(p + 0x010)); // 027006F4FC30 0x10 M_DiscreteTime              ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
