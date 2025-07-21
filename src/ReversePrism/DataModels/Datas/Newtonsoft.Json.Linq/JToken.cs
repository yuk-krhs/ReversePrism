using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _equalityComparer                        JTokenEqualityComparer IL2CPP_TYPE_CLASS
    // 010 Parent                                   ModelClassType JContainer JContainer JContainer Pointer
    // 018 Previous                                 ModelClassType JToken JToken JToken Pointer
    // 020 Next                                     ModelClassType JToken JToken JToken Pointer
    // 028 _annotations                             <object> IL2CPP_TYPE_OBJECT
    // 008 BooleanTypes                             JTokenType[] IL2CPP_TYPE_SZARRAY
    // 010 NumberTypes                              ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 018 BigIntegerTypes                          ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 020 StringTypes                              ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 028 GuidTypes                                ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 030 TimeSpanTypes                            ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 038 UriTypes                                 ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 040 CharTypes                                ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 048 DateTimeTypes                            ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
    // 050 BytesTypes                               ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer
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

            value.Parent                                    = GetObject<JContainer>(new IntPtr(p + 0x010), ReversePrism.DataModels.JContainer.FromPointer); // 0x10 Parent                      ( ModelClassType JContainer JContainer JContainer Pointer )
            value.Previous                                  = GetObject<JToken>(new IntPtr(p + 0x018), ReversePrism.DataModels.JToken.FromPointer); // 0x18 Previous                    ( ModelClassType JToken JToken JToken Pointer )
            value.Next                                      = GetObject<JToken>(new IntPtr(p + 0x020), ReversePrism.DataModels.JToken.FromPointer); // 0x20 Next                        ( ModelClassType JToken JToken JToken Pointer )
            value.NumberTypes                               = GetEnumList<JTokenType>(new IntPtr(p + 0x010)); // 0x10 NumberTypes                 ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.BigIntegerTypes                           = GetEnumList<JTokenType>(new IntPtr(p + 0x018)); // 0x18 BigIntegerTypes             ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.StringTypes                               = GetEnumList<JTokenType>(new IntPtr(p + 0x020)); // 0x20 StringTypes                 ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.GuidTypes                                 = GetEnumList<JTokenType>(new IntPtr(p + 0x028)); // 0x28 GuidTypes                   ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.TimeSpanTypes                             = GetEnumList<JTokenType>(new IntPtr(p + 0x030)); // 0x30 TimeSpanTypes               ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.UriTypes                                  = GetEnumList<JTokenType>(new IntPtr(p + 0x038)); // 0x38 UriTypes                    ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.CharTypes                                 = GetEnumList<JTokenType>(new IntPtr(p + 0x040)); // 0x40 CharTypes                   ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.DateTimeTypes                             = GetEnumList<JTokenType>(new IntPtr(p + 0x048)); // 0x48 DateTimeTypes               ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )
            value.BytesTypes                                = GetEnumList<JTokenType>(new IntPtr(p + 0x050)); // 0x50 BytesTypes                  ( ModelEnumListType JTokenType[] JTokenType[] List<JTokenType> Pointer )

            return value;
        }
    }
}
