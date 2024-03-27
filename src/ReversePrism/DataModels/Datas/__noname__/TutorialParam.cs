using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 TitleName                                0001866722E0 ModelPrimitiveType string string string String
    // 020 UnitId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TutorialParam
    {
        public int                                      Id                                      { get; set; }
        public string                                   TitleName                               { get; set; }
        public int                                      UnitId                                  { get; set; }

        public static TutorialParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialParam();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D5D1B448 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TitleName                                 = GetString(new IntPtr(p + 0x018)); // 0270D5D1B468 0x18 TitleName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x020)); // 0270D5D1B488 0x20 UnitId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
