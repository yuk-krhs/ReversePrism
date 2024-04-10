using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EPHEMERON_TOMBSTONE                      <object> IL2CPP_TYPE_OBJECT
    public partial class GC : DataModel
    {

        public static GC? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GC() { Pointer= p0 };


            return value;
        }
    }
}
