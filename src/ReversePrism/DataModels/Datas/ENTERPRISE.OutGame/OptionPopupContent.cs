using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 OptionData                               ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer
    // 068 TabGroup                                 ModelClassType OptionSettingsGroup OptionSettingsGroup OptionSettingsGroup Pointer
    public partial class OptionPopupContent : DataModel
    {
        public OptionLocalSave?                         OptionData                              { get; set; }
        public OptionSettingsGroup?                     TabGroup                                { get; set; }

        public static OptionPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionPopupContent() { Pointer= p0 };

            value.OptionData                                = GetObject<OptionLocalSave>(new IntPtr(p + 0x060), ReversePrism.DataModels.OptionLocalSave.FromPointer); // 0x60 OptionData                  ( ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer )
            value.TabGroup                                  = GetObject<OptionSettingsGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.OptionSettingsGroup.FromPointer); // 0x68 TabGroup                    ( ModelClassType OptionSettingsGroup OptionSettingsGroup OptionSettingsGroup Pointer )

            return value;
        }
    }
}
