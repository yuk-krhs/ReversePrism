using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 <SameFunc>k__BackingField                Func`3<Scale, Scale, bool> IL2CPP_TYPE_GENERICINST
    public partial class ValuesScale : DataModel
    {

        public static ValuesScale? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValuesScale() { Pointer= p0 };


            return value;
        }
    }
}
