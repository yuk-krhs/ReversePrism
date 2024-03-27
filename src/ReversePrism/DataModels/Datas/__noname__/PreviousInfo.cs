using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Code                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 SortKey                                  IntPtr IL2CPP_TYPE_PTR
    public partial class PreviousInfo
    {
        public int                                      Code                                    { get; set; }

        public static PreviousInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreviousInfo();

            value.Code                                      = GetInt32(new IntPtr(p + 0x010)); // 0270D6933258 0x10 Code                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
