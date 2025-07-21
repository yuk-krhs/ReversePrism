using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIndex                            ModelPrimitiveType int int int Int32
    // 018 Presets                                  ModelClassListType List`1<ICostumePresetStatus> List`1<ICostumePresetStatus> List<ICostumePresetStatus> Pointer
    // 020 OnUpdateModel                            ModelClassType Action Action Action Pointer
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

            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 SelectedIndex               ( ModelPrimitiveType int int int Int32 )
            value.Presets                                   = GetObjectList<ICostumePresetStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICostumePresetStatus.FromPointer); // 0x18 Presets                     ( ModelClassListType List`1<ICostumePresetStatus> List`1<ICostumePresetStatus> List<ICostumePresetStatus> Pointer )
            value.OnUpdateModel                             = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 OnUpdateModel               ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
