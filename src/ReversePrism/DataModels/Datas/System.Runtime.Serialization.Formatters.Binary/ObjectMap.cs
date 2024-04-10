using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectName                               000186671BA0 ModelPrimitiveType string string string String
    // 018 ObjectType                               000186692A80 ModelClassType Type Type Type Pointer
    // 020 BinaryTypeEnumA                          000185B71C30 ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer
    // 028 typeInformationA                         <object>[] IL2CPP_TYPE_SZARRAY
    // 030 MemberTypes                              000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer
    // 038 MemberNames                              000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 ObjectInfo                               0001866181E0 ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer
    // 048 IsInitObjectInfo                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 050 ObjectReader                             0001866CBCE0 ModelClassType ObjectReader ObjectReader ObjectReader Pointer
    // 058 ObjectId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 060 AssemblyInfo                             000186755C80 ModelClassType BinaryAssemblyInfo BinaryAssemblyInfo BinaryAssemblyInfo Pointer
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

            value.ObjectName                                = GetString(new IntPtr(p + 0x010)); // 024666CA3660 0x10 ObjectName                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 024666CA3680 0x18 ObjectType                  ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.BinaryTypeEnumA                           = GetEnumList<BinaryTypeEnum>(new IntPtr(p + 0x020)); // 024666CA36A0 0x20 BinaryTypeEnumA             ( 000185B71C30 ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 024666CA36E0 0x30 MemberTypes                 ( 000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x038)); // 024666CA3700 0x38 MemberNames                 ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ObjectInfo                                = GetObject<ReadObjectInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.ReadObjectInfo.FromPointer); // 024666CA3720 0x40 ObjectInfo                  ( 0001866181E0 ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer )
            value.IsInitObjectInfo                          = GetBool(new IntPtr(p + 0x048)); // 024666CA3740 0x48 IsInitObjectInfo            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ObjectReader                              = GetObject<ObjectReader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ObjectReader.FromPointer); // 024666CA3760 0x50 ObjectReader                ( 0001866CBCE0 ModelClassType ObjectReader ObjectReader ObjectReader Pointer )
            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x058)); // 024666CA3780 0x58 ObjectId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.AssemblyInfo                              = GetObject<BinaryAssemblyInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.BinaryAssemblyInfo.FromPointer); // 024666CA37A0 0x60 AssemblyInfo                ( 000186755C80 ModelClassType BinaryAssemblyInfo BinaryAssemblyInfo BinaryAssemblyInfo Pointer )

            return value;
        }
    }
}
