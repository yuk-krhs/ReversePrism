using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 mono_corlib_version                      string IL2CPP_TYPE_STRING
    // 000 nl                                       string IL2CPP_TYPE_STRING
    // 008 os                                       OperatingSystem IL2CPP_TYPE_CLASS
    public partial class Environment : DataModel
    {

        public static Environment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Environment() { Pointer= p0 };


            return value;
        }
    }
}
