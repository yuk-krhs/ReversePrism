using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnceDisplayed                            000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 <OnceDisplayed>k__BackingField           HashSet`1<string> IL2CPP_TYPE_GENERICINST
    public partial class HowToPlayPopupSaveData : DataModel
    {
        public List<string>?                            OnceDisplayed                           { get; set; }

        public static HowToPlayPopupSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayPopupSaveData() { Pointer= p0 };

            value.OnceDisplayed                             = GetStringList(new IntPtr(p + 0x020)); // 0245A3A7C570 0x20 OnceDisplayed               ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
