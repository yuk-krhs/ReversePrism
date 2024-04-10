using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 Int32ArrayHelperWithDictionaryString IL2CPP_TYPE_CLASS
    public partial class Int32ArrayHelperWithDictionaryString : DataModel
    {

        public static Int32ArrayHelperWithDictionaryString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int32ArrayHelperWithDictionaryString() { Pointer= p0 };


            return value;
        }
    }
}
