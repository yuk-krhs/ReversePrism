using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 saveData                                 SavableJsonObject`1<EventListSaveData> IL2CPP_TYPE_GENERICINST
    // 018 View                                     ModelClassType IEventListButtonView IEventListButtonView IEventListButtonView Pointer
    public partial class EventListButtonPresenter : DataModel
    {
        public IEventListButtonView?                    View                                    { get; set; }

        public static EventListButtonPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListButtonPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IEventListButtonView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEventListButtonView.FromPointer); // 0x18 View                        ( ModelClassType IEventListButtonView IEventListButtonView IEventListButtonView Pointer )

            return value;
        }
    }
}
