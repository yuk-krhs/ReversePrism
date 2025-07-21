using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 IsNetworkError                           ModelPrimitiveType bool bool bool Bool
    // 094 StatusCode                               ModelPrimitiveType int int int Int32
    // 098 Result                                   ModelEnumType RawResult RawResult RawResult Int32
    public partial class HttpException : DataModel
    {
        public bool                                     IsNetworkError                          { get; set; }
        public int                                      StatusCode                              { get; set; }
        public RawResult                                Result                                  { get; set; }

        public static HttpException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpException() { Pointer= p0 };

            value.IsNetworkError                            = GetBool(new IntPtr(p + 0x090)); // 0x90 IsNetworkError              ( ModelPrimitiveType bool bool bool Bool )
            value.StatusCode                                = GetInt32(new IntPtr(p + 0x094)); // 0x94 StatusCode                  ( ModelPrimitiveType int int int Int32 )
            value.Result                                    = (RawResult)GetInt32(new IntPtr(p + 0x098)); // 0x98 Result                      ( ModelEnumType RawResult RawResult RawResult Int32 )

            return value;
        }
    }
}
