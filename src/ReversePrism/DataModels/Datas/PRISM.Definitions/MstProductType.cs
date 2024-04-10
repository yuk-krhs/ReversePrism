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
    public partial class MstProductType : DataModel
    {
        public int                                      Id                                      { get; set; }
        public bool                                     UseCategoricalIcon                      { get; set; }
        public bool                                     VisibleItem                             { get; set; }

        public static MstProductType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProductType() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A470E088 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UseCategoricalIcon                        = GetBool(new IntPtr(p + 0x014)); // 0245A470E0A8 0x14 UseCategoricalIcon          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.VisibleItem                               = GetBool(new IntPtr(p + 0x015)); // 0245A470E0C8 0x15 VisibleItem                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
