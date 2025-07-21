using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_switchMap                              Dictionary`2<string, SwitchValueState> IL2CPP_TYPE_GENERICINST
    // 008 s_defaultsInitialized                    bool IL2CPP_TYPE_BOOLEAN
    public partial class AppContext : DataModel
    {

        public static AppContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppContext() { Pointer= p0 };


            return value;
        }
    }
}
