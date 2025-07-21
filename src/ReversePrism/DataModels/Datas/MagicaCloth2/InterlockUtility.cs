using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ToFixed                                  int IL2CPP_TYPE_I4
    // 000 ToFloat                                  float IL2CPP_TYPE_R4
    public partial class InterlockUtility : DataModel
    {

        public static InterlockUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterlockUtility() { Pointer= p0 };


            return value;
        }
    }
}
