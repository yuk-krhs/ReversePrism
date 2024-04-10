using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ConstructorName                          string IL2CPP_TYPE_STRING
    // 008 TypeConstructorName                      string IL2CPP_TYPE_STRING
    public partial class ConstructorInfo : DataModel
    {

        public static ConstructorInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstructorInfo() { Pointer= p0 };


            return value;
        }
    }
}
