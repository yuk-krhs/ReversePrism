using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LocalMetadataRootName                    string IL2CPP_TYPE_STRING
    // 008 LocalAssetsRootName                      string IL2CPP_TYPE_STRING
    // 010 LocalBackupRootName                      ModelPrimitiveType string string string String
    // 018 MetadataRoot                             ModelPrimitiveType string string string String
    // 020 DownloadDataRoot                         ModelPrimitiveType string string string String
    // 028 BackupRoot                               ModelPrimitiveType string string string String
    // 030 TemporaryDataRoot                        ModelPrimitiveType string string string String
    public partial class GlobalSetting : DataModel
    {
        public string                                   LocalBackupRootName                     { get; set; }
        public string                                   MetadataRoot                            { get; set; }
        public string                                   DownloadDataRoot                        { get; set; }
        public string                                   BackupRoot                              { get; set; }
        public string                                   TemporaryDataRoot                       { get; set; }

        public static GlobalSetting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalSetting() { Pointer= p0 };

            value.LocalBackupRootName                       = GetString(new IntPtr(p + 0x010)); // 0x10 LocalBackupRootName         ( ModelPrimitiveType string string string String )
            value.MetadataRoot                              = GetString(new IntPtr(p + 0x018)); // 0x18 MetadataRoot                ( ModelPrimitiveType string string string String )
            value.DownloadDataRoot                          = GetString(new IntPtr(p + 0x020)); // 0x20 DownloadDataRoot            ( ModelPrimitiveType string string string String )
            value.BackupRoot                                = GetString(new IntPtr(p + 0x028)); // 0x28 BackupRoot                  ( ModelPrimitiveType string string string String )
            value.TemporaryDataRoot                         = GetString(new IntPtr(p + 0x030)); // 0x30 TemporaryDataRoot           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
