using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelectObjects                            ModelClassListType SelectObjectData[] SelectObjectData[] List<SelectObjectData> Pointer
    public partial class SelectObject : DataModel
    {
        public List<SelectObjectData>?                  SelectObjects                           { get; set; }

        public static SelectObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectObject() { Pointer= p0 };

            value.SelectObjects                             = GetObjectList<SelectObjectData>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelectObjectData.FromPointer); // 0x20 SelectObjects               ( ModelClassListType SelectObjectData[] SelectObjectData[] List<SelectObjectData> Pointer )

            return value;
        }
    }
}
