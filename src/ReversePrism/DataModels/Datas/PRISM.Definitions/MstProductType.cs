using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 UseCategoricalIcon                       ModelPrimitiveType bool bool bool Bool
    // 015 VisibleItem                              ModelPrimitiveType bool bool bool Bool
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.UseCategoricalIcon                        = GetBool(new IntPtr(p + 0x014)); // 0x14 UseCategoricalIcon          ( ModelPrimitiveType bool bool bool Bool )
            value.VisibleItem                               = GetBool(new IntPtr(p + 0x015)); // 0x15 VisibleItem                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
