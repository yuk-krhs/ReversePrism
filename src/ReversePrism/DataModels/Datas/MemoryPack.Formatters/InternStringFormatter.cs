using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  InternStringFormatter IL2CPP_TYPE_CLASS
    public partial class InternStringFormatter : DataModel
    {

        public static InternStringFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternStringFormatter() { Pointer= p0 };


            return value;
        }
    }
}
