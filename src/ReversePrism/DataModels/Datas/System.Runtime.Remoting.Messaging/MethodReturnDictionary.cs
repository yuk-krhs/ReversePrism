using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InternalReturnKeys                       string[] IL2CPP_TYPE_SZARRAY
    // 008 InternalExceptionKeys                    string[] IL2CPP_TYPE_SZARRAY
    public partial class MethodReturnDictionary : DataModel
    {

        public static MethodReturnDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodReturnDictionary() { Pointer= p0 };


            return value;
        }
    }
}
