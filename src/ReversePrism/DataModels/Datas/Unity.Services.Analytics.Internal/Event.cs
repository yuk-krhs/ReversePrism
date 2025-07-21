using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parameters                               ModelClassType EventData EventData EventData Pointer
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 <Version>k__BackingField                 Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class Event : DataModel
    {
        public EventData?                               Parameters                              { get; set; }
        public string                                   Name                                    { get; set; }

        public static Event? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Event() { Pointer= p0 };

            value.Parameters                                = GetObject<EventData>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventData.FromPointer); // 0x10 Parameters                  ( ModelClassType EventData EventData EventData Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
