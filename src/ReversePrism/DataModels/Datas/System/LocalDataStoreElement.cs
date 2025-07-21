using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_value                                  <object> IL2CPP_TYPE_OBJECT
    // 018 M_cookie                                 ModelPrimitiveType long long long Int64
    public partial class LocalDataStoreElement : DataModel
    {
        public long                                     M_cookie                                { get; set; }

        public static LocalDataStoreElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalDataStoreElement() { Pointer= p0 };

            value.M_cookie                                  = GetInt64(new IntPtr(p + 0x018)); // 0x18 M_cookie                    ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
