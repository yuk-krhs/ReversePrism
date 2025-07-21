using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 StackallocIntBufferSizeLimit             int IL2CPP_TYPE_I4
    // 000 PROBABILISTICMAP_BLOCK_INDEX_MASK        int IL2CPP_TYPE_I4
    // 000 PROBABILISTICMAP_BLOCK_INDEX_SHIFT       int IL2CPP_TYPE_I4
    // 000 PROBABILISTICMAP_SIZE                    int IL2CPP_TYPE_I4
    // 010 StringLength                             ModelPrimitiveType int int int Int32
    // 014 _firstChar                               char IL2CPP_TYPE_CHAR
    // 000 Empty                                    string IL2CPP_TYPE_STRING
    public partial class String : DataModel
    {
        public int                                      StringLength                            { get; set; }

        public static String? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new String() { Pointer= p0 };

            value.StringLength                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 StringLength                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
