using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   0001866F7BE0 ModelClassType BatchFrame BatchFrame BatchFrame Pointer
    // 018 CurrentFrame                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReusableEnumerator
    {
        public BatchFrame?                              Parent                                  { get; set; }
        public int                                      CurrentFrame                            { get; set; }

        public static ReusableEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableEnumerator();

            value.Parent                                    = GetObject<BatchFrame>(new IntPtr(p + 0x010), ReversePrism.DataModels.BatchFrame.FromPointer); // 0270D9834D88 0x10 Parent                      ( 0001866F7BE0 ModelClassType BatchFrame BatchFrame BatchFrame Pointer )
            value.CurrentFrame                              = GetInt32(new IntPtr(p + 0x018)); // 0270D9834DA8 0x18 CurrentFrame                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
