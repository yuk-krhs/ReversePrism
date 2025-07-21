using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Idx                                      ModelPrimitiveType int int int Int32
    // 014 IsHole                                   ModelPrimitiveType bool bool bool Bool
    // 015 IsOpen                                   ModelPrimitiveType bool bool bool Bool
    // 018 FirstLeft                                ModelClassType OutRec OutRec OutRec Pointer
    // 020 Pts                                      ModelClassType OutPt OutPt OutPt Pointer
    // 028 BottomPt                                 ModelClassType OutPt OutPt OutPt Pointer
    // 030 PolyNode                                 ModelClassType PolyNode PolyNode PolyNode Pointer
    public partial class OutRec : DataModel
    {
        public int                                      Idx                                     { get; set; }
        public bool                                     IsHole                                  { get; set; }
        public bool                                     IsOpen                                  { get; set; }
        public OutRec?                                  FirstLeft                               { get; set; }
        public OutPt?                                   Pts                                     { get; set; }
        public OutPt?                                   BottomPt                                { get; set; }
        public PolyNode?                                PolyNode                                { get; set; }

        public static OutRec? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutRec() { Pointer= p0 };

            value.Idx                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Idx                         ( ModelPrimitiveType int int int Int32 )
            value.IsHole                                    = GetBool(new IntPtr(p + 0x014)); // 0x14 IsHole                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x015)); // 0x15 IsOpen                      ( ModelPrimitiveType bool bool bool Bool )
            value.FirstLeft                                 = GetObject<OutRec>(new IntPtr(p + 0x018), ReversePrism.DataModels.OutRec.FromPointer); // 0x18 FirstLeft                   ( ModelClassType OutRec OutRec OutRec Pointer )
            value.Pts                                       = GetObject<OutPt>(new IntPtr(p + 0x020), ReversePrism.DataModels.OutPt.FromPointer); // 0x20 Pts                         ( ModelClassType OutPt OutPt OutPt Pointer )
            value.BottomPt                                  = GetObject<OutPt>(new IntPtr(p + 0x028), ReversePrism.DataModels.OutPt.FromPointer); // 0x28 BottomPt                    ( ModelClassType OutPt OutPt OutPt Pointer )
            value.PolyNode                                  = GetObject<PolyNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.PolyNode.FromPointer); // 0x30 PolyNode                    ( ModelClassType PolyNode PolyNode PolyNode Pointer )

            return value;
        }
    }
}
