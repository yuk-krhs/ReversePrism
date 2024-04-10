using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeadTr                                   0001865BCF80 ModelClassType CmnTableTr CmnTableTr CmnTableTr Pointer
    // 028 RowTr                                    0001865BCF80 ModelClassType CmnTableTr CmnTableTr CmnTableTr Pointer
    // 030 Headlayout                               00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 038 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 CmnTableTrs                              000185CD2BC8 ModelClassListType List`1<CmnTableTr> List`1<CmnTableTr> List<CmnTableTr> Pointer
    public partial class CmnTable : DataModel
    {
        public CmnTableTr?                              HeadTr                                  { get; set; }
        public CmnTableTr?                              RowTr                                   { get; set; }
        public LayoutElement?                           Headlayout                              { get; set; }
        public RectTransform?                           RectTransform                           { get; set; }
        public List<CmnTableTr>?                        CmnTableTrs                             { get; set; }

        public static CmnTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CmnTable() { Pointer= p0 };

            value.HeadTr                                    = GetObject<CmnTableTr>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnTableTr.FromPointer); // 024664F36880 0x20 HeadTr                      ( 0001865BCF80 ModelClassType CmnTableTr CmnTableTr CmnTableTr Pointer )
            value.RowTr                                     = GetObject<CmnTableTr>(new IntPtr(p + 0x028), ReversePrism.DataModels.CmnTableTr.FromPointer); // 024664F368A0 0x28 RowTr                       ( 0001865BCF80 ModelClassType CmnTableTr CmnTableTr CmnTableTr Pointer )
            value.Headlayout                                = GetObject<LayoutElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.LayoutElement.FromPointer); // 024664F368C0 0x30 Headlayout                  ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 024664F368E0 0x38 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CmnTableTrs                               = GetObjectList<CmnTableTr>(new IntPtr(p + 0x040), ReversePrism.DataModels.CmnTableTr.FromPointer); // 024664F36900 0x40 CmnTableTrs                 ( 000185CD2BC8 ModelClassListType List`1<CmnTableTr> List`1<CmnTableTr> List<CmnTableTr> Pointer )

            return value;
        }
    }
}
