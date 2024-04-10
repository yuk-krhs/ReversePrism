using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NType                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Children                                 000185D00FC8 ModelClassListType List`1<RegexNode> List`1<RegexNode> List<RegexNode> Pointer
    // 020 Str                                      0001866722E0 ModelPrimitiveType string string string String
    // 028 Ch                                       char IL2CPP_TYPE_CHAR
    // 02C M                                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 N                                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 Options                                  00018663F340 ModelEnumType RegexOptions RegexOptions RegexOptions Int32
    // 038 Next                                     00018663E480 ModelClassType RegexNode RegexNode RegexNode Pointer
    public partial class RegexNode : DataModel
    {
        public int                                      NType                                   { get; set; }
        public List<RegexNode>?                         Children                                { get; set; }
        public string                                   Str                                     { get; set; }
        public int                                      M                                       { get; set; }
        public int                                      N                                       { get; set; }
        public RegexOptions                             Options                                 { get; set; }
        public RegexNode?                               Next                                    { get; set; }

        public static RegexNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexNode() { Pointer= p0 };

            value.NType                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A3418168 0x10 NType                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Children                                  = GetObjectList<RegexNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.RegexNode.FromPointer); // 0245A3418188 0x18 Children                    ( 000185D00FC8 ModelClassListType List`1<RegexNode> List`1<RegexNode> List<RegexNode> Pointer )
            value.Str                                       = GetString(new IntPtr(p + 0x020)); // 0245A34181A8 0x20 Str                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.M                                         = GetInt32(new IntPtr(p + 0x02C)); // 0245A34181E8 0x2C M                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.N                                         = GetInt32(new IntPtr(p + 0x030)); // 0245A3418208 0x30 N                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Options                                   = (RegexOptions)GetInt32(new IntPtr(p + 0x034)); // 0245A3418228 0x34 Options                     ( 00018663F340 ModelEnumType RegexOptions RegexOptions RegexOptions Int32 )
            value.Next                                      = GetObject<RegexNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.RegexNode.FromPointer); // 0245A3418248 0x38 Next                        ( 00018663E480 ModelClassType RegexNode RegexNode RegexNode Pointer )

            return value;
        }
    }
}
