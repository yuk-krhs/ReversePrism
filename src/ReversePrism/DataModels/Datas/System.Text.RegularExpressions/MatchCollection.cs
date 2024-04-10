using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Regex                                    00018663B8B0 ModelClassType Regex Regex Regex Pointer
    // 018 Matches                                  000185CF1DE8 ModelClassListType List`1<Match> List`1<Match> List<Match> Pointer
    // 020 Done                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Input                                    000186672F10 ModelPrimitiveType string string string String
    // 030 Beginning                                0001865F4260 ModelPrimitiveType int int int Int32
    // 034 Length                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 038 Startat                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C Prevlen                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MatchCollection : DataModel
    {
        public Regex?                                   Regex                                   { get; set; }
        public List<Match>?                             Matches                                 { get; set; }
        public bool                                     Done                                    { get; set; }
        public string                                   Input                                   { get; set; }
        public int                                      Beginning                               { get; set; }
        public int                                      Length                                  { get; set; }
        public int                                      Startat                                 { get; set; }
        public int                                      Prevlen                                 { get; set; }

        public static MatchCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatchCollection() { Pointer= p0 };

            value.Regex                                     = GetObject<Regex>(new IntPtr(p + 0x010), ReversePrism.DataModels.Regex.FromPointer); // 0245A6EF2A00 0x10 Regex                       ( 00018663B8B0 ModelClassType Regex Regex Regex Pointer )
            value.Matches                                   = GetObjectList<Match>(new IntPtr(p + 0x018), ReversePrism.DataModels.Match.FromPointer); // 0245A6EF2A20 0x18 Matches                     ( 000185CF1DE8 ModelClassListType List`1<Match> List`1<Match> List<Match> Pointer )
            value.Done                                      = GetBool(new IntPtr(p + 0x020)); // 0245A6EF2A40 0x20 Done                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Input                                     = GetString(new IntPtr(p + 0x028)); // 0245A6EF2A60 0x28 Input                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.Beginning                                 = GetInt32(new IntPtr(p + 0x030)); // 0245A6EF2A80 0x30 Beginning                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x034)); // 0245A6EF2AA0 0x34 Length                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Startat                                   = GetInt32(new IntPtr(p + 0x038)); // 0245A6EF2AC0 0x38 Startat                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Prevlen                                   = GetInt32(new IntPtr(p + 0x03C)); // 0245A6EF2AE0 0x3C Prevlen                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
