using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 HasTutorialFinished                      SavableProperty`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class PermanentDataContainer
    {

        public static PermanentDataContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PermanentDataContainer();


            return value;
        }
    }
}
