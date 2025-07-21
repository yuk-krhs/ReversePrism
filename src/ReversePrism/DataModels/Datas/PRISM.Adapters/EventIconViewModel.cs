using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventIcon                                ModelClassType IEventIconStatus IEventIconStatus IEventIconStatus Pointer
    public partial class EventIconViewModel : DataModel
    {
        public IEventIconStatus?                        EventIcon                               { get; set; }

        public static EventIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventIconViewModel() { Pointer= p0 };

            value.EventIcon                                 = GetObject<IEventIconStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEventIconStatus.FromPointer); // 0x10 EventIcon                   ( ModelClassType IEventIconStatus IEventIconStatus IEventIconStatus Pointer )

            return value;
        }
    }
}
