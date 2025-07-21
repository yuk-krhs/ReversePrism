using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GenericTypeName                          ModelPrimitiveType string string string String
    // 018 StableName                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 020 ParamGenericInfos                        ModelClassListType List`1<GenericInfo> List`1<GenericInfo> List<GenericInfo> Pointer
    // 028 NestedParamCounts                        ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
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

            value.GenericTypeName                           = GetString(new IntPtr(p + 0x010)); // 0x10 GenericTypeName             ( ModelPrimitiveType string string string String )
            value.StableName                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x18 StableName                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ParamGenericInfos                         = GetObjectList<GenericInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.GenericInfo.FromPointer); // 0x20 ParamGenericInfos           ( ModelClassListType List`1<GenericInfo> List`1<GenericInfo> List<GenericInfo> Pointer )
            value.NestedParamCounts                         = GetInt32List(new IntPtr(p + 0x028)); // 0x28 NestedParamCounts           ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
