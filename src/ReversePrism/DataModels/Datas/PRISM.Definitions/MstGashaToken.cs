using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 SortId                                   ModelPrimitiveType int int int Int32
    public partial class MstGashaToken : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      SortId                                  { get; set; }

        public static MstGashaToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGashaToken() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
