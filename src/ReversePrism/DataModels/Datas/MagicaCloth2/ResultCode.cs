using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Result                                   ModelEnumType Result Result Result Int32
    // 014 Warning                                  ModelEnumType Result Result Result Int32
    public partial class ResultCode : DataModel
    {
        public Result                                   Result                                  { get; set; }
        public Result                                   Warning                                 { get; set; }

        public static ResultCode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResultCode() { Pointer= p0 };

            value.Result                                    = (Result)GetInt32(new IntPtr(p + 0x010)); // 0x10 Result                      ( ModelEnumType Result Result Result Int32 )
            value.Warning                                   = (Result)GetInt32(new IntPtr(p + 0x014)); // 0x14 Warning                     ( ModelEnumType Result Result Result Int32 )

            return value;
        }
    }
}
