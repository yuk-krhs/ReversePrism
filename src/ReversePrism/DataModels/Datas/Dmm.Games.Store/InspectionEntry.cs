using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextId                                   ModelPrimitiveType string string string String
    // 018 AppId                                    ModelPrimitiveType string string string String
    // 020 AuthorId                                 ModelPrimitiveType string string string String
    // 028 OwnerId                                  ModelPrimitiveType string string string String
    // 030 Data                                     ModelPrimitiveType string string string String
    // 038 Status                                   ModelPrimitiveType int int int Int32
    // 040 Ctime                                    ModelPrimitiveType string string string String
    // 048 Mtime                                    ModelPrimitiveType string string string String
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

            value.TextId                                    = GetString(new IntPtr(p + 0x010)); // 0x10 TextId                      ( ModelPrimitiveType string string string String )
            value.AppId                                     = GetString(new IntPtr(p + 0x018)); // 0x18 AppId                       ( ModelPrimitiveType string string string String )
            value.AuthorId                                  = GetString(new IntPtr(p + 0x020)); // 0x20 AuthorId                    ( ModelPrimitiveType string string string String )
            value.OwnerId                                   = GetString(new IntPtr(p + 0x028)); // 0x28 OwnerId                     ( ModelPrimitiveType string string string String )
            value.Data                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Data                        ( ModelPrimitiveType string string string String )
            value.Status                                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 Status                      ( ModelPrimitiveType int int int Int32 )
            value.Ctime                                     = GetString(new IntPtr(p + 0x040)); // 0x40 Ctime                       ( ModelPrimitiveType string string string String )
            value.Mtime                                     = GetString(new IntPtr(p + 0x048)); // 0x48 Mtime                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
