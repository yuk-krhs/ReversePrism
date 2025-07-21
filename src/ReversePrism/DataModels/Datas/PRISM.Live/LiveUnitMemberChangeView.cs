using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SwitchDisplayButton                      ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 040 switchDisplaySubject                     Subject`1<LiveIdolIconStatusDisplayType> IL2CPP_TYPE_GENERICINST
    // 048 SaveData                                 ModelClassType UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData Pointer
    public partial class LiveUnitMemberChangeView : DataModel
    {
        public ClickNumberCountedButton?                SwitchDisplayButton                     { get; set; }
        public UnitMemberChangeViewSaveData?            SaveData                                { get; set; }

        public static LiveUnitMemberChangeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitMemberChangeView() { Pointer= p0 };

            value.SwitchDisplayButton                       = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0x38 SwitchDisplayButton         ( ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.SaveData                                  = GetObject<UnitMemberChangeViewSaveData>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitMemberChangeViewSaveData.FromPointer); // 0x48 SaveData                    ( ModelClassType UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData Pointer )

            return value;
        }
    }
}
