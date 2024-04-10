using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class PropertyName : DataModel
    {
        public int                                      Id                                      { get; set; }

        public static PropertyName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyName() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A242E238 0x10 Id                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
