using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <CommandText>k__BackingField             string IL2CPP_TYPE_STRING
    // 000 <Value>k__BackingField                   <object> IL2CPP_TYPE_OBJECT
    public partial class CompileResult : DataModel
    {

        public static CompileResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompileResult() { Pointer= p0 };


            return value;
        }
    }
}
