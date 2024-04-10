using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SettingUIs                               000185B99060 ModelClassListType OptionSettingBase[] OptionSettingBase[] List<OptionSettingBase> Pointer
    // 040 CurrentInActiveTab                       0001866E7FB0 ModelClassType OptionSettingBase OptionSettingBase OptionSettingBase Pointer
    public partial class OptionSettingsGroup : DataModel
    {
        public List<OptionSettingBase>?                 SettingUIs                              { get; set; }
        public OptionSettingBase?                       CurrentInActiveTab                      { get; set; }

        public static OptionSettingsGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionSettingsGroup() { Pointer= p0 };

            value.SettingUIs                                = GetObjectList<OptionSettingBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.OptionSettingBase.FromPointer); // 024664C6BFD0 0x38 SettingUIs                  ( 000185B99060 ModelClassListType OptionSettingBase[] OptionSettingBase[] List<OptionSettingBase> Pointer )
            value.CurrentInActiveTab                        = GetObject<OptionSettingBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.OptionSettingBase.FromPointer); // 024664C6BFF0 0x40 CurrentInActiveTab          ( 0001866E7FB0 ModelClassType OptionSettingBase OptionSettingBase OptionSettingBase Pointer )

            return value;
        }
    }
}
