using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _equalityComparer                        JTokenEqualityComparer IL2CPP_TYPE_CLASS
    // 010 Parent                                   000186743A20 ModelClassType JContainer JContainer JContainer Pointer
    // 018 Previous                                 0001865FFEA0 ModelClassType JToken JToken JToken Pointer
    // 020 Next                                     0001865FFEA0 ModelClassType JToken JToken JToken Pointer
    // 028 _annotations                             <object> IL2CPP_TYPE_OBJECT
    // 008 BooleanTypes                             JTokenType[] IL2CPP_TYPE_SZARRAY
    // 010 NumberTypes                              000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 018 BigIntegerTypes                          000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 020 StringTypes                              000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 028 GuidTypes                                000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 030 TimeSpanTypes                            000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 038 UriTypes                                 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 040 CharTypes                                000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 048 DateTimeTypes                            000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 050 BytesTypes                               000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    public partial class JToken : DataModel
    {
        public JContainer?                              Parent                                  { get; set; }
        public JToken?                                  Previous                                { get; set; }
        public JToken?                                  Next                                    { get; set; }
        public List<JTokenType>?                        NumberTypes                             { get; set; }
        public List<JTokenType>?                        BigIntegerTypes                         { get; set; }
        public List<JTokenType>?                        StringTypes                             { get; set; }
        public List<JTokenType>?                        GuidTypes                               { get; set; }
        public List<JTokenType>?                        TimeSpanTypes                           { get; set; }
        public List<JTokenType>?                        UriTypes                                { get; set; }
        public List<JTokenType>?                        CharTypes                               { get; set; }
        public List<JTokenType>?                        DateTimeTypes                           { get; set; }
        public List<JTokenType>?                        BytesTypes                              { get; set; }

        public static JToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JToken() { Pointer= p0 };

            value.Parent                                    = GetObject<JContainer>(new IntPtr(p + 0x010), ReversePrism.DataModels.JContainer.FromPointer); // 0245A609C4D0 0x10 Parent                      ( 000186743A20 ModelClassType JContainer JContainer JContainer Pointer )
            value.Previous                                  = GetObject<JToken>(new IntPtr(p + 0x018), ReversePrism.DataModels.JToken.FromPointer); // 0245A609C4F0 0x18 Previous                    ( 0001865FFEA0 ModelClassType JToken JToken JToken Pointer )
            value.Next                                      = GetObject<JToken>(new IntPtr(p + 0x020), ReversePrism.DataModels.JToken.FromPointer); // 0245A609C510 0x20 Next                        ( 0001865FFEA0 ModelClassType JToken JToken JToken Pointer )
            value.NumberTypes                               = GetEnumList<JTokenType>(new IntPtr(p + 0x010)); // 0245A609C570 0x10 NumberTypes                 ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.BigIntegerTypes                           = GetEnumList<JTokenType>(new IntPtr(p + 0x018)); // 0245A609C590 0x18 BigIntegerTypes             ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.StringTypes                               = GetEnumList<JTokenType>(new IntPtr(p + 0x020)); // 0245A609C5B0 0x20 StringTypes                 ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.GuidTypes                                 = GetEnumList<JTokenType>(new IntPtr(p + 0x028)); // 0245A609C5D0 0x28 GuidTypes                   ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.TimeSpanTypes                             = GetEnumList<JTokenType>(new IntPtr(p + 0x030)); // 0245A609C5F0 0x30 TimeSpanTypes               ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.UriTypes                                  = GetEnumList<JTokenType>(new IntPtr(p + 0x038)); // 0245A609C610 0x38 UriTypes                    ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.CharTypes                                 = GetEnumList<JTokenType>(new IntPtr(p + 0x040)); // 0245A609C630 0x40 CharTypes                   ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.DateTimeTypes                             = GetEnumList<JTokenType>(new IntPtr(p + 0x048)); // 0245A609C650 0x48 DateTimeTypes               ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.BytesTypes                                = GetEnumList<JTokenType>(new IntPtr(p + 0x050)); // 0245A609C670 0x50 BytesTypes                  ( 000185B8EAE0 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )

            return value;
        }
    }
}
