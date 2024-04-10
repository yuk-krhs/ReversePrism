using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 020 LoginBonusType                           0001865F4260 ModelPrimitiveType int int int Int32
    // 024 DisplayPriority                          0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstLoginBonus : DataModel
    {
        public int                                      Id                                      { get; set; }
        public string                                   Title                                   { get; set; }
        public int                                      LoginBonusType                          { get; set; }
        public int                                      DisplayPriority                         { get; set; }

        public static MstLoginBonus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLoginBonus() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46EBBB8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0245A46EBBD8 0x18 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.LoginBonusType                            = GetInt32(new IntPtr(p + 0x020)); // 0245A46EBBF8 0x20 LoginBonusType              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DisplayPriority                           = GetInt32(new IntPtr(p + 0x024)); // 0245A46EBC18 0x24 DisplayPriority             ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
