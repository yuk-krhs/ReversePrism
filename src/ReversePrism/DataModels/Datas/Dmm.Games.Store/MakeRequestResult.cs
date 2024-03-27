using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rc                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Body                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 Headers                                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class MakeRequestResult
    {
        public int                                      Rc                                      { get; set; }
        public string                                   Body                                    { get; set; }

        public static MakeRequestResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MakeRequestResult();

            value.Rc                                        = GetInt32(new IntPtr(p + 0x010)); // 0270DB4C1708 0x10 Rc                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Body                                      = GetString(new IntPtr(p + 0x018)); // 0270DB4C1728 0x18 Body                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
