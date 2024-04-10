using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AddMethod                                000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 <Arguments>k__BackingField               ReadOnlyCollection`1<Expression> IL2CPP_TYPE_GENERICINST
    public partial class ElementInit : DataModel
    {
        public MethodInfo?                              AddMethod                               { get; set; }

        public static ElementInit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementInit() { Pointer= p0 };

            value.AddMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F99F70 0x10 AddMethod                   ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
