using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018652B800 ModelClassType ProduceAutoModeView ProduceAutoModeView ProduceAutoModeView Pointer
    public partial class ProduceAutoModeBuilder
    {
        public ProduceAutoModeView?                     View                                    { get; set; }

        public static ProduceAutoModeBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoModeBuilder();

            value.View                                      = GetObject<ProduceAutoModeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceAutoModeView.FromPointer); // 0270DB61E4B8 0x20 View                        ( 00018652B800 ModelClassType ProduceAutoModeView ProduceAutoModeView ProduceAutoModeView Pointer )

            return value;
        }
    }
}
