using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Store                                    ModelClassType BinaryReader BinaryReader BinaryReader Pointer
    // 018 _resCache                                Dictionary`2<string, ResourceLocator> IL2CPP_TYPE_GENERICINST
    // 020 NameSectionOffset                        ModelPrimitiveType long long long Int64
    // 028 DataSectionOffset                        ModelPrimitiveType long long long Int64
    // 030 NameHashes                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 _nameHashesPtr                           IntPtr IL2CPP_TYPE_PTR
    // 040 NamePositions                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 _namePositionsPtr                        IntPtr IL2CPP_TYPE_PTR
    // 050 TypeTable                                ModelClassListType RuntimeType[] RuntimeType[] List<RuntimeType> Pointer
    // 058 TypeNamePositions                        ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 ObjFormatter                             ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer
    // 068 NumResources                             ModelPrimitiveType int int int Int32
    // 070 Ums                                      ModelClassType UnmanagedMemoryStream UnmanagedMemoryStream UnmanagedMemoryStream Pointer
    // 078 Version                                  ModelPrimitiveType int int int Int32
    public partial class ResourceReader : DataModel
    {
        public BinaryReader?                            Store                                   { get; set; }
        public long                                     NameSectionOffset                       { get; set; }
        public long                                     DataSectionOffset                       { get; set; }
        public List<int>?                               NameHashes                              { get; set; }
        public List<int>?                               NamePositions                           { get; set; }
        public List<RuntimeType>?                       TypeTable                               { get; set; }
        public List<int>?                               TypeNamePositions                       { get; set; }
        public BinaryFormatter?                         ObjFormatter                            { get; set; }
        public int                                      NumResources                            { get; set; }
        public UnmanagedMemoryStream?                   Ums                                     { get; set; }
        public int                                      Version                                 { get; set; }

        public static ResourceReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceReader() { Pointer= p0 };

            value.Store                                     = GetObject<BinaryReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.BinaryReader.FromPointer); // 0x10 Store                       ( ModelClassType BinaryReader BinaryReader BinaryReader Pointer )
            value.NameSectionOffset                         = GetInt64(new IntPtr(p + 0x020)); // 0x20 NameSectionOffset           ( ModelPrimitiveType long long long Int64 )
            value.DataSectionOffset                         = GetInt64(new IntPtr(p + 0x028)); // 0x28 DataSectionOffset           ( ModelPrimitiveType long long long Int64 )
            value.NameHashes                                = GetInt32List(new IntPtr(p + 0x030)); // 0x30 NameHashes                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.NamePositions                             = GetInt32List(new IntPtr(p + 0x040)); // 0x40 NamePositions               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.TypeTable                                 = GetObjectList<RuntimeType>(new IntPtr(p + 0x050), ReversePrism.DataModels.RuntimeType.FromPointer); // 0x50 TypeTable                   ( ModelClassListType RuntimeType[] RuntimeType[] List<RuntimeType> Pointer )
            value.TypeNamePositions                         = GetInt32List(new IntPtr(p + 0x058)); // 0x58 TypeNamePositions           ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ObjFormatter                              = GetObject<BinaryFormatter>(new IntPtr(p + 0x060), ReversePrism.DataModels.BinaryFormatter.FromPointer); // 0x60 ObjFormatter                ( ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer )
            value.NumResources                              = GetInt32(new IntPtr(p + 0x068)); // 0x68 NumResources                ( ModelPrimitiveType int int int Int32 )
            value.Ums                                       = GetObject<UnmanagedMemoryStream>(new IntPtr(p + 0x070), ReversePrism.DataModels.UnmanagedMemoryStream.FromPointer); // 0x70 Ums                         ( ModelClassType UnmanagedMemoryStream UnmanagedMemoryStream UnmanagedMemoryStream Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x078)); // 0x78 Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
