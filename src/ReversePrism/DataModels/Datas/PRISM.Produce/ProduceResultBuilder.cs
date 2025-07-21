using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ProduceResultView ProduceResultView ProduceResultView Pointer
    public partial class ProduceResultBuilder : DataModel
    {
        public ProduceResultView?                       View                                    { get; set; }

        public static ProduceResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceResultView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceResultView.FromPointer); // 0x20 View                        ( ModelClassType ProduceResultView ProduceResultView ProduceResultView Pointer )

            return value;
        }
    }
}
