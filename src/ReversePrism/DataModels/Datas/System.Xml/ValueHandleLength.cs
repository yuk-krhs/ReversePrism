using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Int8                                     int IL2CPP_TYPE_I4
    // 000 Int16                                    int IL2CPP_TYPE_I4
    // 000 Int32                                    int IL2CPP_TYPE_I4
    // 000 Int64                                    int IL2CPP_TYPE_I4
    // 000 UInt64                                   int IL2CPP_TYPE_I4
    // 000 Single                                   int IL2CPP_TYPE_I4
    // 000 Double                                   int IL2CPP_TYPE_I4
    // 000 Decimal                                  int IL2CPP_TYPE_I4
    // 000 DateTime                                 int IL2CPP_TYPE_I4
    // 000 TimeSpan                                 int IL2CPP_TYPE_I4
    // 000 Guid                                     int IL2CPP_TYPE_I4
    // 000 UniqueId                                 int IL2CPP_TYPE_I4
    public partial class ValueHandleLength
    {

        public static ValueHandleLength? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueHandleLength();


            return value;
        }
    }
}
