using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   0001865F3110 ModelEnumType Action Action Action Int32
    // 018 TypeName                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class Event
    {
        public Action                                   Action                                  { get; set; }
        public string                                   TypeName                                { get; set; }

        public static Event? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Event();

            value.Action                                    = (Action)GetInt32(new IntPtr(p + 0x010)); // 0270D9C601E0 0x10 Action                      ( 0001865F3110 ModelEnumType Action Action Action Int32 )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 0270D9C60200 0x18 TypeName                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
