using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ZipObservable`8<<var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 q1                                       Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 q2                                       Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 q3                                       Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 q4                                       Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 q5                                       Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 q6                                       Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 q7                                       Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class Zip : DataModel
    {

        public static Zip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Zip() { Pointer= p0 };


            return value;
        }
    }
}
