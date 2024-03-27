using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 objects                                  <object>[] IL2CPP_TYPE_SZARRAY
    // 018 StackId                                  000186671BA0 ModelPrimitiveType string string string String
    // 020 Top                                      0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class SerStack
    {
        public string                                   StackId                                 { get; set; }
        public int                                      Top                                     { get; set; }

        public static SerStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerStack();

            value.StackId                                   = GetString(new IntPtr(p + 0x018)); // 0270D6C54840 0x18 StackId                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Top                                       = GetInt32(new IntPtr(p + 0x020)); // 0270D6C54860 0x20 Top                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
