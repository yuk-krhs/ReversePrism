using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 BooleanArrayHelperWithDictionaryString IL2CPP_TYPE_CLASS
    public partial class BooleanArrayHelperWithDictionaryString : DataModel
    {

        public static BooleanArrayHelperWithDictionaryString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BooleanArrayHelperWithDictionaryString() { Pointer= p0 };


            return value;
        }
    }
}
