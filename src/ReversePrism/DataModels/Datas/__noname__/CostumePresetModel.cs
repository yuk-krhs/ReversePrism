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
    public partial class CostumePresetModel
    {
        public int                                      SelectedIndex                           { get; set; }
        public List<ICostumePresetStatus>?              Presets                                 { get; set; }
        public Action?                                  OnUpdateModel                           { get; set; }

        public static CostumePresetModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePresetModel();

            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0270DBC08E08 0x10 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Presets                                   = GetObjectList<ICostumePresetStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICostumePresetStatus.FromPointer); // 0270DBC08E28 0x18 Presets                     ( 000185CE1F18 ModelClassListType List`1<ICostumePresetStatus> List`1<ICostumePresetStatus> List<ICostumePresetStatus> Pointer )
            value.OnUpdateModel                             = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0270DBC08E48 0x20 OnUpdateModel               ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
