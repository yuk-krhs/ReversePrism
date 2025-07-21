using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LabelIndex                               ModelPrimitiveType int int int Int32
    public partial class IndexedBranchInstruction : DataModel
    {
        public int                                      LabelIndex                              { get; set; }

        public static IndexedBranchInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexedBranchInstruction() { Pointer= p0 };

            value.LabelIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 LabelIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
