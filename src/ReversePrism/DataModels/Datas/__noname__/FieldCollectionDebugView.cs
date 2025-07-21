using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Collection                               ModelClassType FieldCollection FieldCollection FieldCollection Pointer
    public partial class FieldCollectionDebugView : DataModel
    {
        public FieldCollection?                         Collection                              { get; set; }

        public static FieldCollectionDebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldCollectionDebugView() { Pointer= p0 };

            value.Collection                                = GetObject<FieldCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.FieldCollection.FromPointer); // 0x10 Collection                  ( ModelClassType FieldCollection FieldCollection FieldCollection Pointer )

            return value;
        }
    }
}
