using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 InsertionPointId                         ModelPrimitiveType int int int Int32
    public partial class SlotDefinition : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      InsertionPointId                        { get; set; }

        public static SlotDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlotDefinition() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.InsertionPointId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 InsertionPointId            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
