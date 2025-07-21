using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultCharacterID                       ModelPrimitiveType int int int Int32
    // 018 Events                                   ModelClassListType AnimEvent[] AnimEvent[] List<AnimEvent> Pointer
    public partial class AnimEvents : DataModel
    {
        public int                                      DefaultCharacterID                      { get; set; }
        public List<AnimEvent>?                         Events                                  { get; set; }

        public static AnimEvents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimEvents() { Pointer= p0 };

            value.DefaultCharacterID                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 DefaultCharacterID          ( ModelPrimitiveType int int int Int32 )
            value.Events                                    = GetObjectList<AnimEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimEvent.FromPointer); // 0x18 Events                      ( ModelClassListType AnimEvent[] AnimEvent[] List<AnimEvent> Pointer )

            return value;
        }
    }
}
