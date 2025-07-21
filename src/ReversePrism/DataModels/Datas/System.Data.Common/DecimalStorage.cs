using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           Decimal IL2CPP_TYPE_VALUETYPE
    // 050 Values                                   ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer
    public partial class DecimalStorage : DataModel
    {
        public List<Decimal>?                           Values                                  { get; set; }

        public static DecimalStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecimalStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<Decimal>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer )

            return value;
        }
    }
}
