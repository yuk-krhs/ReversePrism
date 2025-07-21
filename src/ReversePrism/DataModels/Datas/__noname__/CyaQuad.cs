using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cyasils                                  ModelClassListType List`1<CyaSil> List`1<CyaSil> List<CyaSil> Pointer
    // 018 JointNext                                ModelPrimitiveType bool bool bool Bool
    // 01C Near                                     ModelPrimitiveType float float float Single
    // 020 Far                                      ModelPrimitiveType float float float Single
    // 024 Ratio                                    ModelPrimitiveType float float float Single
    // 028 Sq                                       ModelClassType SeatQuad SeatQuad SeatQuad Pointer
    public partial class CyaQuad : DataModel
    {
        public List<CyaSil>?                            Cyasils                                 { get; set; }
        public bool                                     JointNext                               { get; set; }
        public float                                    Near                                    { get; set; }
        public float                                    Far                                     { get; set; }
        public float                                    Ratio                                   { get; set; }
        public SeatQuad?                                Sq                                      { get; set; }

        public static CyaQuad? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CyaQuad() { Pointer= p0 };

            value.Cyasils                                   = GetObjectList<CyaSil>(new IntPtr(p + 0x010), ReversePrism.DataModels.CyaSil.FromPointer); // 0x10 Cyasils                     ( ModelClassListType List`1<CyaSil> List`1<CyaSil> List<CyaSil> Pointer )
            value.JointNext                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 JointNext                   ( ModelPrimitiveType bool bool bool Bool )
            value.Near                                      = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Near                        ( ModelPrimitiveType float float float Single )
            value.Far                                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 Far                         ( ModelPrimitiveType float float float Single )
            value.Ratio                                     = GetSingle(new IntPtr(p + 0x024)); // 0x24 Ratio                       ( ModelPrimitiveType float float float Single )
            value.Sq                                        = GetObject<SeatQuad>(new IntPtr(p + 0x028), ReversePrism.DataModels.SeatQuad.FromPointer); // 0x28 Sq                          ( ModelClassType SeatQuad SeatQuad SeatQuad Pointer )

            return value;
        }
    }
}
