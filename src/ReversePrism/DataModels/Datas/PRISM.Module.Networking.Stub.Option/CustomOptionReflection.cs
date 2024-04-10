using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 descriptor                               FileDescriptor IL2CPP_TYPE_CLASS
    public partial class CustomOptionReflection : DataModel
    {

        public static CustomOptionReflection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomOptionReflection() { Pointer= p0 };


            return value;
        }
    }
}
