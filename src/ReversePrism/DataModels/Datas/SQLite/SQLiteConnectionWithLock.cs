using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 _lockPoint                               <object> IL2CPP_TYPE_OBJECT
    // 070 SkipLock                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SQLiteConnectionWithLock
    {
        public bool                                     SkipLock                                { get; set; }

        public static SQLiteConnectionWithLock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteConnectionWithLock();

            value.SkipLock                                  = GetBool(new IntPtr(p + 0x070)); // 0270DB302150 0x70 SkipLock                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
