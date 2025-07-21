using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 ScheduleSelectionType                    ModelPrimitiveType int int int Int32
    // 018 Order                                    ModelPrimitiveType int int int Int32
    public partial class MstScheduleType : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      ScheduleSelectionType                   { get; set; }
        public int                                      Order                                   { get; set; }

        public static MstScheduleType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstScheduleType() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.ScheduleSelectionType                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 ScheduleSelectionType       ( ModelPrimitiveType int int int Int32 )
            value.Order                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Order                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
