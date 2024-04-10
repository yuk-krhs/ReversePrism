using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NextEntryOffset                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 FileIndex                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 CreationTime                             000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 020 LastAccessTime                           000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 028 LastWriteTime                            000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 030 ChangeTime                               000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 038 EndOfFile                                0001865F7E40 ModelPrimitiveType long long long Int64
    // 040 AllocationSize                           0001865F7E40 ModelPrimitiveType long long long Int64
    // 048 FileAttributes                           000186578740 ModelEnumType FileAttributes FileAttributes FileAttributes Int32
    // 04C FileNameLength                           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 050 EaSize                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 054 _fileName                                char IL2CPP_TYPE_CHAR
    public partial class FILE_FULL_DIR_INFORMATION : DataModel
    {
        public uint                                     NextEntryOffset                         { get; set; }
        public uint                                     FileIndex                               { get; set; }
        public LongFileTime                             CreationTime                            { get; set; }
        public LongFileTime                             LastAccessTime                          { get; set; }
        public LongFileTime                             LastWriteTime                           { get; set; }
        public LongFileTime                             ChangeTime                              { get; set; }
        public long                                     EndOfFile                               { get; set; }
        public long                                     AllocationSize                          { get; set; }
        public FileAttributes                           FileAttributes                          { get; set; }
        public uint                                     FileNameLength                          { get; set; }
        public uint                                     EaSize                                  { get; set; }

        public static FILE_FULL_DIR_INFORMATION? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FILE_FULL_DIR_INFORMATION() { Pointer= p0 };

            value.NextEntryOffset                           = GetUInt32(new IntPtr(p + 0x010)); // 0246669A15C0 0x10 NextEntryOffset             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FileIndex                                 = GetUInt32(new IntPtr(p + 0x014)); // 0246669A15E0 0x14 FileIndex                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CreationTime                              = (LongFileTime)GetInt32(new IntPtr(p + 0x018)); // 0246669A1600 0x18 CreationTime                ( 000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.LastAccessTime                            = (LongFileTime)GetInt32(new IntPtr(p + 0x020)); // 0246669A1620 0x20 LastAccessTime              ( 000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.LastWriteTime                             = (LongFileTime)GetInt32(new IntPtr(p + 0x028)); // 0246669A1640 0x28 LastWriteTime               ( 000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.ChangeTime                                = (LongFileTime)GetInt32(new IntPtr(p + 0x030)); // 0246669A1660 0x30 ChangeTime                  ( 000186644E90 ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.EndOfFile                                 = GetInt64(new IntPtr(p + 0x038)); // 0246669A1680 0x38 EndOfFile                   ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.AllocationSize                            = GetInt64(new IntPtr(p + 0x040)); // 0246669A16A0 0x40 AllocationSize              ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.FileAttributes                            = (FileAttributes)GetInt32(new IntPtr(p + 0x048)); // 0246669A16C0 0x48 FileAttributes              ( 000186578740 ModelEnumType FileAttributes FileAttributes FileAttributes Int32 )
            value.FileNameLength                            = GetUInt32(new IntPtr(p + 0x04C)); // 0246669A16E0 0x4C FileNameLength              ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.EaSize                                    = GetUInt32(new IntPtr(p + 0x050)); // 0246669A1700 0x50 EaSize                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
