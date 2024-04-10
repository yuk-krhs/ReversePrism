using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 usage                                    Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 018 usageMinimum                             Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 020 usageMaximum                             Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 028 designatorIndex                          Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 030 designatorMinimum                        Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 038 designatorMaximum                        Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 040 stringIndex                              Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 048 stringMinimum                            Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 050 stringMaximum                            Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 058 UsageList                                000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class HIDItemStateLocal : DataModel
    {
        public List<int>?                               UsageList                               { get; set; }

        public static HIDItemStateLocal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDItemStateLocal() { Pointer= p0 };

            value.UsageList                                 = GetInt32List(new IntPtr(p + 0x058)); // 024667831F68 0x58 UsageList                   ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
