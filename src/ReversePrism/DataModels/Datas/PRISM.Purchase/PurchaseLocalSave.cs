using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OrderIds                                 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 OrderKeys                                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 OrderInfoDict                            Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class PurchaseLocalSave : DataModel
    {
        public List<string>?                            OrderIds                                { get; set; }
        public List<string>?                            OrderKeys                               { get; set; }

        public static PurchaseLocalSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseLocalSave() { Pointer= p0 };

            value.OrderIds                                  = GetStringList(new IntPtr(p + 0x020)); // 0245A3A88328 0x20 OrderIds                    ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OrderKeys                                 = GetStringList(new IntPtr(p + 0x028)); // 0245A3A88348 0x28 OrderKeys                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
