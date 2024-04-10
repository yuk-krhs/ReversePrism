using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scenario                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 Data                                     0001865BA230 ModelEnumType PerScenarioData PerScenarioData PerScenarioData Int32
    public partial class SerializablePerScenarioDataItem : DataModel
    {
        public string                                   Scenario                                { get; set; }
        public PerScenarioData                          Data                                    { get; set; }

        public static SerializablePerScenarioDataItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializablePerScenarioDataItem() { Pointer= p0 };

            value.Scenario                                  = GetString(new IntPtr(p + 0x010)); // 02466927D888 0x10 Scenario                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Data                                      = (PerScenarioData)GetInt32(new IntPtr(p + 0x018)); // 02466927D8A8 0x18 Data                        ( 0001865BA230 ModelEnumType PerScenarioData PerScenarioData PerScenarioData Int32 )

            return value;
        }
    }
}
