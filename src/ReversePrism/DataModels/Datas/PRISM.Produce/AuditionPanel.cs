using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0D0 ProduceTopMenuCaller                     00018658A730 ModelClassType ProduceTopMenuCaller ProduceTopMenuCaller ProduceTopMenuCaller Pointer
    public partial class AuditionPanel : DataModel
    {
        public ProduceTopMenuCaller?                    ProduceTopMenuCaller                    { get; set; }

        public static AuditionPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionPanel() { Pointer= p0 };

            value.ProduceTopMenuCaller                      = GetObject<ProduceTopMenuCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ProduceTopMenuCaller.FromPointer); // 024665A0CA98 0xD0 ProduceTopMenuCaller        ( 00018658A730 ModelClassType ProduceTopMenuCaller ProduceTopMenuCaller ProduceTopMenuCaller Pointer )

            return value;
        }
    }
}
