using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 028 ModeViews                                ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 backgroundModes                          IList`1<LiveBackgroundMode> IL2CPP_TYPE_GENERICINST
    // 038 onBackOnModeChanged                      Subject`1<LiveBackgroundMode> IL2CPP_TYPE_GENERICINST
    public partial class LiveBackgroundModeSelector : DataModel
    {
        public ClickNumberCountedButton?                Button                                  { get; set; }
        public List<GameObject>?                        ModeViews                               { get; set; }

        public static LiveBackgroundModeSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveBackgroundModeSelector() { Pointer= p0 };

            value.Button                                    = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0x20 Button                      ( ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.ModeViews                                 = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ModeViews                   ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
