using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectName                               ModelPrimitiveType string string string String
    // 018 ObjectType                               ModelClassType Type Type Type Pointer
    // 020 BinaryTypeEnumA                          ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer
    // 028 typeInformationA                         <object>[] IL2CPP_TYPE_SZARRAY
    // 030 MemberTypes                              ModelClassListType Type[] Type[] List<Type> Pointer
    // 038 MemberNames                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 ObjectInfo                               ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer
    // 048 IsInitObjectInfo                         ModelPrimitiveType bool bool bool Bool
    // 050 ObjectReader                             ModelClassType ObjectReader ObjectReader ObjectReader Pointer
    // 058 ObjectId                                 ModelPrimitiveType int int int Int32
    // 060 AssemblyInfo                             ModelClassType BinaryAssemblyInfo BinaryAssemblyInfo BinaryAssemblyInfo Pointer
    public partial class ObjectMap : DataModel
    {
        public string                                   ObjectName                              { get; set; }
        public Type?                                    ObjectType                              { get; set; }
        public List<BinaryTypeEnum>?                    BinaryTypeEnumA                         { get; set; }
        public List<Type>?                              MemberTypes                             { get; set; }
        public List<string>?                            MemberNames                             { get; set; }
        public ReadObjectInfo?                          ObjectInfo                              { get; set; }
        public bool                                     IsInitObjectInfo                        { get; set; }
        public ObjectReader?                            ObjectReader                            { get; set; }
        public int                                      ObjectId                                { get; set; }
        public BinaryAssemblyInfo?                      AssemblyInfo                            { get; set; }

        public static ObjectMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectMap() { Pointer= p0 };

            value.ObjectName                                = GetString(new IntPtr(p + 0x010)); // 0x10 ObjectName                  ( ModelPrimitiveType string string string String )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 ObjectType                  ( ModelClassType Type Type Type Pointer )
            value.BinaryTypeEnumA                           = GetEnumList<BinaryTypeEnum>(new IntPtr(p + 0x020)); // 0x20 BinaryTypeEnumA             ( ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 MemberTypes                 ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x038)); // 0x38 MemberNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ObjectInfo                                = GetObject<ReadObjectInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.ReadObjectInfo.FromPointer); // 0x40 ObjectInfo                  ( ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer )
            value.IsInitObjectInfo                          = GetBool(new IntPtr(p + 0x048)); // 0x48 IsInitObjectInfo            ( ModelPrimitiveType bool bool bool Bool )
            value.ObjectReader                              = GetObject<ObjectReader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ObjectReader.FromPointer); // 0x50 ObjectReader                ( ModelClassType ObjectReader ObjectReader ObjectReader Pointer )
            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x058)); // 0x58 ObjectId                    ( ModelPrimitiveType int int int Int32 )
            value.AssemblyInfo                              = GetObject<BinaryAssemblyInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.BinaryAssemblyInfo.FromPointer); // 0x60 AssemblyInfo                ( ModelClassType BinaryAssemblyInfo BinaryAssemblyInfo BinaryAssemblyInfo Pointer )

            return value;
        }
    }
}
