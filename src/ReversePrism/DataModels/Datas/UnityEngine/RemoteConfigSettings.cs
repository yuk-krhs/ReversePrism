using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 Updated                                  Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class RemoteConfigSettings : DataModel
    {

        public static RemoteConfigSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteConfigSettings() { Pointer= p0 };


            return value;
        }
    }
}
