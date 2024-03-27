using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865F6E00 ModelClassType PvpUnitEditView PvpUnitEditView PvpUnitEditView Pointer
    public partial class PvpUnitEditBuilder
    {
        public PvpUnitEditView?                         View                                    { get; set; }

        public static PvpUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditBuilder();

            value.View                                      = GetObject<PvpUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpUnitEditView.FromPointer); // 0270DB61F180 0x20 View                        ( 0001865F6E00 ModelClassType PvpUnitEditView PvpUnitEditView PvpUnitEditView Pointer )

            return value;
        }
    }
}
