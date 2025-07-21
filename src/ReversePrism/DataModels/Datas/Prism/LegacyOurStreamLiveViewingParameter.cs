using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstId                                    ModelPrimitiveType int int int Int32
    // 014 IsLive                                   ModelPrimitiveType bool bool bool Bool
    // 018 RoomName                                 ModelPrimitiveType string string string String
    // 020 CdnURL                                   ModelPrimitiveType string string string String
    // 028 MovieURL                                 ModelPrimitiveType string string string String
    // 030 IsPMode                                  ModelPrimitiveType bool bool bool Bool
    // 031 IsPremium                                ModelPrimitiveType bool bool bool Bool
    // 038 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 ViewStacks                               ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LegacyOurStreamLiveViewingParameter : DataModel
    {
        public int                                      MstId                                   { get; set; }
        public bool                                     IsLive                                  { get; set; }
        public string                                   RoomName                                { get; set; }
        public string                                   CdnURL                                  { get; set; }
        public string                                   MovieURL                                { get; set; }
        public bool                                     IsPMode                                 { get; set; }
        public bool                                     IsPremium                               { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public List<ViewValue>?                         ViewStacks                              { get; set; }

        public static LegacyOurStreamLiveViewingParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyOurStreamLiveViewingParameter() { Pointer= p0 };

            value.MstId                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstId                       ( ModelPrimitiveType int int int Int32 )
            value.IsLive                                    = GetBool(new IntPtr(p + 0x014)); // 0x14 IsLive                      ( ModelPrimitiveType bool bool bool Bool )
            value.RoomName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 RoomName                    ( ModelPrimitiveType string string string String )
            value.CdnURL                                    = GetString(new IntPtr(p + 0x020)); // 0x20 CdnURL                      ( ModelPrimitiveType string string string String )
            value.MovieURL                                  = GetString(new IntPtr(p + 0x028)); // 0x28 MovieURL                    ( ModelPrimitiveType string string string String )
            value.IsPMode                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 IsPMode                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x031)); // 0x31 IsPremium                   ( ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x038)); // 0x38 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ViewStacks                                = GetObjectList<ViewValue>(new IntPtr(p + 0x048), ReversePrism.DataModels.ViewValue.FromPointer); // 0x48 ViewStacks                  ( ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
