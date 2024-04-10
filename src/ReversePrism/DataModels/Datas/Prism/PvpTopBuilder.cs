using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865F51D0 ModelClassType PvpTopView PvpTopView PvpTopView Pointer
    public partial class PvpTopBuilder : DataModel
    {
        public PvpTopView?                              View                                    { get; set; }

        public static PvpTopBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpTopBuilder() { Pointer= p0 };

            value.View                                      = GetObject<PvpTopView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpTopView.FromPointer); // 02466B6B2948 0x20 View                        ( 0001865F51D0 ModelClassType PvpTopView PvpTopView PvpTopView Pointer )

            return value;
        }
    }
}
