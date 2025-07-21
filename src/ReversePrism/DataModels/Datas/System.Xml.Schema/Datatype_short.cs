using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 atomicValueType                          Type IL2CPP_TYPE_CLASS
    // 008 listValueType                            Type IL2CPP_TYPE_CLASS
    // 010 Numeric10FacetsChecker                   ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    public partial class Datatype_short : DataModel
    {
        public FacetsChecker?                           Numeric10FacetsChecker                  { get; set; }

        public static Datatype_short? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Datatype_short() { Pointer= p0 };

            value.Numeric10FacetsChecker                    = GetObject<FacetsChecker>(new IntPtr(p + 0x010), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x10 Numeric10FacetsChecker      ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )

            return value;
        }
    }
}
