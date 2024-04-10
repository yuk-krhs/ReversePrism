using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxNameLenght                            int IL2CPP_TYPE_I4
    // 000 MaxInputNameLength                       int IL2CPP_TYPE_I4
    // 000 MonthMaxDays                             int[] IL2CPP_TYPE_SZARRAY
    // 000 MaxCommentLength                         int IL2CPP_TYPE_I4
    public partial class ProfileConst : DataModel
    {

        public static ProfileConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileConst() { Pointer= p0 };


            return value;
        }
    }
}
