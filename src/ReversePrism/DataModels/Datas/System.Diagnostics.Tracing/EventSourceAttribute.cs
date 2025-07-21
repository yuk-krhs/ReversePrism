using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Guid                                     ModelPrimitiveType string string string String
    // 018 Name                                     ModelPrimitiveType string string string String
    public partial class EventSourceAttribute : DataModel
    {
        public string                                   Guid                                    { get; set; }
        public string                                   Name                                    { get; set; }

        public static EventSourceAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventSourceAttribute() { Pointer= p0 };

            value.Guid                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Guid                        ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
