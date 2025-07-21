using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelEnumType InitializeResult InitializeResult InitializeResult Int32
    // 018 Error                                    ModelClassType Error Error Error Pointer
    public partial class InitializeData : DataModel
    {
        public InitializeResult                         Status                                  { get; set; }
        public Error?                                   Error                                   { get; set; }

        public static InitializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitializeData() { Pointer= p0 };

            value.Status                                    = (InitializeResult)GetInt32(new IntPtr(p + 0x010)); // 0x10 Status                      ( ModelEnumType InitializeResult InitializeResult InitializeResult Int32 )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x018), ReversePrism.DataModels.Error.FromPointer); // 0x18 Error                       ( ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
