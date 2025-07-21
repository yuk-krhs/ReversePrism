using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Data                                     ModelEnumType WIN32_FILE_ATTRIBUTE_DATA WIN32_FILE_ATTRIBUTE_DATA WIN32_FILE_ATTRIBUTE_DATA Int32
    // 03C DataInitialized                          ModelPrimitiveType int int int Int32
    // 040 FullPath                                 ModelPrimitiveType string string string String
    // 048 OriginalPath                             ModelPrimitiveType string string string String
    // 050 Name                                     ModelPrimitiveType string string string String
    public partial class FileSystemInfo : DataModel
    {
        public WIN32_FILE_ATTRIBUTE_DATA                Data                                    { get; set; }
        public int                                      DataInitialized                         { get; set; }
        public string                                   FullPath                                { get; set; }
        public string                                   OriginalPath                            { get; set; }
        public string                                   Name                                    { get; set; }

        public static FileSystemInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileSystemInfo() { Pointer= p0 };

            value.Data                                      = (WIN32_FILE_ATTRIBUTE_DATA)GetInt32(new IntPtr(p + 0x018)); // 0x18 Data                        ( ModelEnumType WIN32_FILE_ATTRIBUTE_DATA WIN32_FILE_ATTRIBUTE_DATA WIN32_FILE_ATTRIBUTE_DATA Int32 )
            value.DataInitialized                           = GetInt32(new IntPtr(p + 0x03C)); // 0x3C DataInitialized             ( ModelPrimitiveType int int int Int32 )
            value.FullPath                                  = GetString(new IntPtr(p + 0x040)); // 0x40 FullPath                    ( ModelPrimitiveType string string string String )
            value.OriginalPath                              = GetString(new IntPtr(p + 0x048)); // 0x48 OriginalPath                ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0x50 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
