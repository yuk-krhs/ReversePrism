using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_RequirementIndex                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 M_Requirements                           000185CBD388 ModelEnumListType DeviceRequirement[] DeviceRequirement[] List<DeviceRequirement> Pointer
    // 020 m_Controls                               InputControlList`1<InputControl> IL2CPP_TYPE_GENERICINST
    public partial class Match : DataModel
    {
        public int                                      M_RequirementIndex                      { get; set; }
        public List<DeviceRequirement>?                 M_Requirements                          { get; set; }

        public static Match? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Match() { Pointer= p0 };

            value.M_RequirementIndex                        = GetInt32(new IntPtr(p + 0x010)); // 024667712390 0x10 M_RequirementIndex          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_Requirements                            = GetEnumList<DeviceRequirement>(new IntPtr(p + 0x018)); // 0246677123B0 0x18 M_Requirements              ( 000185CBD388 ModelEnumListType DeviceRequirement[] DeviceRequirement[] List<DeviceRequirement> Pointer )

            return value;
        }
    }
}
