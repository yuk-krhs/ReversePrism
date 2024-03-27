using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Groupcoll                                00018669C5E0 ModelClassType GroupCollection GroupCollection GroupCollection Pointer
    // 048 Regex                                    00018663B160 ModelClassType Regex Regex Regex Pointer
    // 050 Textbeg                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 054 Textpos                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 058 Textend                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 05C Textstart                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 060 _matches                                 int[][] IL2CPP_TYPE_SZARRAY
    // 068 Matchcount                               000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 Balancing                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 <Empty>k__BackingField                   Match IL2CPP_TYPE_CLASS
    public partial class Match
    {
        public GroupCollection?                         Groupcoll                               { get; set; }
        public Regex?                                   Regex                                   { get; set; }
        public int                                      Textbeg                                 { get; set; }
        public int                                      Textpos                                 { get; set; }
        public int                                      Textend                                 { get; set; }
        public int                                      Textstart                               { get; set; }
        public List<int>?                               Matchcount                              { get; set; }
        public bool                                     Balancing                               { get; set; }

        public static Match? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Match();

            value.Groupcoll                                 = GetObject<GroupCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.GroupCollection.FromPointer); // 0270001ED790 0x40 Groupcoll                   ( 00018669C5E0 ModelClassType GroupCollection GroupCollection GroupCollection Pointer )
            value.Regex                                     = GetObject<Regex>(new IntPtr(p + 0x048), ReversePrism.DataModels.Regex.FromPointer); // 0270001ED7B0 0x48 Regex                       ( 00018663B160 ModelClassType Regex Regex Regex Pointer )
            value.Textbeg                                   = GetInt32(new IntPtr(p + 0x050)); // 0270001ED7D0 0x50 Textbeg                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Textpos                                   = GetInt32(new IntPtr(p + 0x054)); // 0270001ED7F0 0x54 Textpos                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Textend                                   = GetInt32(new IntPtr(p + 0x058)); // 0270001ED810 0x58 Textend                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Textstart                                 = GetInt32(new IntPtr(p + 0x05C)); // 0270001ED830 0x5C Textstart                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Matchcount                                = GetInt32List(new IntPtr(p + 0x068)); // 0270001ED870 0x68 Matchcount                  ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Balancing                                 = GetBool(new IntPtr(p + 0x070)); // 0270001ED890 0x70 Balancing                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
