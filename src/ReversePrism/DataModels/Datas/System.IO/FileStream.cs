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
    // 028 Buf                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Name                                     ModelPrimitiveType string string string String
    // 038 SafeHandle                               ModelClassType SafeFileHandle SafeFileHandle SafeFileHandle Pointer
    // 040 IsExposed                                ModelPrimitiveType bool bool bool Bool
    // 048 Append_startpos                          ModelPrimitiveType long long long Int64
    // 050 Access                                   ModelEnumType FileAccess FileAccess FileAccess Int32
    // 054 Owner                                    ModelPrimitiveType bool bool bool Bool
    // 055 Async                                    ModelPrimitiveType bool bool bool Bool
    // 056 Canseek                                  ModelPrimitiveType bool bool bool Bool
    // 057 Anonymous                                ModelPrimitiveType bool bool bool Bool
    // 058 Buf_dirty                                ModelPrimitiveType bool bool bool Bool
    // 05C Buf_size                                 ModelPrimitiveType int int int Int32
    // 060 Buf_length                               ModelPrimitiveType int int int Int32
    // 064 Buf_offset                               ModelPrimitiveType int int int Int32
    // 068 Buf_start                                ModelPrimitiveType long long long Int64
    public partial class FileStream : DataModel
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
            var value   = new FileStream() { Pointer= p0 };

            value.Buf                                       = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Buf                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Name                        ( ModelPrimitiveType string string string String )
            value.SafeHandle                                = GetObject<SafeFileHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.SafeFileHandle.FromPointer); // 0x38 SafeHandle                  ( ModelClassType SafeFileHandle SafeFileHandle SafeFileHandle Pointer )
            value.IsExposed                                 = GetBool(new IntPtr(p + 0x040)); // 0x40 IsExposed                   ( ModelPrimitiveType bool bool bool Bool )
            value.Append_startpos                           = GetInt64(new IntPtr(p + 0x048)); // 0x48 Append_startpos             ( ModelPrimitiveType long long long Int64 )
            value.Access                                    = (FileAccess)GetInt32(new IntPtr(p + 0x050)); // 0x50 Access                      ( ModelEnumType FileAccess FileAccess FileAccess Int32 )
            value.Owner                                     = GetBool(new IntPtr(p + 0x054)); // 0x54 Owner                       ( ModelPrimitiveType bool bool bool Bool )
            value.Async                                     = GetBool(new IntPtr(p + 0x055)); // 0x55 Async                       ( ModelPrimitiveType bool bool bool Bool )
            value.Canseek                                   = GetBool(new IntPtr(p + 0x056)); // 0x56 Canseek                     ( ModelPrimitiveType bool bool bool Bool )
            value.Anonymous                                 = GetBool(new IntPtr(p + 0x057)); // 0x57 Anonymous                   ( ModelPrimitiveType bool bool bool Bool )
            value.Buf_dirty                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 Buf_dirty                   ( ModelPrimitiveType bool bool bool Bool )
            value.Buf_size                                  = GetInt32(new IntPtr(p + 0x05C)); // 0x5C Buf_size                    ( ModelPrimitiveType int int int Int32 )
            value.Buf_length                                = GetInt32(new IntPtr(p + 0x060)); // 0x60 Buf_length                  ( ModelPrimitiveType int int int Int32 )
            value.Buf_offset                                = GetInt32(new IntPtr(p + 0x064)); // 0x64 Buf_offset                  ( ModelPrimitiveType int int int Int32 )
            value.Buf_start                                 = GetInt64(new IntPtr(p + 0x068)); // 0x68 Buf_start                   ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
