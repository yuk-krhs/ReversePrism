using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rc                                       ModelPrimitiveType int int int Int32
    // 018 Body                                     ModelPrimitiveType string string string String
    // 020 Headers                                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class MakeRequestResult : DataModel
    {
        public int                                      Rc                                      { get; set; }
        public string                                   Body                                    { get; set; }

        public static MakeRequestResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MakeRequestResult() { Pointer= p0 };

            value.Rc                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rc                          ( ModelPrimitiveType int int int Int32 )
            value.Body                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Body                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
