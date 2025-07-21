using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Fileblock                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Fs                                       ModelClassType Stream Stream Stream Pointer
    // 020 BlockNo                                  ModelPrimitiveType int int int Int32
    // 024 BlockLength                              ModelPrimitiveType int int int Int32
    // 028 PeOffset                                 ModelPrimitiveType int int int Int32
    // 02C DirSecurityOffset                        ModelPrimitiveType int int int Int32
    // 030 DirSecuritySize                          ModelPrimitiveType int int int Int32
    // 034 CoffSymbolTableOffset                    ModelPrimitiveType int int int Int32
    // 038 Pe64                                     ModelPrimitiveType bool bool bool Bool
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

            value.Fileblock                                 = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Fileblock                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Fs                                        = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 0x18 Fs                          ( ModelClassType Stream Stream Stream Pointer )
            value.BlockNo                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 BlockNo                     ( ModelPrimitiveType int int int Int32 )
            value.BlockLength                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 BlockLength                 ( ModelPrimitiveType int int int Int32 )
            value.PeOffset                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 PeOffset                    ( ModelPrimitiveType int int int Int32 )
            value.DirSecurityOffset                         = GetInt32(new IntPtr(p + 0x02C)); // 0x2C DirSecurityOffset           ( ModelPrimitiveType int int int Int32 )
            value.DirSecuritySize                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 DirSecuritySize             ( ModelPrimitiveType int int int Int32 )
            value.CoffSymbolTableOffset                     = GetInt32(new IntPtr(p + 0x034)); // 0x34 CoffSymbolTableOffset       ( ModelPrimitiveType int int int Int32 )
            value.Pe64                                      = GetBool(new IntPtr(p + 0x038)); // 0x38 Pe64                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
