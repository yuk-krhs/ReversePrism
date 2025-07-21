using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _items                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 018 Size                                     ModelPrimitiveType int int int Int32
    // 01C Version                                  ModelPrimitiveType int int int Int32
    // 020 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    // 000 _defaultCapacity                         int IL2CPP_TYPE_I4
    // 000 MaxArrayLength                           int IL2CPP_TYPE_I4
    public partial class ArrayList : DataModel
    {
        public int                                      Size                                    { get; set; }
        public int                                      Version                                 { get; set; }

        public static ArrayList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayList() { Pointer= p0 };

            value.Size                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Size                        ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
