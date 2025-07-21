using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Groupcoll                                ModelClassType GroupCollection GroupCollection GroupCollection Pointer
    // 048 Regex                                    ModelClassType Regex Regex Regex Pointer
    // 050 Textbeg                                  ModelPrimitiveType int int int Int32
    // 054 Textpos                                  ModelPrimitiveType int int int Int32
    // 058 Textend                                  ModelPrimitiveType int int int Int32
    // 05C Textstart                                ModelPrimitiveType int int int Int32
    // 060 _matches                                 int[][] IL2CPP_TYPE_SZARRAY
    // 068 Matchcount                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 Balancing                                ModelPrimitiveType bool bool bool Bool
    // 000 <Empty>k__BackingField                   Match IL2CPP_TYPE_CLASS
    public partial class Match : DataModel
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
            var value   = new Match() { Pointer= p0 };

            value.Groupcoll                                 = GetObject<GroupCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.GroupCollection.FromPointer); // 0x40 Groupcoll                   ( ModelClassType GroupCollection GroupCollection GroupCollection Pointer )
            value.Regex                                     = GetObject<Regex>(new IntPtr(p + 0x048), ReversePrism.DataModels.Regex.FromPointer); // 0x48 Regex                       ( ModelClassType Regex Regex Regex Pointer )
            value.Textbeg                                   = GetInt32(new IntPtr(p + 0x050)); // 0x50 Textbeg                     ( ModelPrimitiveType int int int Int32 )
            value.Textpos                                   = GetInt32(new IntPtr(p + 0x054)); // 0x54 Textpos                     ( ModelPrimitiveType int int int Int32 )
            value.Textend                                   = GetInt32(new IntPtr(p + 0x058)); // 0x58 Textend                     ( ModelPrimitiveType int int int Int32 )
            value.Textstart                                 = GetInt32(new IntPtr(p + 0x05C)); // 0x5C Textstart                   ( ModelPrimitiveType int int int Int32 )
            value.Matchcount                                = GetInt32List(new IntPtr(p + 0x068)); // 0x68 Matchcount                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Balancing                                 = GetBool(new IntPtr(p + 0x070)); // 0x70 Balancing                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
