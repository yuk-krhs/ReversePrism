using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IsUnlocked                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 030 CostumeName                              000186671910 ModelPrimitiveType string string string String
    // 038 UnlockCondition                          000186671910 ModelPrimitiveType string string string String
    public partial class CostumeGridViewCellData
    {
        public bool                                     IsUnlocked                              { get; set; }
        public string                                   CostumeName                             { get; set; }
        public string                                   UnlockCondition                         { get; set; }

        public static CostumeGridViewCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeGridViewCellData();

            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x028)); // 0270D623DDA0 0x28 IsUnlocked                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CostumeName                               = GetString(new IntPtr(p + 0x030)); // 0270D623DDC0 0x30 CostumeName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.UnlockCondition                           = GetString(new IntPtr(p + 0x038)); // 0270D623DDE0 0x38 UnlockCondition             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
