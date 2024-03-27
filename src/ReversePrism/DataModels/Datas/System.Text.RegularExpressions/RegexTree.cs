using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Root                                     00018663E6F0 ModelClassType RegexNode RegexNode RegexNode Pointer
    // 018 Caps                                     0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 CapNumList                               000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 CapTop                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 030 CapNames                                 0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 CapsList                                 000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 Options                                  00018663F340 ModelEnumType RegexOptions RegexOptions RegexOptions Int32
    public partial class RegexTree
    {
        public RegexNode?                               Root                                    { get; set; }
        public Hashtable?                               Caps                                    { get; set; }
        public List<int>?                               CapNumList                              { get; set; }
        public int                                      CapTop                                  { get; set; }
        public Hashtable?                               CapNames                                { get; set; }
        public List<string>?                            CapsList                                { get; set; }
        public RegexOptions                             Options                                 { get; set; }

        public static RegexTree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexTree();

            value.Root                                      = GetObject<RegexNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.RegexNode.FromPointer); // 0270033FC2E0 0x10 Root                        ( 00018663E6F0 ModelClassType RegexNode RegexNode RegexNode Pointer )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0270033FC300 0x18 Caps                        ( 0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CapNumList                                = GetInt32List(new IntPtr(p + 0x020)); // 0270033FC320 0x20 CapNumList                  ( 000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CapTop                                    = GetInt32(new IntPtr(p + 0x028)); // 0270033FC340 0x28 CapTop                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.CapNames                                  = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 0270033FC360 0x30 CapNames                    ( 0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CapsList                                  = GetStringList(new IntPtr(p + 0x038)); // 0270033FC380 0x38 CapsList                    ( 000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Options                                   = (RegexOptions)GetInt32(new IntPtr(p + 0x040)); // 0270033FC3A0 0x40 Options                     ( 00018663F340 ModelEnumType RegexOptions RegexOptions RegexOptions Int32 )

            return value;
        }
    }
}
