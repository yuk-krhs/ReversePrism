using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 DoubleArrayHelperWithDictionaryString IL2CPP_TYPE_CLASS
    public partial class DoubleArrayHelperWithDictionaryString : DataModel
    {

        public static DoubleArrayHelperWithDictionaryString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoubleArrayHelperWithDictionaryString() { Pointer= p0 };


            return value;
        }
    }
}
