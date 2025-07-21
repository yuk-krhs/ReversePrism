using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 handle                                   <int> IL2CPP_TYPE_I
    // 028 DataHandle                               ModelEnumType GCHandle GCHandle GCHandle Int32
    public partial class CriAtomExAcb : DataModel
    {
        public GCHandle                                 DataHandle                              { get; set; }

        public static CriAtomExAcb? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExAcb() { Pointer= p0 };

            value.DataHandle                                = (GCHandle)GetInt32(new IntPtr(p + 0x028)); // 0x28 DataHandle                  ( ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
