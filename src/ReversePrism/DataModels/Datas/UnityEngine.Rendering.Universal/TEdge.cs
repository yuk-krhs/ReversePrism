using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bot                                      ModelEnumType IntPoint IntPoint IntPoint Int32
    // 040 Curr                                     ModelEnumType IntPoint IntPoint IntPoint Int32
    // 070 Top                                      ModelEnumType IntPoint IntPoint IntPoint Int32
    // 0A0 Delta                                    ModelEnumType IntPoint IntPoint IntPoint Int32
    // 0D0 Dx                                       ModelPrimitiveType double double double Double
    // 0D8 PolyTyp                                  ModelEnumType PolyType PolyType PolyType Int32
    // 0DC Side                                     ModelEnumType EdgeSide EdgeSide EdgeSide Int32
    // 0E0 WindDelta                                ModelPrimitiveType int int int Int32
    // 0E4 WindCnt                                  ModelPrimitiveType int int int Int32
    // 0E8 WindCnt2                                 ModelPrimitiveType int int int Int32
    // 0EC OutIdx                                   ModelPrimitiveType int int int Int32
    // 0F0 Next                                     ModelClassType TEdge TEdge TEdge Pointer
    // 0F8 Prev                                     ModelClassType TEdge TEdge TEdge Pointer
    // 100 NextInLML                                ModelClassType TEdge TEdge TEdge Pointer
    // 108 NextInAEL                                ModelClassType TEdge TEdge TEdge Pointer
    // 110 PrevInAEL                                ModelClassType TEdge TEdge TEdge Pointer
    // 118 NextInSEL                                ModelClassType TEdge TEdge TEdge Pointer
    // 120 PrevInSEL                                ModelClassType TEdge TEdge TEdge Pointer
    public partial class TEdge : DataModel
    {
        public IntPoint                                 Bot                                     { get; set; }
        public IntPoint                                 Curr                                    { get; set; }
        public IntPoint                                 Top                                     { get; set; }
        public IntPoint                                 Delta                                   { get; set; }
        public double                                   Dx                                      { get; set; }
        public PolyType                                 PolyTyp                                 { get; set; }
        public EdgeSide                                 Side                                    { get; set; }
        public int                                      WindDelta                               { get; set; }
        public int                                      WindCnt                                 { get; set; }
        public int                                      WindCnt2                                { get; set; }
        public int                                      OutIdx                                  { get; set; }
        public TEdge?                                   Next                                    { get; set; }
        public TEdge?                                   Prev                                    { get; set; }
        public TEdge?                                   NextInLML                               { get; set; }
        public TEdge?                                   NextInAEL                               { get; set; }
        public TEdge?                                   PrevInAEL                               { get; set; }
        public TEdge?                                   NextInSEL                               { get; set; }
        public TEdge?                                   PrevInSEL                               { get; set; }

        public static TEdge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TEdge() { Pointer= p0 };

            value.Bot                                       = (IntPoint)GetInt32(new IntPtr(p + 0x010)); // 0x10 Bot                         ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Curr                                      = (IntPoint)GetInt32(new IntPtr(p + 0x040)); // 0x40 Curr                        ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Top                                       = (IntPoint)GetInt32(new IntPtr(p + 0x070)); // 0x70 Top                         ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Delta                                     = (IntPoint)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Delta                       ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Dx                                        = GetDouble(new IntPtr(p + 0x0D0)); // 0xD0 Dx                          ( ModelPrimitiveType double double double Double )
            value.PolyTyp                                   = (PolyType)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 PolyTyp                     ( ModelEnumType PolyType PolyType PolyType Int32 )
            value.Side                                      = (EdgeSide)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC Side                        ( ModelEnumType EdgeSide EdgeSide EdgeSide Int32 )
            value.WindDelta                                 = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 WindDelta                   ( ModelPrimitiveType int int int Int32 )
            value.WindCnt                                   = GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 WindCnt                     ( ModelPrimitiveType int int int Int32 )
            value.WindCnt2                                  = GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 WindCnt2                    ( ModelPrimitiveType int int int Int32 )
            value.OutIdx                                    = GetInt32(new IntPtr(p + 0x0EC)); // 0xEC OutIdx                      ( ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<TEdge>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.TEdge.FromPointer); // 0xF0 Next                        ( ModelClassType TEdge TEdge TEdge Pointer )
            value.Prev                                      = GetObject<TEdge>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.TEdge.FromPointer); // 0xF8 Prev                        ( ModelClassType TEdge TEdge TEdge Pointer )
            value.NextInLML                                 = GetObject<TEdge>(new IntPtr(p + 0x100), ReversePrism.DataModels.TEdge.FromPointer); // 0x100 NextInLML                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.NextInAEL                                 = GetObject<TEdge>(new IntPtr(p + 0x108), ReversePrism.DataModels.TEdge.FromPointer); // 0x108 NextInAEL                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.PrevInAEL                                 = GetObject<TEdge>(new IntPtr(p + 0x110), ReversePrism.DataModels.TEdge.FromPointer); // 0x110 PrevInAEL                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.NextInSEL                                 = GetObject<TEdge>(new IntPtr(p + 0x118), ReversePrism.DataModels.TEdge.FromPointer); // 0x118 NextInSEL                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.PrevInSEL                                 = GetObject<TEdge>(new IntPtr(p + 0x120), ReversePrism.DataModels.TEdge.FromPointer); // 0x120 PrevInSEL                   ( ModelClassType TEdge TEdge TEdge Pointer )

            return value;
        }
    }
}
