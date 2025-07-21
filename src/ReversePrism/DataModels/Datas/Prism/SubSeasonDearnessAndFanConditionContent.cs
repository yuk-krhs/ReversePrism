using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ConditionCheckMarkOn                     ModelClassType GameObject GameObject GameObject Pointer
    // 028 ConditionCheckMarkOff                    ModelClassType GameObject GameObject GameObject Pointer
    // 030 ConditionText                            ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    public partial class SubSeasonDearnessAndFanConditionContent : DataModel
    {
        public GameObject?                              ConditionCheckMarkOn                    { get; set; }
        public GameObject?                              ConditionCheckMarkOff                   { get; set; }
        public TextMeshProUGUI?                         ConditionText                           { get; set; }

        public static SubSeasonDearnessAndFanConditionContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDearnessAndFanConditionContent() { Pointer= p0 };

            value.ConditionCheckMarkOn                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ConditionCheckMarkOn        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ConditionCheckMarkOff                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ConditionCheckMarkOff       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ConditionText                             = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 ConditionText               ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )

            return value;
        }
    }
}
