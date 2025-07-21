using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 BindingGroup                             ModelPrimitiveType string string string String
    // 020 Devices                                  ModelEnumListType DeviceJson[] DeviceJson[] List<DeviceJson> Pointer
    public partial class SchemeJson : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   BindingGroup                            { get; set; }
        public List<DeviceJson>?                        Devices                                 { get; set; }

        public static SchemeJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemeJson() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.BindingGroup                              = GetString(new IntPtr(p + 0x018)); // 0x18 BindingGroup                ( ModelPrimitiveType string string string String )
            value.Devices                                   = GetEnumList<DeviceJson>(new IntPtr(p + 0x020)); // 0x20 Devices                     ( ModelEnumListType DeviceJson[] DeviceJson[] List<DeviceJson> Pointer )

            return value;
        }
    }
}
