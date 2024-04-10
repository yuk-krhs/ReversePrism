using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GenericTypeName                          000186671910 ModelPrimitiveType string string string String
    // 018 StableName                               0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 020 ParamGenericInfos                        000185CDE618 ModelClassListType List`1<GenericInfo> List`1<GenericInfo> List<GenericInfo> Pointer
    // 028 NestedParamCounts                        000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class GenericInfo : DataModel
    {
        public string                                   GenericTypeName                         { get; set; }
        public XmlQualifiedName?                        StableName                              { get; set; }
        public List<GenericInfo>?                       ParamGenericInfos                       { get; set; }
        public List<int>?                               NestedParamCounts                       { get; set; }

        public static GenericInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenericInfo() { Pointer= p0 };

            value.GenericTypeName                           = GetString(new IntPtr(p + 0x010)); // 024667D41D48 0x10 GenericTypeName             ( 000186671910 ModelPrimitiveType string string string String )
            value.StableName                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667D41D68 0x18 StableName                  ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ParamGenericInfos                         = GetObjectList<GenericInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.GenericInfo.FromPointer); // 024667D41D88 0x20 ParamGenericInfos           ( 000185CDE618 ModelClassListType List`1<GenericInfo> List`1<GenericInfo> List<GenericInfo> Pointer )
            value.NestedParamCounts                         = GetInt32List(new IntPtr(p + 0x028)); // 024667D41DA8 0x28 NestedParamCounts           ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
