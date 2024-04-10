using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextId                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 AppId                                    0001866722E0 ModelPrimitiveType string string string String
    // 020 AuthorId                                 0001866722E0 ModelPrimitiveType string string string String
    // 028 OwnerId                                  0001866722E0 ModelPrimitiveType string string string String
    // 030 Data                                     0001866722E0 ModelPrimitiveType string string string String
    // 038 Status                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 Ctime                                    0001866722E0 ModelPrimitiveType string string string String
    // 048 Mtime                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class InspectionEntry : DataModel
    {
        public string                                   TextId                                  { get; set; }
        public string                                   AppId                                   { get; set; }
        public string                                   AuthorId                                { get; set; }
        public string                                   OwnerId                                 { get; set; }
        public string                                   Data                                    { get; set; }
        public int                                      Status                                  { get; set; }
        public string                                   Ctime                                   { get; set; }
        public string                                   Mtime                                   { get; set; }

        public static InspectionEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectionEntry() { Pointer= p0 };

            value.TextId                                    = GetString(new IntPtr(p + 0x010)); // 02466B54C4D8 0x10 TextId                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AppId                                     = GetString(new IntPtr(p + 0x018)); // 02466B54C4F8 0x18 AppId                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AuthorId                                  = GetString(new IntPtr(p + 0x020)); // 02466B54C518 0x20 AuthorId                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.OwnerId                                   = GetString(new IntPtr(p + 0x028)); // 02466B54C538 0x28 OwnerId                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Data                                      = GetString(new IntPtr(p + 0x030)); // 02466B54C558 0x30 Data                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Status                                    = GetInt32(new IntPtr(p + 0x038)); // 02466B54C578 0x38 Status                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Ctime                                     = GetString(new IntPtr(p + 0x040)); // 02466B54C598 0x40 Ctime                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Mtime                                     = GetString(new IntPtr(p + 0x048)); // 02466B54C5B8 0x48 Mtime                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
