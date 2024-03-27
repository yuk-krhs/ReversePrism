using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Value                                    000186671BA0 ModelPrimitiveType string string string String
    public partial class BinaryObjectString
    {
        public int                                      ObjectId                                { get; set; }
        public string                                   Value                                   { get; set; }

        public static BinaryObjectString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryObjectString();

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D6C31C68 0x10 ObjectId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0270D6C31C88 0x18 Value                       ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
