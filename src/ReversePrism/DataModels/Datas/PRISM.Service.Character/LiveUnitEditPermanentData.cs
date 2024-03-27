using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedUnitIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 SpecialUnitCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SelectedUnitEditTabType                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveUnitEditPermanentData
    {
        public int                                      SelectedUnitIndex                       { get; set; }
        public int                                      SpecialUnitCount                        { get; set; }
        public int                                      SelectedUnitEditTabType                 { get; set; }

        public static LiveUnitEditPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditPermanentData();

            value.SelectedUnitIndex                         = GetInt32(new IntPtr(p + 0x010)); // 027003A6AF10 0x10 SelectedUnitIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x014)); // 027003A6AF30 0x14 SpecialUnitCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedUnitEditTabType                   = GetInt32(new IntPtr(p + 0x018)); // 027003A6AF50 0x18 SelectedUnitEditTabType     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
