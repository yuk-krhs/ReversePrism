using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Members                                  000185CB9B18 ModelClassListType EnumMapMember[] EnumMapMember[] List<EnumMapMember> Pointer
    // 018 IsFlags                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 EnumNames                                000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 XmlNames                                 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Values                                   000185B7E5E0 ModelPrimitiveListType long[] long[] List<long> Pointer
    public partial class EnumMap
    {
        public List<EnumMapMember>?                     Members                                 { get; set; }
        public bool                                     IsFlags                                 { get; set; }
        public List<string>?                            EnumNames                               { get; set; }
        public List<string>?                            XmlNames                                { get; set; }
        public List<long>?                              Values                                  { get; set; }

        public static EnumMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumMap();

            value.Members                                   = GetObjectList<EnumMapMember>(new IntPtr(p + 0x010), ReversePrism.DataModels.EnumMapMember.FromPointer); // 0270D74D39B8 0x10 Members                     ( 000185CB9B18 ModelClassListType EnumMapMember[] EnumMapMember[] List<EnumMapMember> Pointer )
            value.IsFlags                                   = GetBool(new IntPtr(p + 0x018)); // 0270D74D39D8 0x18 IsFlags                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.EnumNames                                 = GetStringList(new IntPtr(p + 0x020)); // 0270D74D39F8 0x20 EnumNames                   ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.XmlNames                                  = GetStringList(new IntPtr(p + 0x028)); // 0270D74D3A18 0x28 XmlNames                    ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Values                                    = GetInt64List(new IntPtr(p + 0x030)); // 0270D74D3A38 0x30 Values                      ( 000185B7E5E0 ModelPrimitiveListType long[] long[] List<long> Pointer )

            return value;
        }
    }
}
