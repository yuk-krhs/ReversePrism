using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 EventType                                ModelPrimitiveType int int int Int32
    // 018 MstUnitId                                ModelPrimitiveType int int int Int32
    // 020 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 EndDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstEvent : DataModel
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
            var value   = new MstEvent() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.EventType                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 EventType                   ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0x20 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0x28 EndDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
