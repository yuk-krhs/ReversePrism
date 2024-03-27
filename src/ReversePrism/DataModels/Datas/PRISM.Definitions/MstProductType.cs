using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 UseCategoricalIcon                       0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 015 VisibleItem                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class MstProductType
    {
        public int                                      Id                                      { get; set; }
        public bool                                     UseCategoricalIcon                      { get; set; }
        public bool                                     VisibleItem                             { get; set; }

        public static MstProductType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProductType();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004692610 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UseCategoricalIcon                        = GetBool(new IntPtr(p + 0x014)); // 027004692630 0x14 UseCategoricalIcon          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.VisibleItem                               = GetBool(new IntPtr(p + 0x015)); // 027004692650 0x15 VisibleItem                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
