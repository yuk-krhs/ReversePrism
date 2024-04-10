using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _items                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 018 Size                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
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

            value.Size                                      = GetInt32(new IntPtr(p + 0x018)); // 0245A4D40268 0x18 Size                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0245A4D40288 0x1C Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
