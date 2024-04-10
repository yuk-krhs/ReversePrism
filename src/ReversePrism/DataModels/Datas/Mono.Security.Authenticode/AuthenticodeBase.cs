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
    public partial class AuthenticodeBase : DataModel
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
            var value   = new AuthenticodeBase() { Pointer= p0 };

            value.Fileblock                                 = GetSByteList(new IntPtr(p + 0x010)); // 02466B4396C0 0x10 Fileblock                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Fs                                        = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 02466B4396E0 0x18 Fs                          ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.BlockNo                                   = GetInt32(new IntPtr(p + 0x020)); // 02466B439700 0x20 BlockNo                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BlockLength                               = GetInt32(new IntPtr(p + 0x024)); // 02466B439720 0x24 BlockLength                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PeOffset                                  = GetInt32(new IntPtr(p + 0x028)); // 02466B439740 0x28 PeOffset                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DirSecurityOffset                         = GetInt32(new IntPtr(p + 0x02C)); // 02466B439760 0x2C DirSecurityOffset           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DirSecuritySize                           = GetInt32(new IntPtr(p + 0x030)); // 02466B439780 0x30 DirSecuritySize             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CoffSymbolTableOffset                     = GetInt32(new IntPtr(p + 0x034)); // 02466B4397A0 0x34 CoffSymbolTableOffset       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Pe64                                      = GetBool(new IntPtr(p + 0x038)); // 02466B4397C0 0x38 Pe64                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
