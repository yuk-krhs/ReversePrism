using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 008 systemDependency                         ISystemDependencyProvider IL2CPP_TYPE_CLASS
    public partial class DependencyInjector : DataModel
    {

        public static DependencyInjector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DependencyInjector() { Pointer= p0 };


            return value;
        }
    }
}
