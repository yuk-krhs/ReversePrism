using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Extensions                               000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer
    // 018 No_cache_headers                         000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 Private_headers                          000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 028 <MaxAge>k__BackingField                  Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 038 MaxStale                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 <MaxStaleLimit>k__BackingField           Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 050 <MinFresh>k__BackingField                Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 060 MustRevalidate                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 NoCache                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 062 NoStore                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 063 NoTransform                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 064 OnlyIfCached                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 065 Private                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 066 ProxyRevalidate                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 067 Public                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 <SharedMaxAge>k__BackingField            Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    public partial class CacheControlHeaderValue
    {
        public List<NameValueHeaderValue>?              Extensions                              { get; set; }
        public List<string>?                            No_cache_headers                        { get; set; }
        public List<string>?                            Private_headers                         { get; set; }
        public bool                                     MaxStale                                { get; set; }
        public bool                                     MustRevalidate                          { get; set; }
        public bool                                     NoCache                                 { get; set; }
        public bool                                     NoStore                                 { get; set; }
        public bool                                     NoTransform                             { get; set; }
        public bool                                     OnlyIfCached                            { get; set; }
        public bool                                     Private                                 { get; set; }
        public bool                                     ProxyRevalidate                         { get; set; }
        public bool                                     Public                                  { get; set; }

        public static CacheControlHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CacheControlHeaderValue();

            value.Extensions                                = GetObjectList<NameValueHeaderValue>(new IntPtr(p + 0x010), ReversePrism.DataModels.NameValueHeaderValue.FromPointer); // 0270DB8431F8 0x10 Extensions                  ( 000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer )
            value.No_cache_headers                          = GetStringList(new IntPtr(p + 0x018)); // 0270DB843218 0x18 No_cache_headers            ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Private_headers                           = GetStringList(new IntPtr(p + 0x020)); // 0270DB843238 0x20 Private_headers             ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.MaxStale                                  = GetBool(new IntPtr(p + 0x038)); // 0270DB843278 0x38 MaxStale                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MustRevalidate                            = GetBool(new IntPtr(p + 0x060)); // 0270DB8432D8 0x60 MustRevalidate              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NoCache                                   = GetBool(new IntPtr(p + 0x061)); // 0270DB8432F8 0x61 NoCache                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NoStore                                   = GetBool(new IntPtr(p + 0x062)); // 0270DB843318 0x62 NoStore                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NoTransform                               = GetBool(new IntPtr(p + 0x063)); // 0270DB843338 0x63 NoTransform                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnlyIfCached                              = GetBool(new IntPtr(p + 0x064)); // 0270DB843358 0x64 OnlyIfCached                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Private                                   = GetBool(new IntPtr(p + 0x065)); // 0270DB843378 0x65 Private                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProxyRevalidate                           = GetBool(new IntPtr(p + 0x066)); // 0270DB843398 0x66 ProxyRevalidate             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Public                                    = GetBool(new IntPtr(p + 0x067)); // 0270DB8433B8 0x67 Public                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
