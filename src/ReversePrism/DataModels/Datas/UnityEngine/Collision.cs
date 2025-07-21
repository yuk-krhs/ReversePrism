using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Header                                 ModelEnumType ContactPairHeader ContactPairHeader ContactPairHeader Int32
    // 038 M_Pair                                   ModelEnumType ContactPair ContactPair ContactPair Int32
    // 060 M_Flipped                                ModelPrimitiveType bool bool bool Bool
    // 068 M_LegacyContacts                         ModelEnumListType ContactPoint[] ContactPoint[] List<ContactPoint> Pointer
    public partial class Collision : DataModel
    {
        public ContactPairHeader                        M_Header                                { get; set; }
        public ContactPair                              M_Pair                                  { get; set; }
        public bool                                     M_Flipped                               { get; set; }
        public List<ContactPoint>?                      M_LegacyContacts                        { get; set; }

        public static Collision? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Collision() { Pointer= p0 };

            value.M_Header                                  = (ContactPairHeader)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Header                    ( ModelEnumType ContactPairHeader ContactPairHeader ContactPairHeader Int32 )
            value.M_Pair                                    = (ContactPair)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_Pair                      ( ModelEnumType ContactPair ContactPair ContactPair Int32 )
            value.M_Flipped                                 = GetBool(new IntPtr(p + 0x060)); // 0x60 M_Flipped                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_LegacyContacts                          = GetEnumList<ContactPoint>(new IntPtr(p + 0x068)); // 0x68 M_LegacyContacts            ( ModelEnumListType ContactPoint[] ContactPoint[] List<ContactPoint> Pointer )

            return value;
        }
    }
}
