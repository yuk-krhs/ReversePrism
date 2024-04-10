using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 000 s_TypeDispatch                           Action`6<Object[], <int>, <int>, int, int, Action`1<TypeDispatchData>> IL2CPP_TYPE_GENERICINST
    // 008 s_TransformDispatch                      Action`8<<int>, <int>, <int>, <int>, <int>, <int>, int, Action`1<TransformDispatchData>> IL2CPP_TYPE_GENERICINST
    public partial class ObjectDispatcher : DataModel
    {

        public static ObjectDispatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectDispatcher() { Pointer= p0 };


            return value;
        }
    }
}
