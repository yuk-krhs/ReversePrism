using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BinaryHeaderSuffix                       string IL2CPP_TYPE_STRING
    // 000 Empty                                    Metadata IL2CPP_TYPE_CLASS
    // 000 CompressionRequestAlgorithmMetadataKey   string IL2CPP_TYPE_STRING
    // 008 EncodingASCII                            Encoding IL2CPP_TYPE_CLASS
    // 010 Entries                                  000185D26BC8 ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer
    // 018 ReadOnly                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Metadata
    {
        public List<Entry>?                             Entries                                 { get; set; }
        public bool                                     ReadOnly                                { get; set; }

        public static Metadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Metadata();

            value.Entries                                   = GetObjectList<Entry>(new IntPtr(p + 0x010), ReversePrism.DataModels.Entry.FromPointer); // 027004B34DC0 0x10 Entries                     ( 000185D26BC8 ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x018)); // 027004B34DE0 0x18 ReadOnly                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
