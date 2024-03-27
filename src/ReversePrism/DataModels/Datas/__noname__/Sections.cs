using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 section1                                 int IL2CPP_TYPE_I4
    // 000 section2                                 int IL2CPP_TYPE_I4
    // 000 section3                                 int IL2CPP_TYPE_I4
    // 000 section4                                 int IL2CPP_TYPE_I4
    // 000 section5                                 int IL2CPP_TYPE_I4
    // 000 section6                                 int IL2CPP_TYPE_I4
    // 000 section7                                 int IL2CPP_TYPE_I4
    // 000 section8                                 int IL2CPP_TYPE_I4
    public partial class Sections
    {

        public static Sections? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Sections();


            return value;
        }
    }
}
