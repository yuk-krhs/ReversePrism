using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bot                                      ModelEnumType IntPoint IntPoint IntPoint Int32
    // 020 Curr                                     ModelEnumType IntPoint IntPoint IntPoint Int32
    // 030 Top                                      ModelEnumType IntPoint IntPoint IntPoint Int32
    // 040 Delta                                    ModelEnumType IntPoint IntPoint IntPoint Int32
    // 050 Dx                                       ModelPrimitiveType double double double Double
    // 058 PolyTyp                                  ModelEnumType PolyType PolyType PolyType Int32
    // 05C Side                                     ModelEnumType EdgeSide EdgeSide EdgeSide Int32
    // 060 WindDelta                                ModelPrimitiveType int int int Int32
    // 064 WindCnt                                  ModelPrimitiveType int int int Int32
    // 068 WindCnt2                                 ModelPrimitiveType int int int Int32
    // 06C OutIdx                                   ModelPrimitiveType int int int Int32
    // 070 Next                                     ModelClassType TEdge TEdge TEdge Pointer
    // 078 Prev                                     ModelClassType TEdge TEdge TEdge Pointer
    // 080 NextInLML                                ModelClassType TEdge TEdge TEdge Pointer
    // 088 NextInAEL                                ModelClassType TEdge TEdge TEdge Pointer
    // 090 PrevInAEL                                ModelClassType TEdge TEdge TEdge Pointer
    // 098 NextInSEL                                ModelClassType TEdge TEdge TEdge Pointer
    // 0A0 PrevInSEL                                ModelClassType TEdge TEdge TEdge Pointer
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
            value.Curr                                      = (IntPoint)GetInt32(new IntPtr(p + 0x020)); // 0x20 Curr                        ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Top                                       = (IntPoint)GetInt32(new IntPtr(p + 0x030)); // 0x30 Top                         ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Delta                                     = (IntPoint)GetInt32(new IntPtr(p + 0x040)); // 0x40 Delta                       ( ModelEnumType IntPoint IntPoint IntPoint Int32 )
            value.Dx                                        = GetDouble(new IntPtr(p + 0x050)); // 0x50 Dx                          ( ModelPrimitiveType double double double Double )
            value.PolyTyp                                   = (PolyType)GetInt32(new IntPtr(p + 0x058)); // 0x58 PolyTyp                     ( ModelEnumType PolyType PolyType PolyType Int32 )
            value.Side                                      = (EdgeSide)GetInt32(new IntPtr(p + 0x05C)); // 0x5C Side                        ( ModelEnumType EdgeSide EdgeSide EdgeSide Int32 )
            value.WindDelta                                 = GetInt32(new IntPtr(p + 0x060)); // 0x60 WindDelta                   ( ModelPrimitiveType int int int Int32 )
            value.WindCnt                                   = GetInt32(new IntPtr(p + 0x064)); // 0x64 WindCnt                     ( ModelPrimitiveType int int int Int32 )
            value.WindCnt2                                  = GetInt32(new IntPtr(p + 0x068)); // 0x68 WindCnt2                    ( ModelPrimitiveType int int int Int32 )
            value.OutIdx                                    = GetInt32(new IntPtr(p + 0x06C)); // 0x6C OutIdx                      ( ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<TEdge>(new IntPtr(p + 0x070), ReversePrism.DataModels.TEdge.FromPointer); // 0x70 Next                        ( ModelClassType TEdge TEdge TEdge Pointer )
            value.Prev                                      = GetObject<TEdge>(new IntPtr(p + 0x078), ReversePrism.DataModels.TEdge.FromPointer); // 0x78 Prev                        ( ModelClassType TEdge TEdge TEdge Pointer )
            value.NextInLML                                 = GetObject<TEdge>(new IntPtr(p + 0x080), ReversePrism.DataModels.TEdge.FromPointer); // 0x80 NextInLML                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.NextInAEL                                 = GetObject<TEdge>(new IntPtr(p + 0x088), ReversePrism.DataModels.TEdge.FromPointer); // 0x88 NextInAEL                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.PrevInAEL                                 = GetObject<TEdge>(new IntPtr(p + 0x090), ReversePrism.DataModels.TEdge.FromPointer); // 0x90 PrevInAEL                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.NextInSEL                                 = GetObject<TEdge>(new IntPtr(p + 0x098), ReversePrism.DataModels.TEdge.FromPointer); // 0x98 NextInSEL                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.PrevInSEL                                 = GetObject<TEdge>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TEdge.FromPointer); // 0xA0 PrevInSEL                   ( ModelClassType TEdge TEdge TEdge Pointer )

            return value;
        }
    }
}
