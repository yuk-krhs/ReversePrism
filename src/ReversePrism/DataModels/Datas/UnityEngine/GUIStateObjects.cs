using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_StateCache                             Dictionary`2<int, <object>> IL2CPP_TYPE_GENERICINST
    public partial class GUIStateObjects
    {

        public static GUIStateObjects? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIStateObjects();


            return value;
        }
    }
}
