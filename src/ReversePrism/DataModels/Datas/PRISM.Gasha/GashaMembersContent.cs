using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 GashaMembersView                         000186607750 ModelClassType GashaMembersView GashaMembersView GashaMembersView Pointer
    public partial class GashaMembersContent
    {
        public GashaMembersView?                        GashaMembersView                        { get; set; }

        public static GashaMembersContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaMembersContent();

            value.GashaMembersView                          = GetObject<GashaMembersView>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaMembersView.FromPointer); // 0270D530A708 0x60 GashaMembersView            ( 000186607750 ModelClassType GashaMembersView GashaMembersView GashaMembersView Pointer )

            return value;
        }
    }
}
