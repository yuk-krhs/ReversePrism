using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalName                                0001866722E0 ModelPrimitiveType string string string String
    // 018 Ns                                       0001866722E0 ModelPrimitiveType string string string String
    // 020 Prefix                                   0001866722E0 ModelPrimitiveType string string string String
    // 028 AttributeCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 Attributes                               000185B710D0 ModelClassListType AttributeData[] AttributeData[] List<AttributeData> Pointer
    // 038 DataNode                                 00018674B4E0 ModelClassType IDataNode IDataNode IDataNode Pointer
    // 040 ChildElementIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ElementData
    {
        public string                                   LocalName                               { get; set; }
        public string                                   Ns                                      { get; set; }
        public string                                   Prefix                                  { get; set; }
        public int                                      AttributeCount                          { get; set; }
        public List<AttributeData>?                     Attributes                              { get; set; }
        public IDataNode?                               DataNode                                { get; set; }
        public int                                      ChildElementIndex                       { get; set; }

        public static ElementData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementData();

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0270D7D35230 0x10 LocalName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0270D7D35250 0x18 Ns                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0270D7D35270 0x20 Prefix                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x028)); // 0270D7D35290 0x28 AttributeCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetObjectList<AttributeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.AttributeData.FromPointer); // 0270D7D352B0 0x30 Attributes                  ( 000185B710D0 ModelClassListType AttributeData[] AttributeData[] List<AttributeData> Pointer )
            value.DataNode                                  = GetObject<IDataNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDataNode.FromPointer); // 0270D7D352D0 0x38 DataNode                    ( 00018674B4E0 ModelClassType IDataNode IDataNode IDataNode Pointer )
            value.ChildElementIndex                         = GetInt32(new IntPtr(p + 0x040)); // 0270D7D352F0 0x40 ChildElementIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
