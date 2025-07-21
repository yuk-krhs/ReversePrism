using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedUnitIndex                        ModelPrimitiveType int int int Int32
    // 014 SpecialUnitCount                         ModelPrimitiveType int int int Int32
    // 018 SelectedUnitEditTabType                  ModelPrimitiveType int int int Int32
    public partial class LiveUnitEditPermanentData : DataModel
    {
        public int                                      SelectedUnitIndex                       { get; set; }
        public int                                      SpecialUnitCount                        { get; set; }
        public int                                      SelectedUnitEditTabType                 { get; set; }

        public static LiveUnitEditPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditPermanentData() { Pointer= p0 };

            value.SelectedUnitIndex                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 SelectedUnitIndex           ( ModelPrimitiveType int int int Int32 )
            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 SpecialUnitCount            ( ModelPrimitiveType int int int Int32 )
            value.SelectedUnitEditTabType                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 SelectedUnitEditTabType     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
