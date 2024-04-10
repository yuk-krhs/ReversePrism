using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 scriptVersionString                      string IL2CPP_TYPE_STRING
    // 000 supportsCriFsInstaller                   bool IL2CPP_TYPE_BOOLEAN
    // 000 supportsCriFsWebInstaller                bool IL2CPP_TYPE_BOOLEAN
    // 000 pluginName                               string IL2CPP_TYPE_STRING
    // 000 pluginCallingConvention                  CallingConvention IL2CPP_TYPE_VALUETYPE
    // 000 _managerObject                           GameObject IL2CPP_TYPE_CLASS
    public partial class Common : DataModel
    {

        public static Common? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Common() { Pointer= p0 };


            return value;
        }
    }
}
