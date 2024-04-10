using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _onCallbackThreadUnsafe                  Callback IL2CPP_TYPE_CLASS
    // 008 objectLock                               <object> IL2CPP_TYPE_OBJECT
    public partial class CriErrorNotifier : DataModel
    {

        public static CriErrorNotifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriErrorNotifier() { Pointer= p0 };


            return value;
        }
    }
}
