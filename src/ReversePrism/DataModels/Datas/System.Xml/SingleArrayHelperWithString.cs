using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 SingleArrayHelperWithString IL2CPP_TYPE_CLASS
    public partial class SingleArrayHelperWithString : DataModel
    {

        public static SingleArrayHelperWithString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleArrayHelperWithString() { Pointer= p0 };


            return value;
        }
    }
}
