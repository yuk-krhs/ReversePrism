using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 objects                                  <object>[] IL2CPP_TYPE_SZARRAY
    // 018 negObjects                               <object>[] IL2CPP_TYPE_SZARRAY
    public partial class SizedArray
    {

        public static SizedArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SizedArray();


            return value;
        }
    }
}
