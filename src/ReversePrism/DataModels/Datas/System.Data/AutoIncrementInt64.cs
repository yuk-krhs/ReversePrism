using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Current                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 020 Seed                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 028 Step                                     0001865F7700 ModelPrimitiveType long long long Int64
    public partial class AutoIncrementInt64 : DataModel
    {
        public long                                     Current                                 { get; set; }
        public long                                     Seed                                    { get; set; }
        public long                                     Step                                    { get; set; }

        public static AutoIncrementInt64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoIncrementInt64() { Pointer= p0 };

            value.Current                                   = GetInt64(new IntPtr(p + 0x018)); // 024668922B40 0x18 Current                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Seed                                      = GetInt64(new IntPtr(p + 0x020)); // 024668922B60 0x20 Seed                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Step                                      = GetInt64(new IntPtr(p + 0x028)); // 024668922B80 0x28 Step                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
