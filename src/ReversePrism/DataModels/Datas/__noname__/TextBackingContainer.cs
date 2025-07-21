using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Array                                  ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 M_Count                                  ModelPrimitiveType int int int Int32
    public partial class TextBackingContainer : DataModel
    {
        public List<uint>?                              M_Array                                 { get; set; }
        public int                                      M_Count                                 { get; set; }

        public static TextBackingContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextBackingContainer() { Pointer= p0 };

            value.M_Array                                   = GetUInt32List(new IntPtr(p + 0x010)); // 0x10 M_Array                     ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_Count                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Count                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
