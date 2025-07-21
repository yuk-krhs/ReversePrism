using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParentHash                               ModelPrimitiveType int int int Int32
    // 014 Hash                                     ModelPrimitiveType int int int Int32
    public partial class HashPair : DataModel
    {
        public int                                      ParentHash                              { get; set; }
        public int                                      Hash                                    { get; set; }

        public static HashPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HashPair() { Pointer= p0 };

            value.ParentHash                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 ParentHash                  ( ModelPrimitiveType int int int Int32 )
            value.Hash                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Hash                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
