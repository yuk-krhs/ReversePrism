using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Store                                    00018675B820 ModelClassType BinaryReader BinaryReader BinaryReader Pointer
    // 018 _resCache                                Dictionary`2<string, ResourceLocator> IL2CPP_TYPE_GENERICINST
    // 020 NameSectionOffset                        0001865F7700 ModelPrimitiveType long long long Int64
    // 028 DataSectionOffset                        0001865F7700 ModelPrimitiveType long long long Int64
    // 030 NameHashes                               000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 _nameHashesPtr                           IntPtr IL2CPP_TYPE_PTR
    // 040 NamePositions                            000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 _namePositionsPtr                        IntPtr IL2CPP_TYPE_PTR
    // 050 TypeTable                                000185B801B0 ModelClassListType RuntimeType[] RuntimeType[] List<RuntimeType> Pointer
    // 058 TypeNamePositions                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 ObjFormatter                             000186757960 ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer
    // 068 NumResources                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 Ums                                      000186733F70 ModelClassType UnmanagedMemoryStream UnmanagedMemoryStream UnmanagedMemoryStream Pointer
    // 078 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ResourceReader
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
            var value   = new ResourceReader();

            value.Store                                     = GetObject<BinaryReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.BinaryReader.FromPointer); // 0270D6CC8250 0x10 Store                       ( 00018675B820 ModelClassType BinaryReader BinaryReader BinaryReader Pointer )
            value.NameSectionOffset                         = GetInt64(new IntPtr(p + 0x020)); // 0270D6CC8290 0x20 NameSectionOffset           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DataSectionOffset                         = GetInt64(new IntPtr(p + 0x028)); // 0270D6CC82B0 0x28 DataSectionOffset           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.NameHashes                                = GetInt32List(new IntPtr(p + 0x030)); // 0270D6CC82D0 0x30 NameHashes                  ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.NamePositions                             = GetInt32List(new IntPtr(p + 0x040)); // 0270D6CC8310 0x40 NamePositions               ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.TypeTable                                 = GetObjectList<RuntimeType>(new IntPtr(p + 0x050), ReversePrism.DataModels.RuntimeType.FromPointer); // 0270D6CC8350 0x50 TypeTable                   ( 000185B801B0 ModelClassListType RuntimeType[] RuntimeType[] List<RuntimeType> Pointer )
            value.TypeNamePositions                         = GetInt32List(new IntPtr(p + 0x058)); // 0270D6CC8370 0x58 TypeNamePositions           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ObjFormatter                              = GetObject<BinaryFormatter>(new IntPtr(p + 0x060), ReversePrism.DataModels.BinaryFormatter.FromPointer); // 0270D6CC8390 0x60 ObjFormatter                ( 000186757960 ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer )
            value.NumResources                              = GetInt32(new IntPtr(p + 0x068)); // 0270D6CC83B0 0x68 NumResources                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Ums                                       = GetObject<UnmanagedMemoryStream>(new IntPtr(p + 0x070), ReversePrism.DataModels.UnmanagedMemoryStream.FromPointer); // 0270D6CC83D0 0x70 Ums                         ( 000186733F70 ModelClassType UnmanagedMemoryStream UnmanagedMemoryStream UnmanagedMemoryStream Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x078)); // 0270D6CC83F0 0x78 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
