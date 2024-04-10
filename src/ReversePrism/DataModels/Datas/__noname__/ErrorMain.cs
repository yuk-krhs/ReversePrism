using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Code                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Message                                  000186671910 ModelPrimitiveType string string string String
    // 020 Details                                  000185D32118 ModelClassListType List`1<ErrorDetail> List`1<ErrorDetail> List<ErrorDetail> Pointer
    public partial class ErrorMain : DataModel
    {
        public int                                      Code                                    { get; set; }
        public string                                   Message                                 { get; set; }
        public List<ErrorDetail>?                       Details                                 { get; set; }

        public static ErrorMain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorMain() { Pointer= p0 };

            value.Code                                      = GetInt32(new IntPtr(p + 0x010)); // 02466B508EE0 0x10 Code                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 02466B508F00 0x18 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Details                                   = GetObjectList<ErrorDetail>(new IntPtr(p + 0x020), ReversePrism.DataModels.ErrorDetail.FromPointer); // 02466B508F20 0x20 Details                     ( 000185D32118 ModelClassListType List`1<ErrorDetail> List`1<ErrorDetail> List<ErrorDetail> Pointer )

            return value;
        }
    }
}
