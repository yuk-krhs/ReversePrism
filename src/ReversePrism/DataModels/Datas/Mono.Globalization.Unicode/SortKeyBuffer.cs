using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 L1b                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 L2b                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 L3b                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 L4sb                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 L4tb                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 L4kb                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 L4wb                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 L5b                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Source                                   ModelPrimitiveType string string string String
    // 058 L1                                       ModelPrimitiveType int int int Int32
    // 05C L2                                       ModelPrimitiveType int int int Int32
    // 060 L3                                       ModelPrimitiveType int int int Int32
    // 064 L4s                                      ModelPrimitiveType int int int Int32
    // 068 L4t                                      ModelPrimitiveType int int int Int32
    // 06C L4k                                      ModelPrimitiveType int int int Int32
    // 070 L4w                                      ModelPrimitiveType int int int Int32
    // 074 L5                                       ModelPrimitiveType int int int Int32
    // 078 Lcid                                     ModelPrimitiveType int int int Int32
    // 07C Options                                  ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    // 080 ProcessLevel2                            ModelPrimitiveType bool bool bool Bool
    // 081 FrenchSort                               ModelPrimitiveType bool bool bool Bool
    // 082 FrenchSorted                             ModelPrimitiveType bool bool bool Bool
    public partial class SortKeyBuffer : DataModel
    {
        public List<sbyte>?                             L1b                                     { get; set; }
        public List<sbyte>?                             L2b                                     { get; set; }
        public List<sbyte>?                             L3b                                     { get; set; }
        public List<sbyte>?                             L4sb                                    { get; set; }
        public List<sbyte>?                             L4tb                                    { get; set; }
        public List<sbyte>?                             L4kb                                    { get; set; }
        public List<sbyte>?                             L4wb                                    { get; set; }
        public List<sbyte>?                             L5b                                     { get; set; }
        public string                                   Source                                  { get; set; }
        public int                                      L1                                      { get; set; }
        public int                                      L2                                      { get; set; }
        public int                                      L3                                      { get; set; }
        public int                                      L4s                                     { get; set; }
        public int                                      L4t                                     { get; set; }
        public int                                      L4k                                     { get; set; }
        public int                                      L4w                                     { get; set; }
        public int                                      L5                                      { get; set; }
        public int                                      Lcid                                    { get; set; }
        public CompareOptions                           Options                                 { get; set; }
        public bool                                     ProcessLevel2                           { get; set; }
        public bool                                     FrenchSort                              { get; set; }
        public bool                                     FrenchSorted                            { get; set; }

        public static SortKeyBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortKeyBuffer() { Pointer= p0 };

            value.L1b                                       = GetSByteList(new IntPtr(p + 0x010)); // 0x10 L1b                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.L2b                                       = GetSByteList(new IntPtr(p + 0x018)); // 0x18 L2b                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.L3b                                       = GetSByteList(new IntPtr(p + 0x020)); // 0x20 L3b                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.L4sb                                      = GetSByteList(new IntPtr(p + 0x028)); // 0x28 L4sb                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.L4tb                                      = GetSByteList(new IntPtr(p + 0x030)); // 0x30 L4tb                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.L4kb                                      = GetSByteList(new IntPtr(p + 0x038)); // 0x38 L4kb                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.L4wb                                      = GetSByteList(new IntPtr(p + 0x040)); // 0x40 L4wb                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.L5b                                       = GetSByteList(new IntPtr(p + 0x048)); // 0x48 L5b                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Source                                    = GetString(new IntPtr(p + 0x050)); // 0x50 Source                      ( ModelPrimitiveType string string string String )
            value.L1                                        = GetInt32(new IntPtr(p + 0x058)); // 0x58 L1                          ( ModelPrimitiveType int int int Int32 )
            value.L2                                        = GetInt32(new IntPtr(p + 0x05C)); // 0x5C L2                          ( ModelPrimitiveType int int int Int32 )
            value.L3                                        = GetInt32(new IntPtr(p + 0x060)); // 0x60 L3                          ( ModelPrimitiveType int int int Int32 )
            value.L4s                                       = GetInt32(new IntPtr(p + 0x064)); // 0x64 L4s                         ( ModelPrimitiveType int int int Int32 )
            value.L4t                                       = GetInt32(new IntPtr(p + 0x068)); // 0x68 L4t                         ( ModelPrimitiveType int int int Int32 )
            value.L4k                                       = GetInt32(new IntPtr(p + 0x06C)); // 0x6C L4k                         ( ModelPrimitiveType int int int Int32 )
            value.L4w                                       = GetInt32(new IntPtr(p + 0x070)); // 0x70 L4w                         ( ModelPrimitiveType int int int Int32 )
            value.L5                                        = GetInt32(new IntPtr(p + 0x074)); // 0x74 L5                          ( ModelPrimitiveType int int int Int32 )
            value.Lcid                                      = GetInt32(new IntPtr(p + 0x078)); // 0x78 Lcid                        ( ModelPrimitiveType int int int Int32 )
            value.Options                                   = (CompareOptions)GetInt32(new IntPtr(p + 0x07C)); // 0x7C Options                     ( ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )
            value.ProcessLevel2                             = GetBool(new IntPtr(p + 0x080)); // 0x80 ProcessLevel2               ( ModelPrimitiveType bool bool bool Bool )
            value.FrenchSort                                = GetBool(new IntPtr(p + 0x081)); // 0x81 FrenchSort                  ( ModelPrimitiveType bool bool bool Bool )
            value.FrenchSorted                              = GetBool(new IntPtr(p + 0x082)); // 0x82 FrenchSorted                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
