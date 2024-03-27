using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 InsertionPointId                         0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SlotDefinition
    {
        public string                                   Name                                    { get; set; }
        public int                                      InsertionPointId                        { get; set; }

        public static SlotDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlotDefinition();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027006854170 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.InsertionPointId                          = GetInt32(new IntPtr(p + 0x018)); // 027006854190 0x18 InsertionPointId            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
