using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppCompatLiteral                         000186671BA0 ModelPrimitiveType string string string String
    // 018 Dd                                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Hh                                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Mm                                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 Ss                                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Ff                                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 030 Literals                                 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class FormatLiterals : DataModel
    {
        public string                                   AppCompatLiteral                        { get; set; }
        public int                                      Dd                                      { get; set; }
        public int                                      Hh                                      { get; set; }
        public int                                      Mm                                      { get; set; }
        public int                                      Ss                                      { get; set; }
        public int                                      Ff                                      { get; set; }
        public List<string>?                            Literals                                { get; set; }

        public static FormatLiterals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FormatLiterals() { Pointer= p0 };

            value.AppCompatLiteral                          = GetString(new IntPtr(p + 0x010)); // 024666D8A9D8 0x10 AppCompatLiteral            ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Dd                                        = GetInt32(new IntPtr(p + 0x018)); // 024666D8A9F8 0x18 Dd                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Hh                                        = GetInt32(new IntPtr(p + 0x01C)); // 024666D8AA18 0x1C Hh                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Mm                                        = GetInt32(new IntPtr(p + 0x020)); // 024666D8AA38 0x20 Mm                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Ss                                        = GetInt32(new IntPtr(p + 0x024)); // 024666D8AA58 0x24 Ss                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Ff                                        = GetInt32(new IntPtr(p + 0x028)); // 024666D8AA78 0x28 Ff                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Literals                                  = GetStringList(new IntPtr(p + 0x030)); // 024666D8AA98 0x30 Literals                    ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
