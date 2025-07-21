using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ProduceConfirmView ProduceConfirmView ProduceConfirmView Pointer
    public partial class ProduceConfirmBuilder : DataModel
    {
        public ProduceConfirmView?                      View                                    { get; set; }

        public static ProduceConfirmBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceConfirmView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceConfirmView.FromPointer); // 0x20 View                        ( ModelClassType ProduceConfirmView ProduceConfirmView ProduceConfirmView Pointer )

            return value;
        }
    }
}
