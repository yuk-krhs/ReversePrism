using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_VisualTreeUpdaters                     000185B8A560 ModelClassListType IVisualTreeUpdater[] IVisualTreeUpdater[] List<IVisualTreeUpdater> Pointer
    public partial class UpdaterArray : DataModel
    {
        public List<IVisualTreeUpdater>?                M_VisualTreeUpdaters                    { get; set; }

        public static UpdaterArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdaterArray() { Pointer= p0 };

            value.M_VisualTreeUpdaters                      = GetObjectList<IVisualTreeUpdater>(new IntPtr(p + 0x010), ReversePrism.DataModels.IVisualTreeUpdater.FromPointer); // 0245A6820B50 0x10 M_VisualTreeUpdaters        ( 000185B8A560 ModelClassListType IVisualTreeUpdater[] IVisualTreeUpdater[] List<IVisualTreeUpdater> Pointer )

            return value;
        }
    }
}
