using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CommonKey                                string IL2CPP_TYPE_STRING
    // 000 LinkKey                                  string IL2CPP_TYPE_STRING
    // 000 Format                                   string IL2CPP_TYPE_STRING
    // 000 SaltLength                               int IL2CPP_TYPE_I4
    public partial class FaqQueryGenerator
    {

        public static FaqQueryGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaqQueryGenerator();


            return value;
        }
    }
}
