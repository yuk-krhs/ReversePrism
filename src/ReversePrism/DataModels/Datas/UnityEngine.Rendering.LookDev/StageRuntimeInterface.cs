using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_AddGameObject                          Func`2<bool, GameObject> IL2CPP_TYPE_GENERICINST
    // 018 m_GetCamera                              Func`1<Camera> IL2CPP_TYPE_GENERICINST
    // 020 m_GetSunLight                            Func`1<Light> IL2CPP_TYPE_GENERICINST
    // 028 SRPData                                  <object> IL2CPP_TYPE_OBJECT
    public partial class StageRuntimeInterface
    {

        public static StageRuntimeInterface? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StageRuntimeInterface();


            return value;
        }
    }
}
