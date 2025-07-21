using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Result                                 ModelClassListType Object[] Object[] List<Object> Pointer
    public partial class AsyncInstantiateOperation : DataModel
    {
        public List<Object>?                            M_Result                                { get; set; }

        public static AsyncInstantiateOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncInstantiateOperation() { Pointer= p0 };

            value.M_Result                                  = GetObjectList<Object>(new IntPtr(p + 0x020), ReversePrism.DataModels.Object.FromPointer); // 0x20 M_Result                    ( ModelClassListType Object[] Object[] List<Object> Pointer )

            return value;
        }
    }
}
