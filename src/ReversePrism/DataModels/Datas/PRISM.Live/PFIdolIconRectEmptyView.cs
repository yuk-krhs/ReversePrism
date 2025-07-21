using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 PositionMarks                            ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class PFIdolIconRectEmptyView : DataModel
    {
        public ButtonBase?                              Button                                  { get; set; }
        public List<GameObject>?                        PositionMarks                           { get; set; }

        public static PFIdolIconRectEmptyView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolIconRectEmptyView() { Pointer= p0 };

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 Button                      ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PositionMarks                             = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 PositionMarks               ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
