using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Changed                                  000185B98AE0 ModelClassListType Object[] Object[] List<Object> Pointer
    // 018 changedID                                NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 destroyedID                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TypeDispatchData
    {
        public List<Object>?                            Changed                                 { get; set; }

        public static TypeDispatchData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeDispatchData();

            value.Changed                                   = GetObjectList<Object>(new IntPtr(p + 0x010), ReversePrism.DataModels.Object.FromPointer); // 0270068B1968 0x10 Changed                     ( 000185B98AE0 ModelClassListType Object[] Object[] List<Object> Pointer )

            return value;
        }
    }
}
