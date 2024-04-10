using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_VolumeTable                            000186589140 ModelClassType Table Table Table Pointer
    public partial class SettingsPanel : DataModel
    {
        public Table?                                   M_VolumeTable                           { get; set; }

        public static SettingsPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SettingsPanel() { Pointer= p0 };

            value.M_VolumeTable                             = GetObject<Table>(new IntPtr(p + 0x028), ReversePrism.DataModels.Table.FromPointer); // 0246691BB118 0x28 M_VolumeTable               ( 000186589140 ModelClassType Table Table Table Pointer )

            return value;
        }
    }
}
