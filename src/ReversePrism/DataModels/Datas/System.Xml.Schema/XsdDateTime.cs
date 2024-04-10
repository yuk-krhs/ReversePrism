using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dt                                       0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 Extra                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 000 Lzyyyy                                   int IL2CPP_TYPE_I4
    // 004 Lzyyyy_                                  int IL2CPP_TYPE_I4
    // 008 Lzyyyy_MM                                int IL2CPP_TYPE_I4
    // 00C Lzyyyy_MM_                               int IL2CPP_TYPE_I4
    // 010 Lzyyyy_MM_dd                             0001865F4BC0 ModelPrimitiveType int int int Int32
    // 014 Lzyyyy_MM_ddT                            0001865F4BC0 ModelPrimitiveType int int int Int32
    // 018 LzHH                                     0001865F4BC0 ModelPrimitiveType int int int Int32
    // 01C LzHH                                     0001865F4BC0 ModelPrimitiveType int int int Int32
    // 020 LzHH_mm                                  0001865F4BC0 ModelPrimitiveType int int int Int32
    // 024 LzHH_mm                                  0001865F4BC0 ModelPrimitiveType int int int Int32
    // 028 LzHH_mm_ss                               0001865F4BC0 ModelPrimitiveType int int int Int32
    // 02C Lz                                       0001865F4BC0 ModelPrimitiveType int int int Int32
    // 030 Lz_zz                                    0001865F4BC0 ModelPrimitiveType int int int Int32
    // 034 Lz_zz                                    0001865F4BC0 ModelPrimitiveType int int int Int32
    // 038 Lz_zz_zz                                 0001865F4BC0 ModelPrimitiveType int int int Int32
    // 03C Lz                                       0001865F4BC0 ModelPrimitiveType int int int Int32
    // 040 Lz__mm                                   0001865F4BC0 ModelPrimitiveType int int int Int32
    // 044 Lz__mm                                   0001865F4BC0 ModelPrimitiveType int int int Int32
    // 048 Lz__mm                                   0001865F4BC0 ModelPrimitiveType int int int Int32
    // 04C Lz__mm_dd                                0001865F4BC0 ModelPrimitiveType int int int Int32
    // 050 Lz                                       0001865F4BC0 ModelPrimitiveType int int int Int32
    // 054 Lz___dd                                  0001865F4BC0 ModelPrimitiveType int int int Int32
    // 058 TypeCodes                                000185CB4C88 ModelEnumListType XmlTypeCode[] XmlTypeCode[] List<XmlTypeCode> Pointer
    public partial class XsdDateTime : DataModel
    {
        public DateTime                                 Dt                                      { get; set; }
        public uint                                     Extra                                   { get; set; }
        public int                                      Lzyyyy_MM_dd                            { get; set; }
        public int                                      Lzyyyy_MM_ddT                           { get; set; }
        public int                                      LzHH                                    { get; set; }
        public int                                      LzHH_mm                                 { get; set; }
        public int                                      LzHH_mm_ss                              { get; set; }
        public int                                      Lz                                      { get; set; }
        public int                                      Lz_zz                                   { get; set; }
        public int                                      Lz_zz_zz                                { get; set; }
        public int                                      Lz__mm                                  { get; set; }
        public int                                      Lz__mm_dd                               { get; set; }
        public int                                      Lz___dd                                 { get; set; }
        public List<XmlTypeCode>?                       TypeCodes                               { get; set; }

        public static XsdDateTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdDateTime() { Pointer= p0 };

            value.Dt                                        = GetDateTime(new IntPtr(p + 0x010)); // 024667662718 0x10 Dt                          ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Extra                                     = GetUInt32(new IntPtr(p + 0x018)); // 024667662738 0x18 Extra                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Lzyyyy_MM_dd                              = GetInt32(new IntPtr(p + 0x010)); // 0246676627D8 0x10 Lzyyyy_MM_dd                ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Lzyyyy_MM_ddT                             = GetInt32(new IntPtr(p + 0x014)); // 0246676627F8 0x14 Lzyyyy_MM_ddT               ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.LzHH                                      = GetInt32(new IntPtr(p + 0x01C)); // 024667662838 0x1C LzHH                        ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.LzHH_mm                                   = GetInt32(new IntPtr(p + 0x024)); // 024667662878 0x24 LzHH_mm                     ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.LzHH_mm_ss                                = GetInt32(new IntPtr(p + 0x028)); // 024667662898 0x28 LzHH_mm_ss                  ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Lz                                        = GetInt32(new IntPtr(p + 0x050)); // 0246676629D8 0x50 Lz                          ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Lz_zz                                     = GetInt32(new IntPtr(p + 0x034)); // 0246676628F8 0x34 Lz_zz                       ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Lz_zz_zz                                  = GetInt32(new IntPtr(p + 0x038)); // 024667662918 0x38 Lz_zz_zz                    ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Lz__mm                                    = GetInt32(new IntPtr(p + 0x048)); // 024667662998 0x48 Lz__mm                      ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Lz__mm_dd                                 = GetInt32(new IntPtr(p + 0x04C)); // 0246676629B8 0x4C Lz__mm_dd                   ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Lz___dd                                   = GetInt32(new IntPtr(p + 0x054)); // 0246676629F8 0x54 Lz___dd                     ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.TypeCodes                                 = GetEnumList<XmlTypeCode>(new IntPtr(p + 0x058)); // 024667662A18 0x58 TypeCodes                   ( 000185CB4C88 ModelEnumListType XmlTypeCode[] XmlTypeCode[] List<XmlTypeCode> Pointer )

            return value;
        }
    }
}
