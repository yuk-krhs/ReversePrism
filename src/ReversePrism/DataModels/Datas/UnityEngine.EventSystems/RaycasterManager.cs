using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Raycasters                             List`1<BaseRaycaster> IL2CPP_TYPE_GENERICINST
    public partial class RaycasterManager
    {

        public static RaycasterManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RaycasterManager();


            return value;
        }
    }
}
