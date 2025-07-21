using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalName                                ModelPrimitiveType string string string String
    // 018 Ns                                       ModelPrimitiveType string string string String
    // 020 Prefix                                   ModelPrimitiveType string string string String
    // 028 AttributeCount                           ModelPrimitiveType int int int Int32
    // 030 Attributes                               ModelClassListType AttributeData[] AttributeData[] List<AttributeData> Pointer
    // 038 DataNode                                 ModelClassType IDataNode IDataNode IDataNode Pointer
    // 040 ChildElementIndex                        ModelPrimitiveType int int int Int32
    public partial class ElementData : DataModel
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
            var value   = new ElementData() { Pointer= p0 };

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 LocalName                   ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Prefix                      ( ModelPrimitiveType string string string String )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 AttributeCount              ( ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetObjectList<AttributeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.AttributeData.FromPointer); // 0x30 Attributes                  ( ModelClassListType AttributeData[] AttributeData[] List<AttributeData> Pointer )
            value.DataNode                                  = GetObject<IDataNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDataNode.FromPointer); // 0x38 DataNode                    ( ModelClassType IDataNode IDataNode IDataNode Pointer )
            value.ChildElementIndex                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 ChildElementIndex           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
