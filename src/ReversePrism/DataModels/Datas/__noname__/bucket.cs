using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 key                                      <object> IL2CPP_TYPE_OBJECT
    // 018 val                                      <object> IL2CPP_TYPE_OBJECT
    // 020 Hash_coll                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class bucket : DataModel
    {
        public int                                      Hash_coll                               { get; set; }

        public static bucket? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bucket() { Pointer= p0 };

            value.Hash_coll                                 = GetInt32(new IntPtr(p + 0x020)); // 0245A34035F0 0x20 Hash_coll                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
