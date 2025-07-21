using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Result                                 ModelEnumType Result Result Result Int32
    // 014 M_Score                                  ModelPrimitiveType float float float Single
    // 018 m_Devices                                InputControlList`1<InputDevice> IL2CPP_TYPE_GENERICINST
    // 038 m_Controls                               InputControlList`1<InputControl> IL2CPP_TYPE_GENERICINST
    // 058 M_Requirements                           ModelEnumListType DeviceRequirement[] DeviceRequirement[] List<DeviceRequirement> Pointer
    public partial class MatchResult : DataModel
    {
        public Result                                   M_Result                                { get; set; }
        public float                                    M_Score                                 { get; set; }
        public List<DeviceRequirement>?                 M_Requirements                          { get; set; }

        public static MatchResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatchResult() { Pointer= p0 };

            value.M_Result                                  = (Result)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Result                    ( ModelEnumType Result Result Result Int32 )
            value.M_Score                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_Score                     ( ModelPrimitiveType float float float Single )
            value.M_Requirements                            = GetEnumList<DeviceRequirement>(new IntPtr(p + 0x058)); // 0x58 M_Requirements              ( ModelEnumListType DeviceRequirement[] DeviceRequirement[] List<DeviceRequirement> Pointer )

            return value;
        }
    }
}
