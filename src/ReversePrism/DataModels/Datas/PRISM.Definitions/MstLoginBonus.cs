using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 LoginBonusType                           ModelPrimitiveType int int int Int32
    // 024 DisplayPriority                          ModelPrimitiveType int int int Int32
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.LoginBonusType                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 LoginBonusType              ( ModelPrimitiveType int int int Int32 )
            value.DisplayPriority                           = GetInt32(new IntPtr(p + 0x024)); // 0x24 DisplayPriority             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
