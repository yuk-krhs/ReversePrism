using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 refList                                  List`1<ObjectRef> IL2CPP_TYPE_GENERICINST
    public partial class CriDisposableObjectManager : DataModel
    {

        public static CriDisposableObjectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriDisposableObjectManager() { Pointer= p0 };


            return value;
        }
    }
}
