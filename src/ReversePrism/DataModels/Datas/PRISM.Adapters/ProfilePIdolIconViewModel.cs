using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IconData                                 00018670C7D0 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 018 IsSelectIdol                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ProfilePIdolIconViewModel : DataModel
    {
        public PIdolIcon?                               IconData                                { get; set; }
        public bool                                     IsSelectIdol                            { get; set; }

        public static ProfilePIdolIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolIconViewModel() { Pointer= p0 };

            value.IconData                                  = GetObject<PIdolIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0246667271E8 0x10 IconData                    ( 00018670C7D0 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.IsSelectIdol                              = GetBool(new IntPtr(p + 0x018)); // 024666727208 0x18 IsSelectIdol                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
