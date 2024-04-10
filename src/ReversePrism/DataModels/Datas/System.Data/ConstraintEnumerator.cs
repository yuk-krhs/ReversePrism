using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tables                                   00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 018 Constraints                              00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 020 CurrentObject                            00018660CA50 ModelClassType Constraint Constraint Constraint Pointer
    public partial class ConstraintEnumerator : DataModel
    {
        public IEnumerator?                             Tables                                  { get; set; }
        public IEnumerator?                             Constraints                             { get; set; }
        public Constraint?                              CurrentObject                           { get; set; }

        public static ConstraintEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstraintEnumerator() { Pointer= p0 };

            value.Tables                                    = GetObject<IEnumerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEnumerator.FromPointer); // 024668919C28 0x10 Tables                      ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.Constraints                               = GetObject<IEnumerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEnumerator.FromPointer); // 024668919C48 0x18 Constraints                 ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.CurrentObject                             = GetObject<Constraint>(new IntPtr(p + 0x020), ReversePrism.DataModels.Constraint.FromPointer); // 024668919C68 0x20 CurrentObject               ( 00018660CA50 ModelClassType Constraint Constraint Constraint Pointer )

            return value;
        }
    }
}
