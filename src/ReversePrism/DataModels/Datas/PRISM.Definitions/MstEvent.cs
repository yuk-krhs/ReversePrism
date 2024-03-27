using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 EventType                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstUnitId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 020 BeginDate                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 EndDate                                  0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstEvent
    {
        public int                                      Id                                      { get; set; }
        public int                                      EventType                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static MstEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstEvent();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270046455F0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventType                                 = GetInt32(new IntPtr(p + 0x014)); // 027004645610 0x14 EventType                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 027004645630 0x18 MstUnitId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 027004645650 0x20 BeginDate                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 027004645670 0x28 EndDate                     ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
