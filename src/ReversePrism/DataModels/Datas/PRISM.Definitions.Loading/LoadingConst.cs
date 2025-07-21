using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CharaAnimationLength                     int IL2CPP_TYPE_I4
    // 000 AnimationIntervalFrame                   int IL2CPP_TYPE_I4
    public partial class LoadingConst : DataModel
    {

        public static LoadingConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingConst() { Pointer= p0 };


            return value;
        }
    }
}
