using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Comment                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class InfoBase : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Id                                      { get; set; }
        public string                                   Comment                                 { get; set; }

        public static InfoBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InfoBase() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02466AC8B8C8 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 02466AC8B8E8 0x18 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Comment                                   = GetString(new IntPtr(p + 0x020)); // 02466AC8B908 0x20 Comment                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
