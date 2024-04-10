using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FileAttributes                           000186578740 ModelEnumType FileAttributes FileAttributes FileAttributes Int32
    // 018 Length                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 020 CreationTime                             0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 LastAccessTime                           0001865F7E40 ModelPrimitiveType long long long Int64
    // 030 LastWriteTime                            0001865F7E40 ModelPrimitiveType long long long Int64
    public partial class MonoIOStat : DataModel
    {
        public FileAttributes                           FileAttributes                          { get; set; }
        public long                                     Length                                  { get; set; }
        public long                                     CreationTime                            { get; set; }
        public long                                     LastAccessTime                          { get; set; }
        public long                                     LastWriteTime                           { get; set; }

        public static MonoIOStat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoIOStat() { Pointer= p0 };

            value.FileAttributes                            = (FileAttributes)GetInt32(new IntPtr(p + 0x010)); // 024666EB6EF8 0x10 FileAttributes              ( 000186578740 ModelEnumType FileAttributes FileAttributes FileAttributes Int32 )
            value.Length                                    = GetInt64(new IntPtr(p + 0x018)); // 024666EB6F18 0x18 Length                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.CreationTime                              = GetInt64(new IntPtr(p + 0x020)); // 024666EB6F38 0x20 CreationTime                ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.LastAccessTime                            = GetInt64(new IntPtr(p + 0x028)); // 024666EB6F58 0x28 LastAccessTime              ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.LastWriteTime                             = GetInt64(new IntPtr(p + 0x030)); // 024666EB6F78 0x30 LastWriteTime               ( 0001865F7E40 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
