using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000185CBAA18 ModelClassListType TransformData[] TransformData[] List<TransformData> Pointer
    public partial class TransformDataArray : DataModel
    {
        public List<TransformData>?                     Data                                    { get; set; }

        public static TransformDataArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformDataArray() { Pointer= p0 };

            value.Data                                      = GetObjectList<TransformData>(new IntPtr(p + 0x010), ReversePrism.DataModels.TransformData.FromPointer); // 0245A5CE70B8 0x10 Data                        ( 000185CBAA18 ModelClassListType TransformData[] TransformData[] List<TransformData> Pointer )

            return value;
        }
    }
}
