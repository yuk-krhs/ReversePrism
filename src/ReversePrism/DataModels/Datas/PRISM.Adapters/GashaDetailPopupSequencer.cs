using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GashaDetailTabSave                       ModelClassType GashaDetailsTabSave GashaDetailsTabSave GashaDetailsTabSave Pointer
    public partial class GashaDetailPopupSequencer : DataModel
    {
        public GashaDetailsTabSave?                     GashaDetailTabSave                      { get; set; }

        public static GashaDetailPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailPopupSequencer() { Pointer= p0 };

            value.GashaDetailTabSave                        = GetObject<GashaDetailsTabSave>(new IntPtr(p + 0x010), ReversePrism.DataModels.GashaDetailsTabSave.FromPointer); // 0x10 GashaDetailTabSave          ( ModelClassType GashaDetailsTabSave GashaDetailsTabSave GashaDetailsTabSave Pointer )

            return value;
        }
    }
}
