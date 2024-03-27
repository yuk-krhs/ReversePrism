using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Fileblock                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Fs                                       000186670270 ModelClassType Stream Stream Stream Pointer
    // 020 BlockNo                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 BlockLength                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 PeOffset                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C DirSecurityOffset                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 DirSecuritySize                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 CoffSymbolTableOffset                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Pe64                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AuthenticodeBase
    {
        public List<sbyte>?                             Fileblock                               { get; set; }
        public Stream?                                  Fs                                      { get; set; }
        public int                                      BlockNo                                 { get; set; }
        public int                                      BlockLength                             { get; set; }
        public int                                      PeOffset                                { get; set; }
        public int                                      DirSecurityOffset                       { get; set; }
        public int                                      DirSecuritySize                         { get; set; }
        public int                                      CoffSymbolTableOffset                   { get; set; }
        public bool                                     Pe64                                    { get; set; }

        public static AuthenticodeBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticodeBase();

            value.Fileblock                                 = GetSByteList(new IntPtr(p + 0x010)); // 0270DB3A9F28 0x10 Fileblock                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Fs                                        = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 0270DB3A9F48 0x18 Fs                          ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.BlockNo                                   = GetInt32(new IntPtr(p + 0x020)); // 0270DB3A9F68 0x20 BlockNo                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BlockLength                               = GetInt32(new IntPtr(p + 0x024)); // 0270DB3A9F88 0x24 BlockLength                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PeOffset                                  = GetInt32(new IntPtr(p + 0x028)); // 0270DB3A9FA8 0x28 PeOffset                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DirSecurityOffset                         = GetInt32(new IntPtr(p + 0x02C)); // 0270DB3A9FC8 0x2C DirSecurityOffset           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DirSecuritySize                           = GetInt32(new IntPtr(p + 0x030)); // 0270DB3A9FE8 0x30 DirSecuritySize             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CoffSymbolTableOffset                     = GetInt32(new IntPtr(p + 0x034)); // 0270DB3AA008 0x34 CoffSymbolTableOffset       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Pe64                                      = GetBool(new IntPtr(p + 0x038)); // 0270DB3AA028 0x38 Pe64                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
