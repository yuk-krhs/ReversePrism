using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ByteCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 IncludeLength                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class BsonString
    {
        public int                                      ByteCount                               { get; set; }
        public bool                                     IncludeLength                           { get; set; }

        public static BsonString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonString();

            value.ByteCount                                 = GetInt32(new IntPtr(p + 0x030)); // 0270D889AAC8 0x30 ByteCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IncludeLength                             = GetBool(new IntPtr(p + 0x034)); // 0270D889AAE8 0x34 IncludeLength               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
