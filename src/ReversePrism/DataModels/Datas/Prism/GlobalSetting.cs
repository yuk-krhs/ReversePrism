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
    // 010 LocalBackupRootName                      000186674040 ModelPrimitiveType string string string String
    // 018 MetadataRoot                             000186674040 ModelPrimitiveType string string string String
    // 020 DownloadDataRoot                         000186674040 ModelPrimitiveType string string string String
    // 028 BackupRoot                               000186674040 ModelPrimitiveType string string string String
    // 030 TemporaryDataRoot                        000186672D00 ModelPrimitiveType string string string String
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

            value.LocalBackupRootName                       = GetString(new IntPtr(p + 0x010)); // 0245A3CF3980 0x10 LocalBackupRootName         ( 000186674040 ModelPrimitiveType string string string String )
            value.MetadataRoot                              = GetString(new IntPtr(p + 0x018)); // 0245A3CF39A0 0x18 MetadataRoot                ( 000186674040 ModelPrimitiveType string string string String )
            value.DownloadDataRoot                          = GetString(new IntPtr(p + 0x020)); // 0245A3CF39C0 0x20 DownloadDataRoot            ( 000186674040 ModelPrimitiveType string string string String )
            value.BackupRoot                                = GetString(new IntPtr(p + 0x028)); // 0245A3CF39E0 0x28 BackupRoot                  ( 000186674040 ModelPrimitiveType string string string String )
            value.TemporaryDataRoot                         = GetString(new IntPtr(p + 0x030)); // 0245A3CF3A00 0x30 TemporaryDataRoot           ( 000186672D00 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
