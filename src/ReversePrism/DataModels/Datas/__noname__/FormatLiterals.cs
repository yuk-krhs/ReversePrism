using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppCompatLiteral                         ModelPrimitiveType string string string String
    // 018 Dd                                       ModelPrimitiveType int int int Int32
    // 01C Hh                                       ModelPrimitiveType int int int Int32
    // 020 Mm                                       ModelPrimitiveType int int int Int32
    // 024 Ss                                       ModelPrimitiveType int int int Int32
    // 028 Ff                                       ModelPrimitiveType int int int Int32
    // 030 Literals                                 ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.AppCompatLiteral                          = GetString(new IntPtr(p + 0x010)); // 0x10 AppCompatLiteral            ( ModelPrimitiveType string string string String )
            value.Dd                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Dd                          ( ModelPrimitiveType int int int Int32 )
            value.Hh                                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Hh                          ( ModelPrimitiveType int int int Int32 )
            value.Mm                                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 Mm                          ( ModelPrimitiveType int int int Int32 )
            value.Ss                                        = GetInt32(new IntPtr(p + 0x024)); // 0x24 Ss                          ( ModelPrimitiveType int int int Int32 )
            value.Ff                                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 Ff                          ( ModelPrimitiveType int int int Int32 )
            value.Literals                                  = GetStringList(new IntPtr(p + 0x030)); // 0x30 Literals                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
