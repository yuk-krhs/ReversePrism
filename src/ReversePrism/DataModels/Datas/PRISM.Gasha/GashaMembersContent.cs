using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 GashaMembersView                         ModelClassType GashaMembersView GashaMembersView GashaMembersView Pointer
    public partial class GashaMembersContent : DataModel
    {
        public GashaMembersView?                        GashaMembersView                        { get; set; }

        public static GashaMembersContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaMembersContent() { Pointer= p0 };

            value.GashaMembersView                          = GetObject<GashaMembersView>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaMembersView.FromPointer); // 0x60 GashaMembersView            ( ModelClassType GashaMembersView GashaMembersView GashaMembersView Pointer )

            return value;
        }
    }
}
