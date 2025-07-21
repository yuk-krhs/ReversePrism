using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Regex                                    ModelClassType Regex Regex Regex Pointer
    // 018 Matches                                  ModelClassListType List`1<Match> List`1<Match> List<Match> Pointer
    // 020 Done                                     ModelPrimitiveType bool bool bool Bool
    // 028 Input                                    ModelPrimitiveType string string string String
    // 030 Beginning                                ModelPrimitiveType int int int Int32
    // 034 Length                                   ModelPrimitiveType int int int Int32
    // 038 Startat                                  ModelPrimitiveType int int int Int32
    // 03C Prevlen                                  ModelPrimitiveType int int int Int32
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

            value.Regex                                     = GetObject<Regex>(new IntPtr(p + 0x010), ReversePrism.DataModels.Regex.FromPointer); // 0x10 Regex                       ( ModelClassType Regex Regex Regex Pointer )
            value.Matches                                   = GetObjectList<Match>(new IntPtr(p + 0x018), ReversePrism.DataModels.Match.FromPointer); // 0x18 Matches                     ( ModelClassListType List`1<Match> List`1<Match> List<Match> Pointer )
            value.Done                                      = GetBool(new IntPtr(p + 0x020)); // 0x20 Done                        ( ModelPrimitiveType bool bool bool Bool )
            value.Input                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Input                       ( ModelPrimitiveType string string string String )
            value.Beginning                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 Beginning                   ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x034)); // 0x34 Length                      ( ModelPrimitiveType int int int Int32 )
            value.Startat                                   = GetInt32(new IntPtr(p + 0x038)); // 0x38 Startat                     ( ModelPrimitiveType int int int Int32 )
            value.Prevlen                                   = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Prevlen                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
