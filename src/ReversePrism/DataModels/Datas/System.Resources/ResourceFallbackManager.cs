using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_startingCulture                        0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 018 M_neutralResourcesCulture                0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 020 M_useParents                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ResourceFallbackManager : DataModel
    {
        public CultureInfo?                             M_startingCulture                       { get; set; }
        public CultureInfo?                             M_neutralResourcesCulture               { get; set; }
        public bool                                     M_useParents                            { get; set; }

        public static ResourceFallbackManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceFallbackManager() { Pointer= p0 };

            value.M_startingCulture                         = GetObject<CultureInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CultureInfo.FromPointer); // 024666D21D90 0x10 M_startingCulture           ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.M_neutralResourcesCulture                 = GetObject<CultureInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.CultureInfo.FromPointer); // 024666D21DB0 0x18 M_neutralResourcesCulture   ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.M_useParents                              = GetBool(new IntPtr(p + 0x020)); // 024666D21DD0 0x20 M_useParents                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
