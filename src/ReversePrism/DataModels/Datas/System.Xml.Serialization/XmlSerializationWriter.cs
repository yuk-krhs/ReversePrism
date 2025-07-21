using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdGenerator                              ModelClassType ObjectIDGenerator ObjectIDGenerator ObjectIDGenerator Pointer
    // 018 QnameCount                               ModelPrimitiveType int int int Int32
    // 01C TopLevelElement                          ModelPrimitiveType bool bool bool Bool
    // 020 Namespaces                               ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 Writer                                   ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 030 ReferencedElements                       ModelClassType Queue Queue Queue Pointer
    // 038 Callbacks                                ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 SerializedObjects                        ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XmlSerializationWriter : DataModel
    {
        public ObjectIDGenerator?                       IdGenerator                             { get; set; }
        public int                                      QnameCount                              { get; set; }
        public bool                                     TopLevelElement                         { get; set; }
        public ArrayList?                               Namespaces                              { get; set; }
        public XmlWriter?                               Writer                                  { get; set; }
        public Queue?                                   ReferencedElements                      { get; set; }
        public Hashtable?                               Callbacks                               { get; set; }
        public Hashtable?                               SerializedObjects                       { get; set; }

        public static XmlSerializationWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializationWriter() { Pointer= p0 };

            value.IdGenerator                               = GetObject<ObjectIDGenerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.ObjectIDGenerator.FromPointer); // 0x10 IdGenerator                 ( ModelClassType ObjectIDGenerator ObjectIDGenerator ObjectIDGenerator Pointer )
            value.QnameCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 QnameCount                  ( ModelPrimitiveType int int int Int32 )
            value.TopLevelElement                           = GetBool(new IntPtr(p + 0x01C)); // 0x1C TopLevelElement             ( ModelPrimitiveType bool bool bool Bool )
            value.Namespaces                                = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0x20 Namespaces                  ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Writer                                    = GetObject<XmlWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlWriter.FromPointer); // 0x28 Writer                      ( ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.ReferencedElements                        = GetObject<Queue>(new IntPtr(p + 0x030), ReversePrism.DataModels.Queue.FromPointer); // 0x30 ReferencedElements          ( ModelClassType Queue Queue Queue Pointer )
            value.Callbacks                                 = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 Callbacks                   ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SerializedObjects                         = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0x40 SerializedObjects           ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
