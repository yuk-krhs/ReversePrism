using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _instance                                CriMonoBehaviourManager IL2CPP_TYPE_CLASS
    // 008 criMonoBehaviourList                     List`1<CriMonoBehaviour> IL2CPP_TYPE_GENERICINST
    public partial class CriMonoBehaviourManager
    {

        public static CriMonoBehaviourManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriMonoBehaviourManager();


            return value;
        }
    }
}
