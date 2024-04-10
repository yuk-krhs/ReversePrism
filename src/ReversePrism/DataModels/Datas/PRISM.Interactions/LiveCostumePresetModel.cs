using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Presets                                  000185CE1F18 ModelClassListType List`1<ICostumePresetStatus> List`1<ICostumePresetStatus> List<ICostumePresetStatus> Pointer
    // 020 OnUpdateModel                            000186679A00 ModelClassType Action Action Action Pointer
    public partial class LiveCostumePresetModel : DataModel
    {
        public int                                      SelectedIndex                           { get; set; }
        public List<ICostumePresetStatus>?              Presets                                 { get; set; }
        public Action?                                  OnUpdateModel                           { get; set; }

        public static LiveCostumePresetModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumePresetModel() { Pointer= p0 };

            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x010)); // 02466B45B280 0x10 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Presets                                   = GetObjectList<ICostumePresetStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICostumePresetStatus.FromPointer); // 02466B45B2A0 0x18 Presets                     ( 000185CE1F18 ModelClassListType List`1<ICostumePresetStatus> List`1<ICostumePresetStatus> List<ICostumePresetStatus> Pointer )
            value.OnUpdateModel                             = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 02466B45B2C0 0x20 OnUpdateModel               ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
