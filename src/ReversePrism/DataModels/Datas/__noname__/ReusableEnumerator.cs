using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   ModelClassType BatchFrame BatchFrame BatchFrame Pointer
    // 018 CurrentFrame                             ModelPrimitiveType int int int Int32
    public partial class ReusableEnumerator : DataModel
    {
        public BatchFrame?                              Parent                                  { get; set; }
        public int                                      CurrentFrame                            { get; set; }

        public static ReusableEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableEnumerator() { Pointer= p0 };

            value.Parent                                    = GetObject<BatchFrame>(new IntPtr(p + 0x010), ReversePrism.DataModels.BatchFrame.FromPointer); // 0x10 Parent                      ( ModelClassType BatchFrame BatchFrame BatchFrame Pointer )
            value.CurrentFrame                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentFrame                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
