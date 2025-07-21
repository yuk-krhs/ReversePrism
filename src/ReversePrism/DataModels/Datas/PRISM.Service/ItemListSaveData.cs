using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TabIndex                                 ModelPrimitiveType int int int Int32
    // 018 ScrollPositions                          ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class ItemListSaveData : DataModel
    {
        public int                                      TabIndex                                { get; set; }
        public List<float>?                             ScrollPositions                         { get; set; }

        public static ItemListSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListSaveData() { Pointer= p0 };

            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 TabIndex                    ( ModelPrimitiveType int int int Int32 )
            value.ScrollPositions                           = GetSingleList(new IntPtr(p + 0x018)); // 0x18 ScrollPositions             ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
