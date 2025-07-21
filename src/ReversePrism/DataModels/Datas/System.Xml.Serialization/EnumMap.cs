using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Members                                  ModelClassListType EnumMapMember[] EnumMapMember[] List<EnumMapMember> Pointer
    // 018 IsFlags                                  ModelPrimitiveType bool bool bool Bool
    // 020 EnumNames                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 XmlNames                                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Values                                   ModelPrimitiveListType long[] long[] List<long> Pointer
    public partial class EnumMap : DataModel
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
            var value   = new EnumMap() { Pointer= p0 };

            value.Members                                   = GetObjectList<EnumMapMember>(new IntPtr(p + 0x010), ReversePrism.DataModels.EnumMapMember.FromPointer); // 0x10 Members                     ( ModelClassListType EnumMapMember[] EnumMapMember[] List<EnumMapMember> Pointer )
            value.IsFlags                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 IsFlags                     ( ModelPrimitiveType bool bool bool Bool )
            value.EnumNames                                 = GetStringList(new IntPtr(p + 0x020)); // 0x20 EnumNames                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.XmlNames                                  = GetStringList(new IntPtr(p + 0x028)); // 0x28 XmlNames                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Values                                    = GetInt64List(new IntPtr(p + 0x030)); // 0x30 Values                      ( ModelPrimitiveListType long[] long[] List<long> Pointer )

            return value;
        }
    }
}
