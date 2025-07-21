using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Store                                    ModelPrimitiveType string string string String
    // 018 Id                                       ModelPrimitiveType string string string String
    public partial class StoreID : DataModel
    {
        public string                                   Store                                   { get; set; }
        public string                                   Id                                      { get; set; }

        public static StoreID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreID() { Pointer= p0 };

            value.Store                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Store                       ( ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
