using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AdaptivePerformanceManagerObjectName     string IL2CPP_TYPE_STRING
    // 018 M_ManagerGameObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class AdaptivePerformanceManagerSpawner
    {
        public GameObject?                              M_ManagerGameObject                     { get; set; }

        public static AdaptivePerformanceManagerSpawner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceManagerSpawner();

            value.M_ManagerGameObject                       = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0270D0909DD8 0x18 M_ManagerGameObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
