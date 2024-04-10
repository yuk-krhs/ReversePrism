using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               000186672F10 ModelPrimitiveType string string string String
    // 018 Option0CharaId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Option1CharaId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Option2CharaId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 024 Option3CharaId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 028 Option4CharaId                           0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstSubSeasonOpeningAdvOption : DataModel
    {
        public string                                   ScenarioId                              { get; set; }
        public int                                      Option0CharaId                          { get; set; }
        public int                                      Option1CharaId                          { get; set; }
        public int                                      Option2CharaId                          { get; set; }
        public int                                      Option3CharaId                          { get; set; }
        public int                                      Option4CharaId                          { get; set; }

        public static MstSubSeasonOpeningAdvOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSubSeasonOpeningAdvOption() { Pointer= p0 };

            value.ScenarioId                                = GetString(new IntPtr(p + 0x010)); // 0245A4620AA0 0x10 ScenarioId                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Option0CharaId                            = GetInt32(new IntPtr(p + 0x018)); // 0245A4620AC0 0x18 Option0CharaId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Option1CharaId                            = GetInt32(new IntPtr(p + 0x01C)); // 0245A4620AE0 0x1C Option1CharaId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Option2CharaId                            = GetInt32(new IntPtr(p + 0x020)); // 0245A4620B00 0x20 Option2CharaId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Option3CharaId                            = GetInt32(new IntPtr(p + 0x024)); // 0245A4620B20 0x24 Option3CharaId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Option4CharaId                            = GetInt32(new IntPtr(p + 0x028)); // 0245A4620B40 0x28 Option4CharaId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
