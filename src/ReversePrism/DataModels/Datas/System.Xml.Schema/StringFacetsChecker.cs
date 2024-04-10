using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 languagePattern                          Regex IL2CPP_TYPE_CLASS
    public partial class StringFacetsChecker : DataModel
    {

        public static StringFacetsChecker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringFacetsChecker() { Pointer= p0 };


            return value;
        }
    }
}
