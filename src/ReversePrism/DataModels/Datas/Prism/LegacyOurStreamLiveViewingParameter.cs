using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsLive                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 RoomName                                 000186671910 ModelPrimitiveType string string string String
    // 020 CdnURL                                   000186671910 ModelPrimitiveType string string string String
    // 028 MovieURL                                 000186671910 ModelPrimitiveType string string string String
    // 030 IsPMode                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Title                                    000186671910 ModelPrimitiveType string string string String
    // 040 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 050 ViewStacks                               000185CC58D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LegacyOurStreamLiveViewingParameter : DataModel
    {
        public bool                                     IsLive                                  { get; set; }
        public string                                   RoomName                                { get; set; }
        public string                                   CdnURL                                  { get; set; }
        public string                                   MovieURL                                { get; set; }
        public bool                                     IsPMode                                 { get; set; }
        public string                                   Title                                   { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public List<ViewValue>?                         ViewStacks                              { get; set; }

        public static LegacyOurStreamLiveViewingParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyOurStreamLiveViewingParameter() { Pointer= p0 };

            value.IsLive                                    = GetBool(new IntPtr(p + 0x010)); // 024664F34710 0x10 IsLive                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RoomName                                  = GetString(new IntPtr(p + 0x018)); // 024664F34730 0x18 RoomName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.CdnURL                                    = GetString(new IntPtr(p + 0x020)); // 024664F34750 0x20 CdnURL                      ( 000186671910 ModelPrimitiveType string string string String )
            value.MovieURL                                  = GetString(new IntPtr(p + 0x028)); // 024664F34770 0x28 MovieURL                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsPMode                                   = GetBool(new IntPtr(p + 0x030)); // 024664F34790 0x30 IsPMode                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Title                                     = GetString(new IntPtr(p + 0x038)); // 024664F347B0 0x38 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x040)); // 024664F347D0 0x40 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ViewStacks                                = GetObjectList<ViewValue>(new IntPtr(p + 0x050), ReversePrism.DataModels.ViewValue.FromPointer); // 024664F347F0 0x50 ViewStacks                  ( 000185CC58D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
