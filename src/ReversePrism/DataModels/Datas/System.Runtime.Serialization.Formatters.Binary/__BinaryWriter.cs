using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sout                                     000186670490 ModelClassType Stream Stream Stream Pointer
    // 018 FormatterTypeStyle                       0001865B8CB0 ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32
    // 020 ObjectMapTable                           0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 ObjectWriter                             0001866CD980 ModelClassType ObjectWriter ObjectWriter ObjectWriter Pointer
    // 030 DataWriter                               00018675BEE0 ModelClassType BinaryWriter BinaryWriter BinaryWriter Pointer
    // 038 M_nestedObjectCount                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C NullCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 BinaryMethodCall                         000186758A00 ModelClassType BinaryMethodCall BinaryMethodCall BinaryMethodCall Pointer
    // 048 BinaryMethodReturn                       000186758E80 ModelClassType BinaryMethodReturn BinaryMethodReturn BinaryMethodReturn Pointer
    // 050 BinaryObject                             000186759860 ModelClassType BinaryObject BinaryObject BinaryObject Pointer
    // 058 BinaryObjectWithMap                      00018675A4C0 ModelClassType BinaryObjectWithMap BinaryObjectWithMap BinaryObjectWithMap Pointer
    // 060 BinaryObjectWithMapTyped                 00018675ABC0 ModelClassType BinaryObjectWithMapTyped BinaryObjectWithMapTyped BinaryObjectWithMapTyped Pointer
    // 068 BinaryObjectString                       000186759D40 ModelClassType BinaryObjectString BinaryObjectString BinaryObjectString Pointer
    // 070 BinaryArray                              000186754970 ModelClassType BinaryArray BinaryArray BinaryArray Pointer
    // 078 ByteBuffer                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 ChunkSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 MemberPrimitiveUnTyped                   0001865F3920 ModelClassType MemberPrimitiveUnTyped MemberPrimitiveUnTyped MemberPrimitiveUnTyped Pointer
    // 090 MemberPrimitiveTyped                     0001865F3440 ModelClassType MemberPrimitiveTyped MemberPrimitiveTyped MemberPrimitiveTyped Pointer
    // 098 ObjectNull                               0001866CA740 ModelClassType ObjectNull ObjectNull ObjectNull Pointer
    // 0A0 MemberReference                          0001865F3DC0 ModelClassType MemberReference MemberReference MemberReference Pointer
    // 0A8 BinaryAssembly                           000186755550 ModelClassType BinaryAssembly BinaryAssembly BinaryAssembly Pointer
    public partial class __BinaryWriter
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
            var value   = new __BinaryWriter();

            value.Sout                                      = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0270D6C2DF98 0x10 Sout                        ( 000186670490 ModelClassType Stream Stream Stream Pointer )
            value.FormatterTypeStyle                        = (FormatterTypeStyle)GetInt32(new IntPtr(p + 0x018)); // 0270D6C2DFB8 0x18 FormatterTypeStyle          ( 0001865B8CB0 ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32 )
            value.ObjectMapTable                            = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6C2DFD8 0x20 ObjectMapTable              ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ObjectWriter                              = GetObject<ObjectWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.ObjectWriter.FromPointer); // 0270D6C2DFF8 0x28 ObjectWriter                ( 0001866CD980 ModelClassType ObjectWriter ObjectWriter ObjectWriter Pointer )
            value.DataWriter                                = GetObject<BinaryWriter>(new IntPtr(p + 0x030), ReversePrism.DataModels.BinaryWriter.FromPointer); // 0270D6C2E018 0x30 DataWriter                  ( 00018675BEE0 ModelClassType BinaryWriter BinaryWriter BinaryWriter Pointer )
            value.M_nestedObjectCount                       = GetInt32(new IntPtr(p + 0x038)); // 0270D6C2E038 0x38 M_nestedObjectCount         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NullCount                                 = GetInt32(new IntPtr(p + 0x03C)); // 0270D6C2E058 0x3C NullCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BinaryMethodCall                          = GetObject<BinaryMethodCall>(new IntPtr(p + 0x040), ReversePrism.DataModels.BinaryMethodCall.FromPointer); // 0270D6C2E078 0x40 BinaryMethodCall            ( 000186758A00 ModelClassType BinaryMethodCall BinaryMethodCall BinaryMethodCall Pointer )
            value.BinaryMethodReturn                        = GetObject<BinaryMethodReturn>(new IntPtr(p + 0x048), ReversePrism.DataModels.BinaryMethodReturn.FromPointer); // 0270D6C2E098 0x48 BinaryMethodReturn          ( 000186758E80 ModelClassType BinaryMethodReturn BinaryMethodReturn BinaryMethodReturn Pointer )
            value.BinaryObject                              = GetObject<BinaryObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.BinaryObject.FromPointer); // 0270D6C2E0B8 0x50 BinaryObject                ( 000186759860 ModelClassType BinaryObject BinaryObject BinaryObject Pointer )
            value.BinaryObjectWithMap                       = GetObject<BinaryObjectWithMap>(new IntPtr(p + 0x058), ReversePrism.DataModels.BinaryObjectWithMap.FromPointer); // 0270D6C2E0D8 0x58 BinaryObjectWithMap         ( 00018675A4C0 ModelClassType BinaryObjectWithMap BinaryObjectWithMap BinaryObjectWithMap Pointer )
            value.BinaryObjectWithMapTyped                  = GetObject<BinaryObjectWithMapTyped>(new IntPtr(p + 0x060), ReversePrism.DataModels.BinaryObjectWithMapTyped.FromPointer); // 0270D6C2E0F8 0x60 BinaryObjectWithMapTyped    ( 00018675ABC0 ModelClassType BinaryObjectWithMapTyped BinaryObjectWithMapTyped BinaryObjectWithMapTyped Pointer )
            value.BinaryObjectString                        = GetObject<BinaryObjectString>(new IntPtr(p + 0x068), ReversePrism.DataModels.BinaryObjectString.FromPointer); // 0270D6C2E118 0x68 BinaryObjectString          ( 000186759D40 ModelClassType BinaryObjectString BinaryObjectString BinaryObjectString Pointer )
            value.BinaryArray                               = GetObject<BinaryArray>(new IntPtr(p + 0x070), ReversePrism.DataModels.BinaryArray.FromPointer); // 0270D6C2E138 0x70 BinaryArray                 ( 000186754970 ModelClassType BinaryArray BinaryArray BinaryArray Pointer )
            value.ByteBuffer                                = GetSByteList(new IntPtr(p + 0x078)); // 0270D6C2E158 0x78 ByteBuffer                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ChunkSize                                 = GetInt32(new IntPtr(p + 0x080)); // 0270D6C2E178 0x80 ChunkSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MemberPrimitiveUnTyped                    = GetObject<MemberPrimitiveUnTyped>(new IntPtr(p + 0x088), ReversePrism.DataModels.MemberPrimitiveUnTyped.FromPointer); // 0270D6C2E198 0x88 MemberPrimitiveUnTyped      ( 0001865F3920 ModelClassType MemberPrimitiveUnTyped MemberPrimitiveUnTyped MemberPrimitiveUnTyped Pointer )
            value.MemberPrimitiveTyped                      = GetObject<MemberPrimitiveTyped>(new IntPtr(p + 0x090), ReversePrism.DataModels.MemberPrimitiveTyped.FromPointer); // 0270D6C2E1B8 0x90 MemberPrimitiveTyped        ( 0001865F3440 ModelClassType MemberPrimitiveTyped MemberPrimitiveTyped MemberPrimitiveTyped Pointer )
            value.ObjectNull                                = GetObject<ObjectNull>(new IntPtr(p + 0x098), ReversePrism.DataModels.ObjectNull.FromPointer); // 0270D6C2E1D8 0x98 ObjectNull                  ( 0001866CA740 ModelClassType ObjectNull ObjectNull ObjectNull Pointer )
            value.MemberReference                           = GetObject<MemberReference>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MemberReference.FromPointer); // 0270D6C2E1F8 0xA0 MemberReference             ( 0001865F3DC0 ModelClassType MemberReference MemberReference MemberReference Pointer )
            value.BinaryAssembly                            = GetObject<BinaryAssembly>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.BinaryAssembly.FromPointer); // 0270D6C2E218 0xA8 BinaryAssembly              ( 000186755550 ModelClassType BinaryAssembly BinaryAssembly BinaryAssembly Pointer )

            return value;
        }
    }
}
