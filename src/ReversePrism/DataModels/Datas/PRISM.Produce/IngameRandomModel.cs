using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Seed                                     ModelPrimitiveType int int int Int32
    public partial class IngameRandomModel : DataModel
    {
        public int                                      Seed                                    { get; set; }

        public static IngameRandomModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameRandomModel() { Pointer= p0 };

            value.Seed                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Seed                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
