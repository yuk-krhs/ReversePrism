using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 buf_recycle                              sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 buf_recycle_lock                         <object> IL2CPP_TYPE_OBJECT
    // 028 Buf                                      000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Name                                     000186671910 ModelPrimitiveType string string string String
    // 038 SafeHandle                               0001866B8540 ModelClassType SafeFileHandle SafeFileHandle SafeFileHandle Pointer
    // 040 IsExposed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 Append_startpos                          0001865F7700 ModelPrimitiveType long long long Int64
    // 050 Access                                   000186577D30 ModelEnumType FileAccess FileAccess FileAccess Int32
    // 054 Owner                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 055 Async                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 056 Canseek                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 057 Anonymous                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 Buf_dirty                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C Buf_size                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 Buf_length                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 Buf_offset                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 Buf_start                                0001865F7700 ModelPrimitiveType long long long Int64
    public partial class FileStream
    {
        public List<sbyte>?                             Buf                                     { get; set; }
        public string                                   Name                                    { get; set; }
        public SafeFileHandle?                          SafeHandle                              { get; set; }
        public bool                                     IsExposed                               { get; set; }
        public long                                     Append_startpos                         { get; set; }
        public FileAccess                               Access                                  { get; set; }
        public bool                                     Owner                                   { get; set; }
        public bool                                     Async                                   { get; set; }
        public bool                                     Canseek                                 { get; set; }
        public bool                                     Anonymous                               { get; set; }
        public bool                                     Buf_dirty                               { get; set; }
        public int                                      Buf_size                                { get; set; }
        public int                                      Buf_length                              { get; set; }
        public int                                      Buf_offset                              { get; set; }
        public long                                     Buf_start                               { get; set; }

        public static FileStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileStream();

            value.Buf                                       = GetSByteList(new IntPtr(p + 0x028)); // 027003D00078 0x28 Buf                         ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 027003D00098 0x30 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.SafeHandle                                = GetObject<SafeFileHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.SafeFileHandle.FromPointer); // 027003D000B8 0x38 SafeHandle                  ( 0001866B8540 ModelClassType SafeFileHandle SafeFileHandle SafeFileHandle Pointer )
            value.IsExposed                                 = GetBool(new IntPtr(p + 0x040)); // 027003D000D8 0x40 IsExposed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Append_startpos                           = GetInt64(new IntPtr(p + 0x048)); // 027003D000F8 0x48 Append_startpos             ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Access                                    = (FileAccess)GetInt32(new IntPtr(p + 0x050)); // 027003D00118 0x50 Access                      ( 000186577D30 ModelEnumType FileAccess FileAccess FileAccess Int32 )
            value.Owner                                     = GetBool(new IntPtr(p + 0x054)); // 027003D00138 0x54 Owner                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Async                                     = GetBool(new IntPtr(p + 0x055)); // 027003D00158 0x55 Async                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Canseek                                   = GetBool(new IntPtr(p + 0x056)); // 027003D00178 0x56 Canseek                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Anonymous                                 = GetBool(new IntPtr(p + 0x057)); // 027003D00198 0x57 Anonymous                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Buf_dirty                                 = GetBool(new IntPtr(p + 0x058)); // 027003D001B8 0x58 Buf_dirty                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Buf_size                                  = GetInt32(new IntPtr(p + 0x05C)); // 027003D001D8 0x5C Buf_size                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buf_length                                = GetInt32(new IntPtr(p + 0x060)); // 027003D001F8 0x60 Buf_length                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buf_offset                                = GetInt32(new IntPtr(p + 0x064)); // 027003D00218 0x64 Buf_offset                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buf_start                                 = GetInt64(new IntPtr(p + 0x068)); // 027003D00238 0x68 Buf_start                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
