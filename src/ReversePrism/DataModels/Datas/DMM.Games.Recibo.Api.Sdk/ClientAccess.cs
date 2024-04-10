using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 AppId                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C UserId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ClientAccess : DataModel
    {
        public int                                      AppId                                   { get; set; }
        public int                                      UserId                                  { get; set; }

        public static ClientAccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientAccess() { Pointer= p0 };

            value.AppId                                     = GetInt32(new IntPtr(p + 0x038)); // 0245A4D95808 0x38 AppId                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetInt32(new IntPtr(p + 0x03C)); // 0245A4D95828 0x3C UserId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
