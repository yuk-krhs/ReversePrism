using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_BindingGroup                           ModelPrimitiveType string string string String
    // 020 M_DeviceRequirements                     ModelEnumListType DeviceRequirement[] DeviceRequirement[] List<DeviceRequirement> Pointer
    public partial class InputControlScheme : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public string                                   M_BindingGroup                          { get; set; }
        public List<DeviceRequirement>?                 M_DeviceRequirements                    { get; set; }

        public static InputControlScheme? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputControlScheme() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_BindingGroup                            = GetString(new IntPtr(p + 0x018)); // 0x18 M_BindingGroup              ( ModelPrimitiveType string string string String )
            value.M_DeviceRequirements                      = GetEnumList<DeviceRequirement>(new IntPtr(p + 0x020)); // 0x20 M_DeviceRequirements        ( ModelEnumListType DeviceRequirement[] DeviceRequirement[] List<DeviceRequirement> Pointer )

            return value;
        }
    }
}
