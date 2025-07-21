using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sout                                     ModelClassType Stream Stream Stream Pointer
    // 018 FormatterTypeStyle                       ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32
    // 020 ObjectMapTable                           ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 ObjectWriter                             ModelClassType ObjectWriter ObjectWriter ObjectWriter Pointer
    // 030 DataWriter                               ModelClassType BinaryWriter BinaryWriter BinaryWriter Pointer
    // 038 M_nestedObjectCount                      ModelPrimitiveType int int int Int32
    // 03C NullCount                                ModelPrimitiveType int int int Int32
    // 040 BinaryMethodCall                         ModelClassType BinaryMethodCall BinaryMethodCall BinaryMethodCall Pointer
    // 048 BinaryMethodReturn                       ModelClassType BinaryMethodReturn BinaryMethodReturn BinaryMethodReturn Pointer
    // 050 BinaryObject                             ModelClassType BinaryObject BinaryObject BinaryObject Pointer
    // 058 BinaryObjectWithMap                      ModelClassType BinaryObjectWithMap BinaryObjectWithMap BinaryObjectWithMap Pointer
    // 060 BinaryObjectWithMapTyped                 ModelClassType BinaryObjectWithMapTyped BinaryObjectWithMapTyped BinaryObjectWithMapTyped Pointer
    // 068 BinaryObjectString                       ModelClassType BinaryObjectString BinaryObjectString BinaryObjectString Pointer
    // 070 BinaryArray                              ModelClassType BinaryArray BinaryArray BinaryArray Pointer
    // 078 ByteBuffer                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 ChunkSize                                ModelPrimitiveType int int int Int32
    // 088 MemberPrimitiveUnTyped                   ModelClassType MemberPrimitiveUnTyped MemberPrimitiveUnTyped MemberPrimitiveUnTyped Pointer
    // 090 MemberPrimitiveTyped                     ModelClassType MemberPrimitiveTyped MemberPrimitiveTyped MemberPrimitiveTyped Pointer
    // 098 ObjectNull                               ModelClassType ObjectNull ObjectNull ObjectNull Pointer
    // 0A0 MemberReference                          ModelClassType MemberReference MemberReference MemberReference Pointer
    // 0A8 BinaryAssembly                           ModelClassType BinaryAssembly BinaryAssembly BinaryAssembly Pointer
    public partial class __BinaryWriter : DataModel
    {
        public Stream?                                  Sout                                    { get; set; }
        public FormatterTypeStyle                       FormatterTypeStyle                      { get; set; }
        public Hashtable?                               ObjectMapTable                          { get; set; }
        public ObjectWriter?                            ObjectWriter                            { get; set; }
        public BinaryWriter?                            DataWriter                              { get; set; }
        public int                                      M_nestedObjectCount                     { get; set; }
        public int                                      NullCount                               { get; set; }
        public BinaryMethodCall?                        BinaryMethodCall                        { get; set; }
        public BinaryMethodReturn?                      BinaryMethodReturn                      { get; set; }
        public BinaryObject?                            BinaryObject                            { get; set; }
        public BinaryObjectWithMap?                     BinaryObjectWithMap                     { get; set; }
        public BinaryObjectWithMapTyped?                BinaryObjectWithMapTyped                { get; set; }
        public BinaryObjectString?                      BinaryObjectString                      { get; set; }
        public BinaryArray?                             BinaryArray                             { get; set; }
        public List<sbyte>?                             ByteBuffer                              { get; set; }
        public int                                      ChunkSize                               { get; set; }
        public MemberPrimitiveUnTyped?                  MemberPrimitiveUnTyped                  { get; set; }
        public MemberPrimitiveTyped?                    MemberPrimitiveTyped                    { get; set; }
        public ObjectNull?                              ObjectNull                              { get; set; }
        public MemberReference?                         MemberReference                         { get; set; }
        public BinaryAssembly?                          BinaryAssembly                          { get; set; }

        public static __BinaryWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new __BinaryWriter() { Pointer= p0 };

            value.Sout                                      = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0x10 Sout                        ( ModelClassType Stream Stream Stream Pointer )
            value.FormatterTypeStyle                        = (FormatterTypeStyle)GetInt32(new IntPtr(p + 0x018)); // 0x18 FormatterTypeStyle          ( ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32 )
            value.ObjectMapTable                            = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 ObjectMapTable              ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ObjectWriter                              = GetObject<ObjectWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.ObjectWriter.FromPointer); // 0x28 ObjectWriter                ( ModelClassType ObjectWriter ObjectWriter ObjectWriter Pointer )
            value.DataWriter                                = GetObject<BinaryWriter>(new IntPtr(p + 0x030), ReversePrism.DataModels.BinaryWriter.FromPointer); // 0x30 DataWriter                  ( ModelClassType BinaryWriter BinaryWriter BinaryWriter Pointer )
            value.M_nestedObjectCount                       = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_nestedObjectCount         ( ModelPrimitiveType int int int Int32 )
            value.NullCount                                 = GetInt32(new IntPtr(p + 0x03C)); // 0x3C NullCount                   ( ModelPrimitiveType int int int Int32 )
            value.BinaryMethodCall                          = GetObject<BinaryMethodCall>(new IntPtr(p + 0x040), ReversePrism.DataModels.BinaryMethodCall.FromPointer); // 0x40 BinaryMethodCall            ( ModelClassType BinaryMethodCall BinaryMethodCall BinaryMethodCall Pointer )
            value.BinaryMethodReturn                        = GetObject<BinaryMethodReturn>(new IntPtr(p + 0x048), ReversePrism.DataModels.BinaryMethodReturn.FromPointer); // 0x48 BinaryMethodReturn          ( ModelClassType BinaryMethodReturn BinaryMethodReturn BinaryMethodReturn Pointer )
            value.BinaryObject                              = GetObject<BinaryObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.BinaryObject.FromPointer); // 0x50 BinaryObject                ( ModelClassType BinaryObject BinaryObject BinaryObject Pointer )
            value.BinaryObjectWithMap                       = GetObject<BinaryObjectWithMap>(new IntPtr(p + 0x058), ReversePrism.DataModels.BinaryObjectWithMap.FromPointer); // 0x58 BinaryObjectWithMap         ( ModelClassType BinaryObjectWithMap BinaryObjectWithMap BinaryObjectWithMap Pointer )
            value.BinaryObjectWithMapTyped                  = GetObject<BinaryObjectWithMapTyped>(new IntPtr(p + 0x060), ReversePrism.DataModels.BinaryObjectWithMapTyped.FromPointer); // 0x60 BinaryObjectWithMapTyped    ( ModelClassType BinaryObjectWithMapTyped BinaryObjectWithMapTyped BinaryObjectWithMapTyped Pointer )
            value.BinaryObjectString                        = GetObject<BinaryObjectString>(new IntPtr(p + 0x068), ReversePrism.DataModels.BinaryObjectString.FromPointer); // 0x68 BinaryObjectString          ( ModelClassType BinaryObjectString BinaryObjectString BinaryObjectString Pointer )
            value.BinaryArray                               = GetObject<BinaryArray>(new IntPtr(p + 0x070), ReversePrism.DataModels.BinaryArray.FromPointer); // 0x70 BinaryArray                 ( ModelClassType BinaryArray BinaryArray BinaryArray Pointer )
            value.ByteBuffer                                = GetSByteList(new IntPtr(p + 0x078)); // 0x78 ByteBuffer                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ChunkSize                                 = GetInt32(new IntPtr(p + 0x080)); // 0x80 ChunkSize                   ( ModelPrimitiveType int int int Int32 )
            value.MemberPrimitiveUnTyped                    = GetObject<MemberPrimitiveUnTyped>(new IntPtr(p + 0x088), ReversePrism.DataModels.MemberPrimitiveUnTyped.FromPointer); // 0x88 MemberPrimitiveUnTyped      ( ModelClassType MemberPrimitiveUnTyped MemberPrimitiveUnTyped MemberPrimitiveUnTyped Pointer )
            value.MemberPrimitiveTyped                      = GetObject<MemberPrimitiveTyped>(new IntPtr(p + 0x090), ReversePrism.DataModels.MemberPrimitiveTyped.FromPointer); // 0x90 MemberPrimitiveTyped        ( ModelClassType MemberPrimitiveTyped MemberPrimitiveTyped MemberPrimitiveTyped Pointer )
            value.ObjectNull                                = GetObject<ObjectNull>(new IntPtr(p + 0x098), ReversePrism.DataModels.ObjectNull.FromPointer); // 0x98 ObjectNull                  ( ModelClassType ObjectNull ObjectNull ObjectNull Pointer )
            value.MemberReference                           = GetObject<MemberReference>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MemberReference.FromPointer); // 0xA0 MemberReference             ( ModelClassType MemberReference MemberReference MemberReference Pointer )
            value.BinaryAssembly                            = GetObject<BinaryAssembly>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.BinaryAssembly.FromPointer); // 0xA8 BinaryAssembly              ( ModelClassType BinaryAssembly BinaryAssembly BinaryAssembly Pointer )

            return value;
        }
    }
}
