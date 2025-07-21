using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 SelectModel                              ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer
    // 098 SelectedFesUnitId                        ModelPrimitiveType string string string String
    // 0A0 OnDecide                                 Action`1<string> IL2CPP_TYPE_GENERICINST
    public partial class SelectInheritanceFUPopupContentPopupParam : DataModel
    {
        public FesUnitSelectModel?                      SelectModel                             { get; set; }
        public string                                   SelectedFesUnitId                       { get; set; }

        public static SelectInheritanceFUPopupContentPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectInheritanceFUPopupContentPopupParam() { Pointer= p0 };

            value.SelectModel                               = GetObject<FesUnitSelectModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.FesUnitSelectModel.FromPointer); // 0x90 SelectModel                 ( ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer )
            value.SelectedFesUnitId                         = GetString(new IntPtr(p + 0x098)); // 0x98 SelectedFesUnitId           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
