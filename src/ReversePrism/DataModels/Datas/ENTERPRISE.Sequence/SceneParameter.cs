using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 initialParameter                         <object> IL2CPP_TYPE_OBJECT
    // 018 beforeActivated                          Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class SceneParameter
    {

        public static SceneParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneParameter();


            return value;
        }
    }
}
