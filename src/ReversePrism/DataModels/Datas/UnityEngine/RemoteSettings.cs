using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Updated                                  UpdatedEventHandler IL2CPP_TYPE_CLASS
    // 008 BeforeFetchFromServer                    Action IL2CPP_TYPE_CLASS
    // 010 Completed                                Action`3<bool, bool, int> IL2CPP_TYPE_GENERICINST
    public partial class RemoteSettings
    {

        public static RemoteSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteSettings();


            return value;
        }
    }
}
