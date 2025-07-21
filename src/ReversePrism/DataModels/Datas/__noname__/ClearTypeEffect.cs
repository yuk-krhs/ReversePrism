using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Effects                                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 018 DigitViews                               ModelClassListType ComboDigitView[] ComboDigitView[] List<ComboDigitView> Pointer
    public partial class ClearTypeEffect : DataModel
    {
        public List<GameObject>?                        Effects                                 { get; set; }
        public List<ComboDigitView>?                    DigitViews                              { get; set; }

        public static ClearTypeEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClearTypeEffect() { Pointer= p0 };

            value.Effects                                   = GetObjectList<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 Effects                     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.DigitViews                                = GetObjectList<ComboDigitView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ComboDigitView.FromPointer); // 0x18 DigitViews                  ( ModelClassListType ComboDigitView[] ComboDigitView[] List<ComboDigitView> Pointer )

            return value;
        }
    }
}
