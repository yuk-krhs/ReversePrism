using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Document                                 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 018 Reader                                   0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 020 Fixups                                   00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 CollFixups                               0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 CollItemFixups                           00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 TypesCallbacks                           0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 NoIDTargets                              00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 Targets                                  0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 050 DelayedListFixups                        0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 058 EventSource                              0001865C8080 ModelClassType XmlSerializer XmlSerializer XmlSerializer Pointer
    // 060 DelayedFixupId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 ReferencedObjects                        0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 ReadCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 WhileIterationCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 W3SchemaNS                               000186671910 ModelPrimitiveType string string string String
    // 080 W3InstanceNS                             000186671910 ModelPrimitiveType string string string String
    // 088 W3InstanceNS2000                         000186671910 ModelPrimitiveType string string string String
    // 090 W3InstanceNS1999                         000186671910 ModelPrimitiveType string string string String
    // 098 SoapNS                                   000186671910 ModelPrimitiveType string string string String
    // 0A0 WsdlNS                                   000186671910 ModelPrimitiveType string string string String
    // 0A8 NullX                                    000186671910 ModelPrimitiveType string string string String
    // 0B0 Nil                                      000186671910 ModelPrimitiveType string string string String
    // 0B8 TypeX                                    000186671910 ModelPrimitiveType string string string String
    // 0C0 ArrayType                                000186671910 ModelPrimitiveType string string string String
    // 0C8 ArrayQName                               0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSerializationReader
    {
        public XmlDocument?                             Document                                { get; set; }
        public XmlReader?                               Reader                                  { get; set; }
        public ArrayList?                               Fixups                                  { get; set; }
        public Hashtable?                               CollFixups                              { get; set; }
        public ArrayList?                               CollItemFixups                          { get; set; }
        public Hashtable?                               TypesCallbacks                          { get; set; }
        public ArrayList?                               NoIDTargets                             { get; set; }
        public Hashtable?                               Targets                                 { get; set; }
        public Hashtable?                               DelayedListFixups                       { get; set; }
        public XmlSerializer?                           EventSource                             { get; set; }
        public int                                      DelayedFixupId                          { get; set; }
        public Hashtable?                               ReferencedObjects                       { get; set; }
        public int                                      ReadCount                               { get; set; }
        public int                                      WhileIterationCount                     { get; set; }
        public string                                   W3SchemaNS                              { get; set; }
        public string                                   W3InstanceNS                            { get; set; }
        public string                                   W3InstanceNS2000                        { get; set; }
        public string                                   W3InstanceNS1999                        { get; set; }
        public string                                   SoapNS                                  { get; set; }
        public string                                   WsdlNS                                  { get; set; }
        public string                                   NullX                                   { get; set; }
        public string                                   Nil                                     { get; set; }
        public string                                   TypeX                                   { get; set; }
        public string                                   ArrayType                               { get; set; }
        public XmlQualifiedName?                        ArrayQName                              { get; set; }

        public static XmlSerializationReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializationReader();

            value.Document                                  = GetObject<XmlDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDocument.FromPointer); // 0270D74C9410 0x10 Document                    ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlReader.FromPointer); // 0270D74C9430 0x18 Reader                      ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.Fixups                                    = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74C9450 0x20 Fixups                      ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.CollFixups                                = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74C9470 0x28 CollFixups                  ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CollItemFixups                            = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74C9490 0x30 CollItemFixups              ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.TypesCallbacks                            = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74C94B0 0x38 TypesCallbacks              ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NoIDTargets                               = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74C94D0 0x40 NoIDTargets                 ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Targets                                   = GetObject<Hashtable>(new IntPtr(p + 0x048), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74C94F0 0x48 Targets                     ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.DelayedListFixups                         = GetObject<Hashtable>(new IntPtr(p + 0x050), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74C9510 0x50 DelayedListFixups           ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.EventSource                               = GetObject<XmlSerializer>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSerializer.FromPointer); // 0270D74C9530 0x58 EventSource                 ( 0001865C8080 ModelClassType XmlSerializer XmlSerializer XmlSerializer Pointer )
            value.DelayedFixupId                            = GetInt32(new IntPtr(p + 0x060)); // 0270D74C9550 0x60 DelayedFixupId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReferencedObjects                         = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74C9570 0x68 ReferencedObjects           ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ReadCount                                 = GetInt32(new IntPtr(p + 0x070)); // 0270D74C9590 0x70 ReadCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WhileIterationCount                       = GetInt32(new IntPtr(p + 0x074)); // 0270D74C95B0 0x74 WhileIterationCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.W3SchemaNS                                = GetString(new IntPtr(p + 0x078)); // 0270D74C95D0 0x78 W3SchemaNS                  ( 000186671910 ModelPrimitiveType string string string String )
            value.W3InstanceNS                              = GetString(new IntPtr(p + 0x080)); // 0270D74C95F0 0x80 W3InstanceNS                ( 000186671910 ModelPrimitiveType string string string String )
            value.W3InstanceNS2000                          = GetString(new IntPtr(p + 0x088)); // 0270D74C9610 0x88 W3InstanceNS2000            ( 000186671910 ModelPrimitiveType string string string String )
            value.W3InstanceNS1999                          = GetString(new IntPtr(p + 0x090)); // 0270D74C9630 0x90 W3InstanceNS1999            ( 000186671910 ModelPrimitiveType string string string String )
            value.SoapNS                                    = GetString(new IntPtr(p + 0x098)); // 0270D74C9650 0x98 SoapNS                      ( 000186671910 ModelPrimitiveType string string string String )
            value.WsdlNS                                    = GetString(new IntPtr(p + 0x0A0)); // 0270D74C9670 0xA0 WsdlNS                      ( 000186671910 ModelPrimitiveType string string string String )
            value.NullX                                     = GetString(new IntPtr(p + 0x0A8)); // 0270D74C9690 0xA8 NullX                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Nil                                       = GetString(new IntPtr(p + 0x0B0)); // 0270D74C96B0 0xB0 Nil                         ( 000186671910 ModelPrimitiveType string string string String )
            value.TypeX                                     = GetString(new IntPtr(p + 0x0B8)); // 0270D74C96D0 0xB8 TypeX                       ( 000186671910 ModelPrimitiveType string string string String )
            value.ArrayType                                 = GetString(new IntPtr(p + 0x0C0)); // 0270D74C96F0 0xC0 ArrayType                   ( 000186671910 ModelPrimitiveType string string string String )
            value.ArrayQName                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D74C9710 0xC8 ArrayQName                  ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}
