using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 klass                                    <int> IL2CPP_TYPE_I
    // 020 handle                                   <int> IL2CPP_TYPE_I
    public partial class RuntimeEventInfo : DataModel
    {

        public static RuntimeEventInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeEventInfo() { Pointer= p0 };


            return value;
        }
    }
}
