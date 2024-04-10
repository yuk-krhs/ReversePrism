using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer
    public partial class OnScrollSender : DataModel
    {
        public Scroller?                                Scroller                                { get; set; }

        public static OnScrollSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnScrollSender() { Pointer= p0 };

            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.Scroller.FromPointer); // 0246654F7FA0 0x20 Scroller                    ( 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer )

            return value;
        }
    }
}
