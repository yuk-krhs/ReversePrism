using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Level                                    ModelPrimitiveType int int int Int32
    // 014 Index                                    ModelPrimitiveType int int int Int32
    public partial class BuddyAllocation : DataModel
    {
        public int                                      Level                                   { get; set; }
        public int                                      Index                                   { get; set; }

        public static BuddyAllocation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuddyAllocation() { Pointer= p0 };

            value.Level                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Level                       ( ModelPrimitiveType int int int Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
