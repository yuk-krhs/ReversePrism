using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 usagePage                                Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 018 logicalMinimum                           Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 020 logicalMaximum                           Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 028 physicalMinimum                          Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 030 physicalMaximum                          Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 038 unitExponent                             Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 040 unit                                     Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 048 reportSize                               Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 050 reportCount                              Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 058 reportId                                 Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class HIDItemStateGlobal : DataModel
    {

        public static HIDItemStateGlobal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDItemStateGlobal() { Pointer= p0 };


            return value;
        }
    }
}
