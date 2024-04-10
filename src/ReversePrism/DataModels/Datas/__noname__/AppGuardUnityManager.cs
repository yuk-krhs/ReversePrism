using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 APPGUARD_PLUGIN_VERSION                  string IL2CPP_TYPE_STRING
    // 008 _instance                                AppGuardUnityManager IL2CPP_TYPE_CLASS
    public partial class AppGuardUnityManager : DataModel
    {

        public static AppGuardUnityManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppGuardUnityManager() { Pointer= p0 };


            return value;
        }
    }
}
