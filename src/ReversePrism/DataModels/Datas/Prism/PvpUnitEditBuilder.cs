using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType PvpUnitEditView PvpUnitEditView PvpUnitEditView Pointer
    public partial class PvpUnitEditBuilder : DataModel
    {
        public PvpUnitEditView?                         View                                    { get; set; }

        public static PvpUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditBuilder() { Pointer= p0 };

            value.View                                      = GetObject<PvpUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpUnitEditView.FromPointer); // 0x20 View                        ( ModelClassType PvpUnitEditView PvpUnitEditView PvpUnitEditView Pointer )

            return value;
        }
    }
}
