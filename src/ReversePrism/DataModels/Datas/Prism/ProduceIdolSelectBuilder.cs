using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018654D070 ModelClassType ProduceIdolSelectView ProduceIdolSelectView ProduceIdolSelectView Pointer
    public partial class ProduceIdolSelectBuilder : DataModel
    {
        public ProduceIdolSelectView?                   View                                    { get; set; }

        public static ProduceIdolSelectBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSelectBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceIdolSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolSelectView.FromPointer); // 02466B6B2618 0x20 View                        ( 00018654D070 ModelClassType ProduceIdolSelectView ProduceIdolSelectView ProduceIdolSelectView Pointer )

            return value;
        }
    }
}
