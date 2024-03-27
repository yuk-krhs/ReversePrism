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
    public partial class OptionSettingsGroup
    {
        public List<OptionSettingBase>?                 SettingUIs                              { get; set; }
        public OptionSettingBase?                       CurrentInActiveTab                      { get; set; }

        public static OptionSettingsGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionSettingsGroup();

            value.SettingUIs                                = GetObjectList<OptionSettingBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.OptionSettingBase.FromPointer); // 0270D4C08EA8 0x38 SettingUIs                  ( 000185B99060 ModelClassListType OptionSettingBase[] OptionSettingBase[] List<OptionSettingBase> Pointer )
            value.CurrentInActiveTab                        = GetObject<OptionSettingBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.OptionSettingBase.FromPointer); // 0270D4C08EC8 0x40 CurrentInActiveTab          ( 0001866E7FB0 ModelClassType OptionSettingBase OptionSettingBase OptionSettingBase Pointer )

            return value;
        }
    }
}
