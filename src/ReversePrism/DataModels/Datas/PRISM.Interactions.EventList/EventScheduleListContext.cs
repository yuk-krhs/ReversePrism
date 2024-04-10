using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 <IsNewEvent>k__BackingField              Func`2<IEventScheduleStatus, bool> IL2CPP_TYPE_GENERICINST
    // 040 <MarkEventAsRead>k__BackingField         Action`1<IEventScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 048 TextureLoader                            000186551C10 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
    public partial class EventScheduleListContext : DataModel
    {
        public WebTextureLoader?                        TextureLoader                           { get; set; }

        public static EventScheduleListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleListContext() { Pointer= p0 };

            value.TextureLoader                             = GetObject<WebTextureLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 02466BF35B40 0x48 TextureLoader               ( 000186551C10 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
