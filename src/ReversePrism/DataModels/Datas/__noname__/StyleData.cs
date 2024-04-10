using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 startValue                               <var> IL2CPP_TYPE_VAR
    // 000 endValue                                 <var> IL2CPP_TYPE_VAR
    // 000 reversingAdjustedStartValue              <var> IL2CPP_TYPE_VAR
    // 000 currentValue                             <var> IL2CPP_TYPE_VAR
    public partial class StyleData : DataModel
    {

        public static StyleData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleData() { Pointer= p0 };


            return value;
        }
    }
}
