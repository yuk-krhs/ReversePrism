using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tables                                   ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 018 Constraints                              ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 020 CurrentObject                            ModelClassType Constraint Constraint Constraint Pointer
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

            value.Tables                                    = GetObject<IEnumerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEnumerator.FromPointer); // 0x10 Tables                      ( ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.Constraints                               = GetObject<IEnumerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEnumerator.FromPointer); // 0x18 Constraints                 ( ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.CurrentObject                             = GetObject<Constraint>(new IntPtr(p + 0x020), ReversePrism.DataModels.Constraint.FromPointer); // 0x20 CurrentObject               ( ModelClassType Constraint Constraint Constraint Pointer )

            return value;
        }
    }
}
