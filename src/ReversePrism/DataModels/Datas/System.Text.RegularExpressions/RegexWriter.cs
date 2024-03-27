using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _emitted                                 ValueListBuilder`1<int> IL2CPP_TYPE_GENERICINST
    // 030 _intStack                                ValueListBuilder`1<int> IL2CPP_TYPE_GENERICINST
    // 050 _stringHash                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 058 StringTable                              000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 060 Caps                                     0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 068 TrackCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RegexWriter
    {
        public List<string>?                            StringTable                             { get; set; }
        public Hashtable?                               Caps                                    { get; set; }
        public int                                      TrackCount                              { get; set; }

        public static RegexWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexWriter();

            value.StringTable                               = GetStringList(new IntPtr(p + 0x058)); // 0270D79A1D00 0x58 StringTable                 ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x060), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D79A1D20 0x60 Caps                        ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TrackCount                                = GetInt32(new IntPtr(p + 0x068)); // 0270D79A1D40 0x68 TrackCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
