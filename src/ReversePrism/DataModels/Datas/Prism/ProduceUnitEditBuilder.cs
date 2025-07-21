using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ProduceUnitEditView ProduceUnitEditView ProduceUnitEditView Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    public partial class ProduceUnitEditBuilder : DataModel
    {
        public ProduceUnitEditView?                     View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }

        public static ProduceUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceUnitEditView.FromPointer); // 0x20 View                        ( ModelClassType ProduceUnitEditView ProduceUnitEditView ProduceUnitEditView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )

            return value;
        }
    }
}
