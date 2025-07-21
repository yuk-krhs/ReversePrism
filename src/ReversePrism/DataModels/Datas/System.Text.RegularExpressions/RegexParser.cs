using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    ModelClassType RegexNode RegexNode RegexNode Pointer
    // 018 Group                                    ModelClassType RegexNode RegexNode RegexNode Pointer
    // 020 Alternation                              ModelClassType RegexNode RegexNode RegexNode Pointer
    // 028 Concatenation                            ModelClassType RegexNode RegexNode RegexNode Pointer
    // 030 Unit                                     ModelClassType RegexNode RegexNode RegexNode Pointer
    // 038 Pattern                                  ModelPrimitiveType string string string String
    // 040 CurrentPos                               ModelPrimitiveType int int int Int32
    // 048 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 050 Autocap                                  ModelPrimitiveType int int int Int32
    // 054 Capcount                                 ModelPrimitiveType int int int Int32
    // 058 Captop                                   ModelPrimitiveType int int int Int32
    // 05C Capsize                                  ModelPrimitiveType int int int Int32
    // 060 Caps                                     ModelClassType Hashtable Hashtable Hashtable Pointer
    // 068 Capnames                                 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 Capnumlist                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 Capnamelist                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 080 Options                                  ModelEnumType RegexOptions RegexOptions RegexOptions Int32
    // 088 OptionsStack                             ModelEnumListType List`1<RegexOptions> List`1<RegexOptions> List<RegexOptions> Pointer
    // 090 IgnoreNextParen                          ModelPrimitiveType bool bool bool Bool
    // 000 s_category                               sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class RegexParser : DataModel
    {
        public RegexNode?                               Stack                                   { get; set; }
        public RegexNode?                               Group                                   { get; set; }
        public RegexNode?                               Alternation                             { get; set; }
        public RegexNode?                               Concatenation                           { get; set; }
        public RegexNode?                               Unit                                    { get; set; }
        public string                                   Pattern                                 { get; set; }
        public int                                      CurrentPos                              { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }
        public int                                      Autocap                                 { get; set; }
        public int                                      Capcount                                { get; set; }
        public int                                      Captop                                  { get; set; }
        public int                                      Capsize                                 { get; set; }
        public Hashtable?                               Caps                                    { get; set; }
        public Hashtable?                               Capnames                                { get; set; }
        public List<int>?                               Capnumlist                              { get; set; }
        public List<string>?                            Capnamelist                             { get; set; }
        public RegexOptions                             Options                                 { get; set; }
        public List<RegexOptions>?                      OptionsStack                            { get; set; }
        public bool                                     IgnoreNextParen                         { get; set; }

        public static RegexParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexParser() { Pointer= p0 };

            value.Stack                                     = GetObject<RegexNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.RegexNode.FromPointer); // 0x10 Stack                       ( ModelClassType RegexNode RegexNode RegexNode Pointer )
            value.Group                                     = GetObject<RegexNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.RegexNode.FromPointer); // 0x18 Group                       ( ModelClassType RegexNode RegexNode RegexNode Pointer )
            value.Alternation                               = GetObject<RegexNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.RegexNode.FromPointer); // 0x20 Alternation                 ( ModelClassType RegexNode RegexNode RegexNode Pointer )
            value.Concatenation                             = GetObject<RegexNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.RegexNode.FromPointer); // 0x28 Concatenation               ( ModelClassType RegexNode RegexNode RegexNode Pointer )
            value.Unit                                      = GetObject<RegexNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.RegexNode.FromPointer); // 0x30 Unit                        ( ModelClassType RegexNode RegexNode RegexNode Pointer )
            value.Pattern                                   = GetString(new IntPtr(p + 0x038)); // 0x38 Pattern                     ( ModelPrimitiveType string string string String )
            value.CurrentPos                                = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentPos                  ( ModelPrimitiveType int int int Int32 )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x48 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Autocap                                   = GetInt32(new IntPtr(p + 0x050)); // 0x50 Autocap                     ( ModelPrimitiveType int int int Int32 )
            value.Capcount                                  = GetInt32(new IntPtr(p + 0x054)); // 0x54 Capcount                    ( ModelPrimitiveType int int int Int32 )
            value.Captop                                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 Captop                      ( ModelPrimitiveType int int int Int32 )
            value.Capsize                                   = GetInt32(new IntPtr(p + 0x05C)); // 0x5C Capsize                     ( ModelPrimitiveType int int int Int32 )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x060), ReversePrism.DataModels.Hashtable.FromPointer); // 0x60 Caps                        ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capnames                                  = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0x68 Capnames                    ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capnumlist                                = GetInt32List(new IntPtr(p + 0x070)); // 0x70 Capnumlist                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Capnamelist                               = GetStringList(new IntPtr(p + 0x078)); // 0x78 Capnamelist                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Options                                   = (RegexOptions)GetInt32(new IntPtr(p + 0x080)); // 0x80 Options                     ( ModelEnumType RegexOptions RegexOptions RegexOptions Int32 )
            value.OptionsStack                              = GetEnumList<RegexOptions>(new IntPtr(p + 0x088)); // 0x88 OptionsStack                ( ModelEnumListType List`1<RegexOptions> List`1<RegexOptions> List<RegexOptions> Pointer )
            value.IgnoreNextParen                           = GetBool(new IntPtr(p + 0x090)); // 0x90 IgnoreNextParen             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
